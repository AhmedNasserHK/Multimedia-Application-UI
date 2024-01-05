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

namespace Multimedia_Application_UI.UserControls
{
    public partial class MainPage_011 : UserControl
    {
        public MainPage_011()
        {
            InitializeComponent();
            try
            {
                // Round PictureBox TVS
                Rectangle r = new Rectangle(0, 0, PIC_MAIN011_ANIM.Width, PIC_MAIN011_ANIM.Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                PIC_MAIN011_ANIM.Region = new Region(gp);
            }
            catch
            { 
            }
            try
            {
                MainInsider011_01.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_02.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_03.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_04.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_05.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_06.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_07.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider011_08.MouseHover += OnMouseHoverByAhmedNasserHK;
                PIC_MAIN011_ANIM.MouseHover += OnMouseHoverByAhmedNasserHK;
            }
            catch
            {
                MessageBox.Show("011", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnMouseHoverByAhmedNasserHK(object sender, EventArgs e)
        {
            try
            {
                mediaPlayer.Play();
            }
            catch
            {
                string message = "Not Found (SoundHover.wav) @Folder *ResourcesHK\\Sounds*";
                string title = "HK Projects ByAhmedNasserHK";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }
        System.Media.SoundPlayer mediaPlayer = new System.Media.SoundPlayer(@"ResourcesHK\\Sounds\\SoundHover_02.wav");

        private readonly PrivateFontCollection pfc1 = new PrivateFontCollection();
        private void MainPage_011_Load(object sender, EventArgs e)
        {
            //////////////////////////////// Change App Name ///////////////////////////////////////////////////
            try
            {
                txts_Label_011.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_11\\ROW_BTN_TITLE_11.dll");
            }
            catch
            {
                string message = "Not Found (ChangeAppName.txt) @Folder *ResourcesHK\\OtherResources*";
                string title = "HK Projects ByAhmedNasserHK";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            /////*//////   font Stream START FONT_06  /////*//////
            {
                Stream fontStream6 = this.GetType().Assembly.GetManifestResourceStream("Multimedia_Application_UI.MmtsdrLaTkelmeniBold.ttf");
                byte[] fontdata6 = new byte[fontStream6.Length];
                fontStream6.Read(fontdata6, 0, (int)fontStream6.Length);
                fontStream6.Close();

                unsafe
                {
                    fixed (byte* pfontdata6 = fontdata6)
                    {
                        pfc1.AddMemoryFont((System.IntPtr)pfontdata6, fontdata6.Length);
                    }
                }
                txts_Label_011.Font = new Font(pfc1.Families[0], 16, FontStyle.Regular);
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
                MainInsider011_01.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_02.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_03.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_04.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_05.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_06.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_07.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider011_08.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
            }
            /////*//////   font Stream END FONT_01  /////*//////
            try
            {
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_01.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_01.dll")))
                {
                    MainInsider011_01.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_01.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_02.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_02.dll")))
                {
                    MainInsider011_02.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_02.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_03.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_03.dll")))
                {
                    MainInsider011_03.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_03.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_04.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_04.dll")))
                {
                    MainInsider011_04.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_04.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_05.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_05.dll")))
                {
                    MainInsider011_05.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_05.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_06.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_06.dll")))
                {
                    MainInsider011_06.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_06.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_07.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_07.dll")))
                {
                    MainInsider011_07.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_07.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider011_08.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider011_01\\MainInsider011_08.dll")))
                {
                    MainInsider011_08.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider011_08.Visible = true;
                }
                //////// ****************** ////////
            }

            catch 
            {
                MessageBox.Show("011", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //////////////////////////////// PIC_MAIN011_ANIM ///////////////////////////////////////////////////
            {
                try
                {
                    string sFile1 = @"ResourcesHK\\IMG\\PIC_MAIN011_ANIM.gif";
                    Image source_bmp1 = Image.FromFile(sFile1);
                    PIC_MAIN011_ANIM.Invoke((MethodInvoker)delegate { PIC_MAIN011_ANIM.Image = source_bmp1; });
                }
                catch
                {
                    PIC_MAIN011_ANIM.Visible = false;
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void MainInsider011_01_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_01.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_01.lnk");

            }
        }

        private void MainInsider011_02_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_02.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_02.lnk");

            }
        }

        private void MainInsider011_03_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_03.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_03.lnk");

            }
        }

        private void MainInsider011_04_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_04.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_04.lnk");

            }
        }

        private void MainInsider011_05_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_05.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_05.lnk");

            }
        }

        private void MainInsider011_06_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_06.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_06.lnk");

            }
        }

        private void MainInsider011_07_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_07.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_07.lnk");

            }
        }

        private void MainInsider011_08_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_08.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider011_01\\_Btn_MainInsider011_08.lnk");

            }
        }

        private void MainPage_011_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }
        }
    }
}
