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
    public partial class MainPage_003 : UserControl
    {
        public MainPage_003()
        {
            InitializeComponent();
            try
            {
                // Round PictureBox TVS
                Rectangle r = new Rectangle(0, 0, PIC_MAIN003_ANIM.Width, PIC_MAIN003_ANIM.Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                PIC_MAIN003_ANIM.Region = new Region(gp);
            }
            catch
            { 
            }
            try
            {
                MainInsider003_01.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_02.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_03.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_04.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_05.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_06.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_07.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider003_08.MouseHover += OnMouseHoverByAhmedNasserHK;
                PIC_MAIN003_ANIM.MouseHover += OnMouseHoverByAhmedNasserHK;
            }
            catch
            {
                MessageBox.Show("003", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MainPage_003_Load(object sender, EventArgs e)
        {
            //////////////////////////////// Change App Name ///////////////////////////////////////////////////
            try
            {
                txts_Label_03.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_03\\ROW_BTN_TITLE_03.dll");
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
                txts_Label_03.Font = new Font(pfc1.Families[0], 16, FontStyle.Regular);
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
                MainInsider003_01.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_02.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_03.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_04.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_05.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_06.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_07.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider003_08.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
            }
            /////*//////   font Stream END FONT_01  /////*//////
            try
            {
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_01.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_01.dll")))
                {
                    MainInsider003_01.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_01.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_02.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_02.dll")))
                {
                    MainInsider003_02.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_02.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_03.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_03.dll")))
                {
                    MainInsider003_03.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_03.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_04.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_04.dll")))
                {
                    MainInsider003_04.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_04.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_05.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_05.dll")))
                {
                    MainInsider003_05.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_05.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_06.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_06.dll")))
                {
                    MainInsider003_06.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_06.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_07.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_07.dll")))
                {
                    MainInsider003_07.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_07.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider003_08.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider003_01\\MainInsider003_08.dll")))
                {
                    MainInsider003_08.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider003_08.Visible = true;
                }
                //////// ****************** ////////
            }

            catch 
            {
                MessageBox.Show("003", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //////////////////////////////// PIC_MAIN003_ANIM ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\PIC_MAIN003_ANIM.gif";
                    var i = Image.FromFile(i1Path);
                    PIC_MAIN003_ANIM.Image = i;
                }
                catch
                {
                    PIC_MAIN003_ANIM.Visible = false;
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void MainInsider003_01_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_01.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_01.lnk");

            }
        }

        private void MainInsider003_02_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_02.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_02.lnk");

            }
        }

        private void MainInsider003_03_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_03.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_03.lnk");

            }
        }

        private void MainInsider003_04_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_04.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_04.lnk");

            }
        }

        private void MainInsider003_05_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_05.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_05.lnk");

            }
        }

        private void MainInsider003_06_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_06.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_06.lnk");

            }
        }

        private void MainInsider003_07_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_07.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_07.lnk");

            }
        }

        private void MainInsider003_08_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_08.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider003_01\\_Btn_MainInsider003_08.lnk");

            }
        }

        private void MainPage_003_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }
        }
    }
}
