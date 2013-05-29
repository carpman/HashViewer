using System;
using Gtk;

namespace HashViewer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			if (args.Length > 0) {
				win.computeHashes (args [0]);
			}
			Application.Run ();
		}
	}
}
