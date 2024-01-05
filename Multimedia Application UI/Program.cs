using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia_Application_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var HK001 = new FileInfo(@"Guna.UI2.dll");
            var HK002 = new FileInfo(@"VerticalLabel.dll");

            if (HK001.Exists && HK002.Exists)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main_Window());
            }
            else
            {
                MessageBox.Show("Not Found Guna.UI2.dll / VerticalLabel.dll", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
