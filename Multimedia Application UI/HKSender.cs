using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia_Application_UI
{
    public partial class HKSender : Form
    {
        public HKSender()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo ProcessInfo002;
                Process process002;

                ProcessInfo002 = new ProcessStartInfo(Application.StartupPath + "\\ResourcesHK\\OtherResources\\HKSender.exe");
                ProcessInfo002.CreateNoWindow = true;
                ProcessInfo002.UseShellExecute = false;
                ProcessInfo002.WorkingDirectory = Application.StartupPath + "\\";
                // *** Redirect the output ***
                ProcessInfo002.RedirectStandardError = true;
                ProcessInfo002.RedirectStandardOutput = true;

                process002 = Process.Start(ProcessInfo002);
                //  process002.WaitForExit();
                //Application.Exit();
                 this.Close();
            }
            catch
            {
                MessageBox.Show("Pur Your App Here");
            }
        }
    }
}
