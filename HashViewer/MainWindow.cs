using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	private string sumToHexString(byte[] sum)
        {  
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sum.Length; i++)
            {  
                sb.Append(sum[i].ToString("x2"));
            }
            return sb.ToString();
        }

	public void computeHashes (String filename)
	{
		using (FileStream targetFile = new FileStream(filename, FileMode.Open)) {
			String md5sum = sumToHexString (MD5CryptoServiceProvider.Create ().ComputeHash (targetFile));
			targetFile.Seek (0, SeekOrigin.Begin);
			String sha1sum = sumToHexString (SHA1CryptoServiceProvider.Create ().ComputeHash (targetFile));
			targetFile.Seek (0, SeekOrigin.Begin);
			String sha256sum = sumToHexString (SHA256Managed.Create ().ComputeHash (targetFile));
			this.md5Entry.Text = md5sum;
			this.sha1Entry.Text = sha1sum;
			this.sha256Entry.Text = sha256sum;
		}

	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnCopyAllButtonClicked (object sender, EventArgs e)
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("MD5: ");
		sb.Append(this.md5Entry.Text);
		sb.Append("\nSHA1: ");
		sb.Append(this.sha1Entry.Text);
		sb.Append("\nSHA256: ");
		sb.Append(this.sha256Entry.Text);
		Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false)).Text = sb.ToString();
	}	

	protected void OnCopyMD5ButtonClicked (object sender, EventArgs e)
	{
		Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false)).Text = this.md5Entry.Text;
	}	

	protected void OnCopySHA1ButtonClicked (object sender, EventArgs e)
	{
		Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false)).Text = this.sha1Entry.Text;
	}	

	protected void OnCopySHA256ButtonClicked (object sender, EventArgs e)
	{
		Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false)).Text = this.sha256Entry.Text;
	}

	protected void OnOpenActionActivated (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog chooser = new Gtk.FileChooserDialog ("Choose the file to hash",
		                                                      this,
		                                                      FileChooserAction.Open,
		                                                      "Cancel", ResponseType.Cancel,
		                                                      "Open", ResponseType.Accept);
		if (chooser.Run() == (int)ResponseType.Accept) {
			this.computeHashes(chooser.Filename);
		}

		chooser.Destroy();
	}	

	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		Application.Quit();
	}
}
