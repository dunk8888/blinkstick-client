
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class PatternDialog
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.PatternDialog
			this.Name = "BlinkStickClient.PatternDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child BlinkStickClient.PatternDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog_content";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_content.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w2.Position = 0;
			// Internal child BlinkStickClient.PatternDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog_actions";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog_actions.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-close";
			this.AddActionWidget (this.buttonCancel, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 660;
			this.DefaultHeight = 502;
			this.Show ();
		}
	}
}
