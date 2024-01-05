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
    public partial class SettingsAuthentication : Form
    {
        public SettingsAuthentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBox_Protect_BTN.Text.Equals("hkprojects"))
            {
                var HK003 = new FileInfo(@"Configurations.dll");

                if (HK003.Exists)
                {
                    try
                    {
                        ProcessStartInfo ProcessInfo002;
                        Process process002;

                        ProcessInfo002 = new ProcessStartInfo(Application.StartupPath + "\\Configurations.dll");
                        ProcessInfo002.CreateNoWindow = true;
                        ProcessInfo002.UseShellExecute = false;
                        ProcessInfo002.WorkingDirectory = Application.StartupPath + "\\";
                        // *** Redirect the output ***
                        ProcessInfo002.RedirectStandardError = true;
                        ProcessInfo002.RedirectStandardOutput = true;

                        process002 = Process.Start(ProcessInfo002);
                        //  process002.WaitForExit();
                        Application.Exit();
                        // this.Close();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Not Found Configurations.dll", "MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Type Password To Unlock Protection", "MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tBox_Protect_BTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
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
        
    }
}
