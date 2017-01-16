/*
 * User: PascalHobza
 * Date: 23.12.2016
 * Time: 06:14
 */
using System;
using System.Windows.Forms;

namespace Schadensmeldung
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
