﻿using System;
using System.Collections.Generic;
using MonoDevelop.Ide.Gui;
using Xwt;
using Xwt.Drawing;

namespace MonoDevelop.Ide.BuildOutputView
{
	internal static class Styles
	{
		public static Xwt.Drawing.Color LineBorderColor { get; internal set; }
		public static Xwt.Drawing.Color BackgroundColor { get; internal set; }
		public static Xwt.Drawing.Color PackageInfoBackgroundColor { get; internal set; }
		public static Xwt.Drawing.Color CellBackgroundColor { get; internal set; }
		public static Xwt.Drawing.Color CellSelectionColor { get; internal set; }
		public static Xwt.Drawing.Color CellStrongSelectionColor { get; internal set; }
		public static Xwt.Drawing.Color CellTextColor { get; internal set; }
		public static Xwt.Drawing.Color CellTextSelectionColor { get; internal set; }
		public static Xwt.Drawing.Color PackageSourceUrlTextColor { get; internal set; }
		public static Xwt.Drawing.Color PackageSourceUrlSelectedTextColor { get; internal set; }
		public static Xwt.Drawing.Color PackageSourceErrorTextColor { get; internal set; }
		public static Xwt.Drawing.Color PackageSourceErrorSelectedTextColor { get; internal set; }
		public static Xwt.Drawing.Color ErrorBackgroundColor { get; internal set; }
		public static Xwt.Drawing.Color ErrorForegroundColor { get; internal set; }

		static Styles ()
		{
			LoadStyles ();
			Ide.Gui.Styles.Changed += (o, e) => LoadStyles ();
		}

		public static void LoadStyles ()
		{
			if (IdeApp.Preferences.UserInterfaceTheme == Theme.Light) {
				CellBackgroundColor = Ide.Gui.Styles.PadBackground;
			} else {
				CellBackgroundColor = Xwt.Drawing.Color.FromName ("#3c3c3c");
			}

			// Shared

			BackgroundColor = Ide.Gui.Styles.PrimaryBackgroundColor;

			CellTextColor = Ide.Gui.Styles.BaseForegroundColor;
			CellStrongSelectionColor = Ide.Gui.Styles.BaseSelectionBackgroundColor;
			CellSelectionColor = Ide.Gui.Styles.BaseSelectionBackgroundColor;
			CellTextSelectionColor = Ide.Gui.Styles.BaseSelectionTextColor;

			PackageInfoBackgroundColor = Ide.Gui.Styles.SecondaryBackgroundLighterColor;
			PackageSourceErrorTextColor = Ide.Gui.Styles.ErrorForegroundColor;
			PackageSourceUrlTextColor = Ide.Gui.Styles.SecondaryTextColor;

			PackageSourceErrorSelectedTextColor = PackageSourceErrorTextColor;

			PackageSourceUrlSelectedTextColor = Xwt.Drawing.Color.FromName ("#ffffff");

			LineBorderColor = Ide.Gui.Styles.SeparatorColor;

			ErrorBackgroundColor = Ide.Gui.Styles.StatusWarningBackgroundColor;
			ErrorForegroundColor = Ide.Gui.Styles.StatusWarningTextColor;
		}
	}


	class BuildOutputTreeCellView : CanvasCellView
	{
		
		public double CellWidth { get; set; }

		public Color BackgroundColor { get; set; }
		public Color StrongSelectionColor { get; set; }
		public Color SelectionColor { get; set; }

		public bool UseStrongSelectionColor { get; set; }

		public IDataField<bool> HasBackgroundColorField { get; set; }

		public BuildOutputTreeCellView () 
		{
			BackgroundColor = Styles.CellBackgroundColor;
			StrongSelectionColor = Styles.CellStrongSelectionColor;
			SelectionColor = Styles.CellSelectionColor;
			UseStrongSelectionColor = true;
		}

		int fontSize = 11;

		const int descriptionPaddingHeight = 0;
		const int linesDisplayedCount = 1;

		//Size maxBuildOutputImageSize = new Size (48, 48);
		WidgetSpacing packageDescriptionPadding = new WidgetSpacing (5, 5, 5, 10);
		WidgetSpacing packageImagePadding = new WidgetSpacing (0, 0, 0, 5);
		WidgetSpacing checkBoxPadding = new WidgetSpacing (10, 0, 0, 10);

		FilteredBuildOutputNode buildOutputNode;

		Size fontRequiredSize;

		const int imageSide = 20;
		const int imageLeftPadding = 2;
		int imageX => imageSide + imageLeftPadding + 5;

		protected override void OnDraw(Context ctx, Xwt.Rectangle cellArea)
		{
			FillCellBackground (ctx);
			UpdateTextColor (ctx);

			var image = buildOutputNode.GetImage ()
			                           .WithSize (imageSide);
			ctx.DrawImage (
				Selected ? image.WithStyles ("sel") : image,
				cellArea.Left + imageLeftPadding,
				cellArea.Top - (imageSide - cellArea.Height)*.5,
				imageSide,
				imageSide);

			// NodeText
			var descriptionTextLayout = new TextLayout ();
			descriptionTextLayout.Width = cellArea.Width - imageX;
			descriptionTextLayout.Height = cellArea.Height;
			descriptionTextLayout.Text = buildOutputNode.Message;
			descriptionTextLayout.Trimming = TextTrimming.Word;

			if (buildOutputNode.NodeType == BuildOutputNodeType.Build) {
				descriptionTextLayout.Font = descriptionTextLayout.Font
					.WithSize (fontSize)
					.WithWeight (FontWeight.Bold);
			} else {
				descriptionTextLayout.Font = descriptionTextLayout.Font
					.WithSize (fontSize)
					.WithWeight (FontWeight.Light);
			}


			ctx.DrawTextLayout (
				descriptionTextLayout,
				cellArea.Left + imageX,
				cellArea.Top + ((cellArea.Height - fontRequiredSize.Height)*.5));
		}

		protected override Size OnGetRequiredSize ()
		{
			var layout = new TextLayout ();
			layout.Text = "W";
			layout.Font = layout.Font.WithSize (fontSize);
			fontRequiredSize = layout.GetSize ();
			return new Size (CellWidth, fontRequiredSize.Height * linesDisplayedCount + descriptionPaddingHeight + 
			                 (buildOutputNode.NodeType == BuildOutputNodeType.Build ? 12 : 3));
		}

		protected override void OnDataChanged()
		{
			base.OnDataChanged();
			var backEnd = (Xwt.GtkBackend.CellViewBackend) this.BackendHost.Backend;
			buildOutputNode = (FilteredBuildOutputNode) backEnd.TreeModel.GetValue (backEnd.CurrentIter, 0);
		}

		Color GetSelectedColor ()
		{
			if (UseStrongSelectionColor) {
				return StrongSelectionColor;
			}
			return SelectionColor;
		}

		void UpdateTextColor (Context ctx)
		{
			if (UseStrongSelectionColor && Selected) {
				ctx.SetColor (Styles.CellTextSelectionColor);
			} else {
				ctx.SetColor (Styles.CellTextColor);
			}
		}

		bool IsBackgroundColorFieldSet ()
		{
			return GetValue (HasBackgroundColorField, false);
		}

		void FillCellBackground (Context ctx)
		{
			if (Selected) {
				FillCellBackground (ctx, GetSelectedColor ());
			} else if (IsBackgroundColorFieldSet ()) {
				FillCellBackground (ctx, BackgroundColor);
			}
		}

		void FillCellBackground (Context ctx, Color color)
		{
			ctx.Rectangle (BackgroundBounds);
			ctx.SetColor (color);
			ctx.Fill ();
		}
	}
}
