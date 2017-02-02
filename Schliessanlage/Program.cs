using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Schliessanlage
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Schliessanlage.instance.init();     
        }
    }
}
