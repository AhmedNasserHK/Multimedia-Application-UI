using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using System.Drawing.Configuration;
using System.Drawing.Text;
using System.Diagnostics;
using System.Security.Principal;
using System.Reflection;

namespace Multimedia_Application_UI.UserControls
{
    public partial class MainPage_012 : UserControl
    {
        public MainPage_012()
        {
            InitializeComponent();
           
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = "Current Version : " + String.Format("{0}", appVersion);
            lblVersion.ForeColor = System.Drawing.Color.Crimson;
            lblVersion.Font = new Font(DefaultFont, FontStyle.Bold); 
        }

        private readonly PrivateFontCollection pfc1 = new PrivateFontCollection();
        private void MainPage_012_Load(object sender, EventArgs e)
        {
            //////////////////////////////// GIF Company Logo ///////////////////////////////////////////////////
            {
                try
                {
                    string sFile1 = @"ResourcesHK\\IMG\\logogrand.png";
                    Image source_bmp1 = Image.FromFile(sFile1);
                    pictureBox2.Invoke((MethodInvoker)delegate { pictureBox2.Image = source_bmp1; });
                }
                catch
                {
                    pictureBox2.Visible = false;
                 //   string message = "Not Found (logogrand.png) @Folder *ResourcesHK\\IMG*";
                 //   string title = "HK Projects ByAhmedNasserHK";
                 //   MessageBoxButtons buttons = MessageBoxButtons.OK;
                 //   DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            /////*//////   font Stream START FONT_01  /////*//////
            {
                Stream fontStream1 = this.GetType().Assembly.GetManifestResourceStream("Multimedia_Application_UI.MmtsdrLaTkelmeniBold.ttf");
                byte[] fontdata1 = new byte[fontStream1.Length];
                fontStream1.Read(fontdata1, 0, (int)fontStream1.Length);
                fontStream1.Close();

                unsafe
                {
                    fixed (byte* pfontdata1 = fontdata1)
                    {
                        pfc1.AddMemoryFont((System.IntPtr)pfontdata1, fontdata1.Length);
                    }
                }

                ///////// MAIN ButtonS /////////
                label1.Font = new Font(pfc1.Families[0], 12, FontStyle.Bold);
                LblHK.Font = new Font(pfc1.Families[0], 12, FontStyle.Bold);
                label3.Font = new Font(pfc1.Families[0], 12, FontStyle.Bold);

            }
            /////*//////   font Stream END FONT_01  /////*//////
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome", @"https://hk4tech.com");
                Process.Start("msedge", @"https://hk4tech.com");
            }
            catch
            {

            }
        }

        private void MainPage_012_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_012.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_012.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }
        }
    }
}
