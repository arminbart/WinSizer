using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSizer
{
	class Program
	{
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int X);

		[DllImport("user32.dll")]
		public static extern bool SetFocus(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


		static void Main(string[] args)
		{
			foreach (string strArg in args)
			{
				Console.WriteLine(strArg);
			}

			Console.WriteLine("Screen-Resolution: " + Screen.PrimaryScreen.Bounds.Width + "x" + Screen.PrimaryScreen.Bounds.Height);
			Console.WriteLine("Working-Area:      " + Screen.PrimaryScreen.WorkingArea.Width + "x" + Screen.PrimaryScreen.WorkingArea.Height);

			Console.ReadKey();
		}
	}
}
