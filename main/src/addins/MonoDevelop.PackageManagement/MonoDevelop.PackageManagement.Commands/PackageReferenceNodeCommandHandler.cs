﻿//
// PackageReferenceNodeCommandHandler.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Commands;
using MonoDevelop.Ide.Gui.Components;
using MonoDevelop.PackageManagement.NodeBuilders;
using MonoDevelop.Projects;

namespace MonoDevelop.PackageManagement.Commands
{
	internal class PackageReferenceNodeCommandHandler : NodeCommandHandler
	{
		public override void DeleteItem ()
		{
			var packageReferenceNode = (PackageReferenceNode)CurrentNode.DataItem;
			ProgressMonitorStatusMessage progressMessage = ProgressMonitorStatusMessageFactory.CreateRemoveSinglePackageMessage (packageReferenceNode.Id);

			try {
				RemovePackage (packageReferenceNode, progressMessage);
			} catch (Exception ex) {
				PackageManagementServices.BackgroundPackageActionRunner.ShowError (progressMessage, ex);
			}
		}

		void RemovePackage (PackageReferenceNode packageReferenceNode, ProgressMonitorStatusMessage progressMessage)
		{
			var solutionManager = new MonoDevelopSolutionManager (packageReferenceNode.Project.ParentSolution);
			var project = new MonoDevelopNuGetProjectFactory ()
				.CreateNuGetProject (packageReferenceNode.Project);
			var action = new UninstallNuGetPackageAction (solutionManager, project) {
				PackageId = packageReferenceNode.Id
			};
			// TODO - handle unrestored NuGet packages.
			//if (action.Package != null) {
				PackageManagementServices.BackgroundPackageActionRunner.Run (progressMessage, action);
			//} else {
			//	ShowMissingPackageError (progressMessage, packageReferenceNode);
			//}
		}

		void ShowMissingPackageError (ProgressMonitorStatusMessage progressMessage, PackageReferenceNode packageReferenceNode)
		{
			string message = GettextCatalog.GetString ("Unable to find package {0} {1} to remove it from the project. Please restore the package first.", packageReferenceNode.Id, packageReferenceNode.Version);
			PackageManagementServices.BackgroundPackageActionRunner.ShowError (progressMessage, message);
		}

		[CommandUpdateHandler (EditCommands.Delete)]
		public void UpdateRemoveItem (CommandInfo info)
		{
			info.Enabled = CanDeleteMultipleItems ();
			info.Text = GettextCatalog.GetString ("Remove");
		}

		public override bool CanDeleteMultipleItems ()
		{
			return !MultipleSelectedNodes;
		}

		[CommandHandler (PackageReferenceNodeCommands.UpdatePackage)]
		public void UpdatePackage ()
		{
			var packageReferenceNode = (PackageReferenceNode)CurrentNode.DataItem;

			try {
				var solutionManager = new MonoDevelopSolutionManager (packageReferenceNode.Project.ParentSolution);
				var project = new MonoDevelopNuGetProjectFactory ()
					.CreateNuGetProject (packageReferenceNode.Project);
				var action = new UpdateNuGetPackageAction (solutionManager, project) {
					PackageId = packageReferenceNode.Id,
					IncludePrerelease = !packageReferenceNode.IsReleaseVersion ()
				};

				// TODO - No updates available status bar message.
				//ProgressMonitorStatusMessage progressMessage = ProgressMonitorStatusMessageFactory.CreateUpdatingSinglePackageMessage (packageReferenceNode.Id, project);
				ProgressMonitorStatusMessage progressMessage = ProgressMonitorStatusMessageFactory.CreateUpdatingSinglePackageMessage (packageReferenceNode.Id);
				UpdatePackage (progressMessage, action);
			} catch (Exception ex) {
				ProgressMonitorStatusMessage progressMessage = ProgressMonitorStatusMessageFactory.CreateUpdatingSinglePackageMessage (packageReferenceNode.Id);
				PackageManagementServices.BackgroundPackageActionRunner.ShowError (progressMessage, ex);
			}
		}

		void UpdatePackage (ProgressMonitorStatusMessage progressMessage, IPackageAction action)
		{
			try {
				PackageManagementServices.BackgroundPackageActionRunner.Run (progressMessage, action);
			} catch (Exception ex) {
				PackageManagementServices.BackgroundPackageActionRunner.ShowError (progressMessage, ex);
			}
		}

		[CommandUpdateHandler (PackageReferenceNodeCommands.ShowPackageVersion)]
		public void UpdateShowPackageVersionItem (CommandInfo info)
		{
			var packageReferenceNode = (PackageReferenceNode)CurrentNode.DataItem;
			info.Enabled = false;
			info.Text = packageReferenceNode.GetPackageVersionLabel ();
		}

		[CommandUpdateHandler (PackageReferenceNodeCommands.ReinstallPackage)]
		public void UpdateReinstallPackageItem (CommandInfo info)
		{
			var packageReferenceNode = (PackageReferenceNode)CurrentNode.DataItem;
			info.Visible = packageReferenceNode.IsReinstallNeeded;
		}

		[CommandHandler (PackageReferenceNodeCommands.ReinstallPackage)]
		public void ReinstallPackage ()
		{
			var packageReferenceNode = (PackageReferenceNode)CurrentNode.DataItem;
			var reinstaller = new PackageReinstaller ();
			reinstaller.Run (packageReferenceNode);
		}

		Solution GetSelectedSolution ()
		{
			var project = IdeApp.ProjectOperations.CurrentSelectedProject as DotNetProject;
			if (project != null) {
				return project.ParentSolution;
			}
			return IdeApp.ProjectOperations.CurrentSelectedSolution;
		}

		IPackageManagementSolution GetPackageManagementSolution ()
		{
			Solution solution = GetSelectedSolution ();
			if (solution != null) {
				return new PackageManagementSolution (new PackageManagementSolutionProjectService (solution));
			}
			return null;
		}
	}
}

