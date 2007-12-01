// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class NewProjectDialog {
        
        private Gtk.Notebook notebook;
        
        private Gtk.VBox vbox1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label lbl_hdr_template;
        
        private Gtk.HBox hbox1;
        
        private Gtk.VBox vbox4;
        
        private Gtk.HBox hbox_template;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView lst_template_types;
        
        private Gtk.Frame frame2;
        
        private Gtk.Label lbl_template_descr;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label lbl_hdr_location;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label spacer2;
        
        private Gtk.Table table1;
        
        private Gtk.CheckButton chk_combine_directory;
        
        private MonoDevelop.Components.FolderEntry entry_location;
        
        private Gtk.HSeparator hseparator;
        
        private Gtk.HSeparator hseparator3;
        
        private Gtk.Label lbl_location;
        
        private Gtk.Label lbl_name;
        
        private Gtk.Label lbl_subdirectory;
        
        private Gtk.Label lbl_will_save_in;
        
        private Gtk.Entry txt_name;
        
        private Gtk.Entry txt_subdirectory;
        
        private Gtk.Label label1;
        
        private Gtk.VBox vbox5;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector featureList;
        
        private Gtk.Label label2;
        
        private Gtk.Button btn_close;
        
        private Gtk.Button btn_new;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.NewProjectDialog
            this.WidthRequest = 630;
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.NewProjectDialog";
            this.Title = "New Solution";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(1));
            this.BorderWidth = ((uint)(6));
            this.DestroyWithParent = true;
            this.HasSeparator = false;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.NewProjectDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox1";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox1.Gtk.Box+BoxChild
            this.notebook = new Gtk.Notebook();
            this.notebook.CanFocus = true;
            this.notebook.Name = "notebook";
            this.notebook.CurrentPage = 1;
            this.notebook.ShowBorder = false;
            this.notebook.BorderWidth = ((uint)(6));
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 7;
            // Container child vbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.lbl_hdr_template = new Gtk.Label();
            this.lbl_hdr_template.Name = "lbl_hdr_template";
            this.lbl_hdr_template.Xalign = 0F;
            this.lbl_hdr_template.Yalign = 0F;
            this.lbl_hdr_template.LabelProp = Mono.Unix.Catalog.GetString("<b>Template</b>");
            this.lbl_hdr_template.UseMarkup = true;
            this.vbox2.Add(this.lbl_hdr_template);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.lbl_hdr_template]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox_template = new Gtk.HBox();
            this.hbox_template.Name = "hbox_template";
            this.hbox_template.Spacing = 6;
            // Container child hbox_template.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.lst_template_types = new Gtk.TreeView();
            this.lst_template_types.Name = "lst_template_types";
            this.lst_template_types.HeadersVisible = false;
            this.lst_template_types.HeadersClickable = true;
            this.scrolledwindow1.Add(this.lst_template_types);
            this.hbox_template.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox_template[this.scrolledwindow1]));
            w4.Position = 0;
            w4.Expand = false;
            this.vbox4.Add(this.hbox_template);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox_template]));
            w5.Position = 0;
            // Container child vbox4.Gtk.Box+BoxChild
            this.frame2 = new Gtk.Frame();
            this.frame2.Name = "frame2";
            this.frame2.LabelXalign = 0F;
            this.frame2.LabelYalign = 0F;
            // Container child frame2.Gtk.Container+ContainerChild
            this.lbl_template_descr = new Gtk.Label();
            this.lbl_template_descr.Name = "lbl_template_descr";
            this.lbl_template_descr.Xalign = 0F;
            this.lbl_template_descr.Yalign = 0F;
            this.lbl_template_descr.LabelProp = Mono.Unix.Catalog.GetString("Creates a new C# Project");
            this.frame2.Add(this.lbl_template_descr);
            this.vbox4.Add(this.frame2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox4[this.frame2]));
            w7.Position = 1;
            w7.Expand = false;
            this.hbox1.Add(this.vbox4);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox4]));
            w8.Position = 0;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w9.Position = 1;
            this.vbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
            w10.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.lbl_hdr_location = new Gtk.Label();
            this.lbl_hdr_location.Name = "lbl_hdr_location";
            this.lbl_hdr_location.Xalign = 0F;
            this.lbl_hdr_location.Yalign = 0F;
            this.lbl_hdr_location.LabelProp = Mono.Unix.Catalog.GetString("<b>Location</b>");
            this.lbl_hdr_location.UseMarkup = true;
            this.vbox3.Add(this.lbl_hdr_location);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox3[this.lbl_hdr_location]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            // Container child hbox3.Gtk.Box+BoxChild
            this.spacer2 = new Gtk.Label();
            this.spacer2.Name = "spacer2";
            this.spacer2.Xalign = 0F;
            this.spacer2.Yalign = 0F;
            this.spacer2.LabelProp = "    ";
            this.hbox3.Add(this.spacer2);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox3[this.spacer2]));
            w12.Position = 0;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(7)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.chk_combine_directory = new Gtk.CheckButton();
            this.chk_combine_directory.Name = "chk_combine_directory";
            this.chk_combine_directory.Label = Mono.Unix.Catalog.GetString("_Create separate Solution subdirectory");
            this.chk_combine_directory.Active = true;
            this.chk_combine_directory.DrawIndicator = true;
            this.chk_combine_directory.UseUnderline = true;
            this.table1.Add(this.chk_combine_directory);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.chk_combine_directory]));
            w13.TopAttach = ((uint)(3));
            w13.BottomAttach = ((uint)(4));
            w13.RightAttach = ((uint)(2));
            w13.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.entry_location = new MonoDevelop.Components.FolderEntry();
            this.entry_location.Name = "entry_location";
            this.entry_location.BrowserTitle = "Solution Location";
            this.table1.Add(this.entry_location);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table1[this.entry_location]));
            w14.TopAttach = ((uint)(1));
            w14.BottomAttach = ((uint)(2));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.XOptions = ((Gtk.AttachOptions)(4));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator = new Gtk.HSeparator();
            this.hseparator.Name = "hseparator";
            this.table1.Add(this.hseparator);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table1[this.hseparator]));
            w15.TopAttach = ((uint)(2));
            w15.BottomAttach = ((uint)(3));
            w15.RightAttach = ((uint)(2));
            w15.XOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.hseparator3 = new Gtk.HSeparator();
            this.hseparator3.Name = "hseparator3";
            this.table1.Add(this.hseparator3);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table1[this.hseparator3]));
            w16.TopAttach = ((uint)(5));
            w16.BottomAttach = ((uint)(6));
            w16.RightAttach = ((uint)(2));
            w16.XOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.lbl_location = new Gtk.Label();
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Xalign = 0F;
            this.lbl_location.Yalign = 0F;
            this.lbl_location.LabelProp = Mono.Unix.Catalog.GetString("_Location:");
            this.lbl_location.UseUnderline = true;
            this.table1.Add(this.lbl_location);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table1[this.lbl_location]));
            w17.TopAttach = ((uint)(1));
            w17.BottomAttach = ((uint)(2));
            w17.XOptions = ((Gtk.AttachOptions)(4));
            w17.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.lbl_name = new Gtk.Label();
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Xalign = 0F;
            this.lbl_name.Yalign = 0F;
            this.lbl_name.LabelProp = Mono.Unix.Catalog.GetString("N_ame:");
            this.lbl_name.UseUnderline = true;
            this.table1.Add(this.lbl_name);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table1[this.lbl_name]));
            w18.XOptions = ((Gtk.AttachOptions)(4));
            w18.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.lbl_subdirectory = new Gtk.Label();
            this.lbl_subdirectory.Name = "lbl_subdirectory";
            this.lbl_subdirectory.Xalign = 0F;
            this.lbl_subdirectory.Yalign = 0F;
            this.lbl_subdirectory.LabelProp = Mono.Unix.Catalog.GetString("_Solution name:");
            this.lbl_subdirectory.UseUnderline = true;
            this.table1.Add(this.lbl_subdirectory);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table1[this.lbl_subdirectory]));
            w19.TopAttach = ((uint)(4));
            w19.BottomAttach = ((uint)(5));
            w19.XOptions = ((Gtk.AttachOptions)(4));
            w19.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.lbl_will_save_in = new Gtk.Label();
            this.lbl_will_save_in.WidthRequest = 580;
            this.lbl_will_save_in.Name = "lbl_will_save_in";
            this.lbl_will_save_in.Xalign = 0F;
            this.lbl_will_save_in.Yalign = 0F;
            this.lbl_will_save_in.LabelProp = "Project will be saved in: /dev/null";
            this.lbl_will_save_in.Wrap = true;
            this.table1.Add(this.lbl_will_save_in);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table1[this.lbl_will_save_in]));
            w20.TopAttach = ((uint)(6));
            w20.BottomAttach = ((uint)(7));
            w20.RightAttach = ((uint)(2));
            w20.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.txt_name = new Gtk.Entry();
            this.txt_name.Name = "txt_name";
            this.txt_name.IsEditable = true;
            this.txt_name.ActivatesDefault = true;
            this.txt_name.InvisibleChar = '●';
            this.table1.Add(this.txt_name);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table1[this.txt_name]));
            w21.LeftAttach = ((uint)(1));
            w21.RightAttach = ((uint)(2));
            w21.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.txt_subdirectory = new Gtk.Entry();
            this.txt_subdirectory.Name = "txt_subdirectory";
            this.txt_subdirectory.IsEditable = true;
            this.txt_subdirectory.ActivatesDefault = true;
            this.txt_subdirectory.InvisibleChar = '●';
            this.table1.Add(this.txt_subdirectory);
            Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.table1[this.txt_subdirectory]));
            w22.TopAttach = ((uint)(4));
            w22.BottomAttach = ((uint)(5));
            w22.LeftAttach = ((uint)(1));
            w22.RightAttach = ((uint)(2));
            w22.YOptions = ((Gtk.AttachOptions)(0));
            this.hbox3.Add(this.table1);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox3[this.table1]));
            w23.Position = 1;
            this.vbox3.Add(this.hbox3);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
            w24.Position = 1;
            this.vbox1.Add(this.vbox3);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox1[this.vbox3]));
            w25.Position = 1;
            w25.Expand = false;
            this.notebook.Add(this.vbox1);
            Gtk.Notebook.NotebookChild w26 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.vbox1]));
            w26.TabExpand = false;
            // Notebook tab
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = "page1";
            this.notebook.SetTabLabel(this.vbox1, this.label1);
            this.label1.ShowAll();
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("<b>Project Features</b>");
            this.label3.UseMarkup = true;
            this.vbox5.Add(this.label3);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox5[this.label3]));
            w27.Position = 0;
            w27.Expand = false;
            w27.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.WidthRequest = 632;
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("<small>This list shows a set of features you can enable in the new project. After creating the project those features can be enabled or disabled in the Project Options dialog, or by adding new projects to the solution.</small>");
            this.label4.UseMarkup = true;
            this.label4.Wrap = true;
            this.vbox5.Add(this.label4);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vbox5[this.label4]));
            w28.Position = 1;
            w28.Expand = false;
            w28.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.featureList = new MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector();
            this.featureList.Events = ((Gdk.EventMask)(256));
            this.featureList.Name = "featureList";
            this.vbox5.Add(this.featureList);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vbox5[this.featureList]));
            w29.Position = 2;
            this.notebook.Add(this.vbox5);
            Gtk.Notebook.NotebookChild w30 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.vbox5]));
            w30.Position = 1;
            w30.TabExpand = false;
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = "page2";
            this.notebook.SetTabLabel(this.vbox5, this.label2);
            this.label2.ShowAll();
            w1.Add(this.notebook);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(w1[this.notebook]));
            w31.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.NewProjectDialog.ActionArea
            Gtk.HButtonBox w32 = this.ActionArea;
            w32.Name = "dialog-action_area1";
            w32.Spacing = 10;
            w32.BorderWidth = ((uint)(5));
            w32.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area1.Gtk.ButtonBox+ButtonBoxChild
            this.btn_close = new Gtk.Button();
            this.btn_close.CanDefault = true;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseStock = true;
            this.btn_close.UseUnderline = true;
            this.btn_close.Label = "gtk-cancel";
            this.AddActionWidget(this.btn_close, -6);
            // Container child dialog-action_area1.Gtk.ButtonBox+ButtonBoxChild
            this.btn_new = new Gtk.Button();
            this.btn_new.CanDefault = true;
            this.btn_new.Name = "btn_new";
            this.btn_new.UseStock = true;
            this.btn_new.UseUnderline = true;
            this.btn_new.Label = "gtk-go-forward";
            w32.Add(this.btn_new);
            Gtk.ButtonBox.ButtonBoxChild w34 = ((Gtk.ButtonBox.ButtonBoxChild)(w32[this.btn_new]));
            w34.Position = 1;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 708;
            this.DefaultHeight = 501;
            this.btn_new.HasDefault = true;
            this.Show();
            this.txt_subdirectory.Changed += new System.EventHandler(this.PathChanged);
            this.txt_name.Changed += new System.EventHandler(this.NameChanged);
            this.chk_combine_directory.Clicked += new System.EventHandler(this.SolutionCheckChanged);
            this.btn_close.Clicked += new System.EventHandler(this.cancelClicked);
            this.btn_new.Clicked += new System.EventHandler(this.OpenEvent);
        }
    }
}
