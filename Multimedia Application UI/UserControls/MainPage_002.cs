﻿using System;
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
    public partial class MainPage_002 : UserControl
    {
        public MainPage_002()
        {
            InitializeComponent();
            try
            {
                // Round PictureBox TVS
                Rectangle r = new Rectangle(0, 0, PIC_MAIN002_ANIM.Width, PIC_MAIN002_ANIM.Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                PIC_MAIN002_ANIM.Region = new Region(gp);
            }
            catch
            { 
            }
            try
            {
                MainInsider002_01.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_02.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_03.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_04.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_05.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_06.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_07.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainInsider002_08.MouseHover += OnMouseHoverByAhmedNasserHK;
                PIC_MAIN002_ANIM.MouseHover += OnMouseHoverByAhmedNasserHK;
            }
            catch
            {
                MessageBox.Show("002", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MainPage_002_Load(object sender, EventArgs e)
        {
            //////////////////////////////// Change App Name ///////////////////////////////////////////////////
            try
            {
                txts_Label_02.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_02\\ROW_BTN_TITLE_02.dll");
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
                txts_Label_02.Font = new Font(pfc1.Families[0], 16, FontStyle.Regular);
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
                MainInsider002_01.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_02.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_03.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_04.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_05.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_06.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_07.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainInsider002_08.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
            }
            /////*//////   font Stream END FONT_01  /////*//////
            try
            {
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_01.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_01.dll")))
                {
                    MainInsider002_01.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_01.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_02.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_02.dll")))
                {
                    MainInsider002_02.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_02.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_03.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_03.dll")))
                {
                    MainInsider002_03.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_03.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_04.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_04.dll")))
                {
                    MainInsider002_04.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_04.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_05.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_05.dll")))
                {
                    MainInsider002_05.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_05.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_06.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_06.dll")))
                {
                    MainInsider002_06.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_06.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_07.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_07.dll")))
                {
                    MainInsider002_07.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_07.Visible = true;
                }
                //////// ****************** ////////
                //////// ****************** ////////
                ////////     EMPTY START    ////////
                //////// ****************** ////////
                if (string.IsNullOrWhiteSpace(MainInsider002_08.Text = File.ReadAllText("ResourcesHK\\OtherResources\\BTN_TITLE_MainInsider002_01\\MainInsider002_08.dll")))
                {
                    MainInsider002_08.Visible = false; // <<== No double-quotes around false
                }
                else
                {
                    // Don't forget to re-enable the button
                    MainInsider002_08.Visible = true;
                }
                //////// ****************** ////////
            }

            catch 
            {
                MessageBox.Show("002", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //////////////////////////////// PIC_MAIN002_ANIM ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\PIC_MAIN002_ANIM.gif";
                    var i = Image.FromFile(i1Path);
                    PIC_MAIN002_ANIM.Image = i;
                }
                catch
                {
                    PIC_MAIN002_ANIM.Visible = false;
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void MainInsider002_01_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_01.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_01.lnk");

            }
        }

        private void MainInsider002_02_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_02.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_02.lnk");

            }
        }

        private void MainInsider002_03_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_03.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_03.lnk");

            }
        }

        private void MainInsider002_04_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_04.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_04.lnk");

            }
        }

        private void MainInsider002_05_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_05.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_05.lnk");

            }
        }

        private void MainInsider002_06_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_06.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_06.lnk");

            }
        }

        private void MainInsider002_07_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_07.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_07.lnk");

            }
        }

        private void MainInsider002_08_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }

            try
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_VBS_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_08.vbs");

            }
            catch
            {
                System.Diagnostics.Process.Start("ResourcesHK\\_LNK_FILES_SOURCE\\_Btn_MainInsider002_01\\_Btn_MainInsider002_08.lnk");

            }
        }

        private void MainPage_002_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Window frm = (Main_Window)Application.OpenForms["Main_Window"];
                frm.MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
                //  frm.MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                frm.MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }
        }
    }
}
