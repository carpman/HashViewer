
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action openAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar2;
	private global::Gtk.Table table1;
	private global::Gtk.Button copyMD5Button;
	private global::Gtk.Button copySHA1Button;
	private global::Gtk.Button copySHA256Button;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button copyAllButton;
	private global::Gtk.Label label3;
	private global::Gtk.Label label4;
	private global::Gtk.Label label5;
	private global::Gtk.Entry md5Entry;
	private global::Gtk.Entry sha1Entry;
	private global::Gtk.Entry sha256Entry;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open..."), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open...");
		w1.Add (this.openAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.quitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Hash Viewer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.DefaultWidth = 500;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.WidthRequest = 575;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='quitAction' action='quitAction'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox1.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		this.table1.BorderWidth = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.copyMD5Button = new global::Gtk.Button ();
		this.copyMD5Button.CanFocus = true;
		this.copyMD5Button.Name = "copyMD5Button";
		this.copyMD5Button.UseUnderline = true;
		this.copyMD5Button.Label = global::Mono.Unix.Catalog.GetString ("Copy");
		this.table1.Add (this.copyMD5Button);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.copyMD5Button]));
		w3.LeftAttach = ((uint)(2));
		w3.RightAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.copySHA1Button = new global::Gtk.Button ();
		this.copySHA1Button.CanFocus = true;
		this.copySHA1Button.Name = "copySHA1Button";
		this.copySHA1Button.UseUnderline = true;
		this.copySHA1Button.Label = global::Mono.Unix.Catalog.GetString ("Copy");
		this.table1.Add (this.copySHA1Button);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.copySHA1Button]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.LeftAttach = ((uint)(2));
		w4.RightAttach = ((uint)(3));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.copySHA256Button = new global::Gtk.Button ();
		this.copySHA256Button.CanFocus = true;
		this.copySHA256Button.Name = "copySHA256Button";
		this.copySHA256Button.UseUnderline = true;
		this.copySHA256Button.Label = global::Mono.Unix.Catalog.GetString ("Copy");
		this.table1.Add (this.copySHA256Button);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.copySHA256Button]));
		w5.TopAttach = ((uint)(2));
		w5.BottomAttach = ((uint)(3));
		w5.LeftAttach = ((uint)(2));
		w5.RightAttach = ((uint)(3));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.copyAllButton = new global::Gtk.Button ();
		this.copyAllButton.CanFocus = true;
		this.copyAllButton.Name = "copyAllButton";
		this.copyAllButton.UseUnderline = true;
		this.copyAllButton.Label = global::Mono.Unix.Catalog.GetString ("Copy All");
		this.hbox1.Add (this.copyAllButton);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.copyAllButton]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		this.table1.Add (this.hbox1);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
		w7.TopAttach = ((uint)(3));
		w7.BottomAttach = ((uint)(4));
		w7.LeftAttach = ((uint)(2));
		w7.RightAttach = ((uint)(3));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("MD5");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("SHA1");
		this.table1.Add (this.label4);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("SHA 256");
		this.table1.Add (this.label5);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
		w10.TopAttach = ((uint)(2));
		w10.BottomAttach = ((uint)(3));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.md5Entry = new global::Gtk.Entry ();
		this.md5Entry.CanFocus = true;
		this.md5Entry.Name = "md5Entry";
		this.md5Entry.IsEditable = false;
		this.md5Entry.InvisibleChar = '•';
		this.table1.Add (this.md5Entry);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.md5Entry]));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.sha1Entry = new global::Gtk.Entry ();
		this.sha1Entry.CanFocus = true;
		this.sha1Entry.Name = "sha1Entry";
		this.sha1Entry.IsEditable = false;
		this.sha1Entry.InvisibleChar = '•';
		this.table1.Add (this.sha1Entry);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.sha1Entry]));
		w12.TopAttach = ((uint)(1));
		w12.BottomAttach = ((uint)(2));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.sha256Entry = new global::Gtk.Entry ();
		this.sha256Entry.CanFocus = true;
		this.sha256Entry.Name = "sha256Entry";
		this.sha256Entry.IsEditable = false;
		this.sha256Entry.InvisibleChar = '•';
		this.table1.Add (this.sha256Entry);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.sha256Entry]));
		w13.TopAttach = ((uint)(2));
		w13.BottomAttach = ((uint)(3));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.copyAllButton.Clicked += new global::System.EventHandler (this.OnCopyAllButtonClicked);
		this.copySHA256Button.Clicked += new global::System.EventHandler (this.OnCopySHA256ButtonClicked);
		this.copySHA1Button.Clicked += new global::System.EventHandler (this.OnCopySHA1ButtonClicked);
		this.copyMD5Button.Clicked += new global::System.EventHandler (this.OnCopyMD5ButtonClicked);
	}
}
