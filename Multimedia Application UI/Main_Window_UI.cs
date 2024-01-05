using Multimedia_Application_UI.UserControls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Multimedia_Application_UI
{
    public partial class Main_Window : Form
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F1)
            {
                SettingsAuthentication f2 = new SettingsAuthentication();
                f2.ShowDialog(); // Shows Form2
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F2)
            {
                HKSender f3 = new HKSender();
                f3.ShowDialog(); // Shows Form2
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        public void AppExit()
        {
            Application.Exit();
        }
        public void AppMini()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Panel_Container.Controls.Clear();
            Panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // Try install the font.
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static uint cFonts = 0;
        private static void AddFont(byte[] fontdata)
        {
            System.IntPtr dataPointer;

            //We are going to need a pointer to the font data, so we are generating it here
            dataPointer = Marshal.AllocCoTaskMem(fontdata.Length);


            //Copying the fontdata into the memory designated by the pointer
            Marshal.Copy(fontdata, 0, dataPointer, (int)fontdata.Length);

            // Register the font with the system.
            AddFontMemResourceEx(dataPointer, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            //Keep track of how many fonts we've added.
            cFonts += 1;

            //Finally, we can actually add the font to our collection
            pfc.AddMemoryFont(dataPointer, (int)fontdata.Length);
        }

        public Main_Window()
        {
            InitializeComponent();
            

            if (MainBtn_001.Focused)
            {
                MainBtn_001.FillColor = Color.Violet;
                MainBtn_001.FillColor2 = Color.YellowGreen;
            }
            //////////////////////////////// Change App Name ///////////////////////////////////////////////////
            try
            {
                txt_Label_01.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ChangeAppName.txt");
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
                txt_Label_01.Font = new Font(pfc1.Families[0], 16, FontStyle.Strikeout);
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
                MainBtn_001.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_002.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_003.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_004.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_005.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_006.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_007.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_008.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_009.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_010.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_011.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
                MainBtn_012.Font = new Font(pfc1.Families[0], 16, FontStyle.Bold);
            }
            /////*//////   font Stream END FONT_01  /////*//////
            ///
            //////////////////////////////// MainBtn_001 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_001.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_001.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_002 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_002.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_002.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///            //////////////////////////////// MainBtn_003 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_003.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_003.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///            //////////////////////////////// MainBtn_004 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_004.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_004.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///            //////////////////////////////// MainBtn_005 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_005.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_005.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_006 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_006.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_006.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///            //////////////////////////////// MainBtn_007 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_007.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_007.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///            //////////////////////////////// MainBtn_008 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_008.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_008.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_009 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_009.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_009.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_010 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_010.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_010.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_011 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_011.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_011.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////// MainBtn_012 ///////////////////////////////////////////////////
            {
                try
                {
                    const string i1Path = @"ResourcesHK\\IMG\\BTNS\\MainBtn_012.png";
                    var i = Image.FromFile(i1Path);
                    MainBtn_012.Image = i;
                }
                catch
                {

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_002.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_02\\ROW_BTN_TITLE_02.dll")))
            {
                MainBtn_002.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_002.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_003.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_03\\ROW_BTN_TITLE_03.dll")))
            {
                MainBtn_003.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_003.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_004.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_04\\ROW_BTN_TITLE_04.dll")))
            {
                MainBtn_004.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_004.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_005.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_05\\ROW_BTN_TITLE_05.dll")))
            {
                MainBtn_005.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_005.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_006.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_06\\ROW_BTN_TITLE_06.dll")))
            {
                MainBtn_006.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_006.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_007.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_07\\ROW_BTN_TITLE_07.dll")))
            {
                MainBtn_007.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_007.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_008.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_08\\ROW_BTN_TITLE_08.dll")))
            {
                MainBtn_008.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_008.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_009.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_09\\ROW_BTN_TITLE_09.dll")))
            {
                MainBtn_009.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_009.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_010.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_10\\ROW_BTN_TITLE_10.dll")))
            {
                MainBtn_010.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_010.Visible = true;
            }
            //////// ****************** ////////

            //////// ****************** ////////
            ////////     EMPTY START    ////////
            //////// ****************** ////////
            if (string.IsNullOrWhiteSpace(MainBtn_011.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_11\\ROW_BTN_TITLE_11.dll")))
            {
                MainBtn_011.Visible = false; // <<== No double-quotes around false
            }
            else
            {
                // Don't forget to re-enable the button
                MainBtn_011.Visible = true;
            }
            //////// ****************** ////////
            ///
            try
            {
                MainBtn_001.FillColor = Color.FromArgb(255, 213, 90);
                MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
                MainBtn_001.ForeColor = Color.FromArgb(22, 22, 22);
            }
            catch { }
            /// Dark Bar

            /// Add Font
            AddFont(Properties.Resources.MmtsdrLaTkelmeniBold);


            MainPage_001 PAGE01 = new MainPage_001();
            addUserControls(PAGE01);

            try
            {
                MainBtn_001.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_01\\ROW_BTN_TITLE_01.dll");
                MainBtn_002.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_02\\ROW_BTN_TITLE_02.dll");
                MainBtn_003.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_03\\ROW_BTN_TITLE_03.dll");
                MainBtn_004.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_04\\ROW_BTN_TITLE_04.dll");
                MainBtn_005.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_05\\ROW_BTN_TITLE_05.dll");
                MainBtn_006.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_06\\ROW_BTN_TITLE_06.dll");
                MainBtn_007.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_07\\ROW_BTN_TITLE_07.dll");
                MainBtn_008.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_08\\ROW_BTN_TITLE_08.dll");
                MainBtn_009.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_09\\ROW_BTN_TITLE_09.dll");
                MainBtn_010.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_10\\ROW_BTN_TITLE_10.dll");
                MainBtn_011.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_11\\ROW_BTN_TITLE_11.dll");
                MainBtn_012.Text = File.ReadAllText("ResourcesHK\\OtherResources\\ROW_BTN_TITLE_12\\ROW_BTN_TITLE_12.dll");
            }
            catch
            {
                MessageBox.Show("001", " MAS HK4TECH Controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MainBtn_001.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_002.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_003.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_004.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_005.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_006.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_007.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_008.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_009.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_010.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_011.MouseHover += OnMouseHoverByAhmedNasserHK;
                MainBtn_012.MouseHover += OnMouseHoverByAhmedNasserHK;
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
        System.Media.SoundPlayer mediaPlayer = new System.Media.SoundPlayer(@"ResourcesHK\\Sounds\\SoundHover.wav");

        private void MainBtn_001_Click(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_001.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_001.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_001 PAGE01 = new MainPage_001();
            addUserControls(PAGE01);
        }

        private void MainBtn_002_Click(object sender, EventArgs e)
        {
            MainBtn_002.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_002.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_002.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_002 PAGE02 = new MainPage_002();
            addUserControls(PAGE02);
        }

        private void MainBtn_003_Click(object sender, EventArgs e)
        {
            MainBtn_003.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_003.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_003.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_003 PAGE03 = new MainPage_003();
            addUserControls(PAGE03);
        }

        private void MainBtn_004_Click(object sender, EventArgs e)
        {
            MainBtn_004.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_004.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_004.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_004 PAGE04 = new MainPage_004();
            addUserControls(PAGE04);
        }

        private void MainBtn_005_Click(object sender, EventArgs e)
        {
            MainBtn_005.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_005.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_005.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_005 PAGE05 = new MainPage_005();
            addUserControls(PAGE05);
        }

        private void MainBtn_006_Click(object sender, EventArgs e)
        {
            MainBtn_006.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_006.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_006.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_006 PAGE06 = new MainPage_006();
            addUserControls(PAGE06);
        }

        private void MainBtn_007_Click(object sender, EventArgs e)
        {
            MainBtn_007.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_007.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_007.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_007 PAGE07 = new MainPage_007();
            addUserControls(PAGE07);
        }

        private void MainBtn_008_Click(object sender, EventArgs e)
        {
            MainBtn_008.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_008.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_008.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_008 PAGE08 = new MainPage_008();
            addUserControls(PAGE08);
        }

        private void MainBtn_009_Click(object sender, EventArgs e)
        {
            MainBtn_009.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_009.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_009.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_009 PAGE09 = new MainPage_009();
            addUserControls(PAGE09);
        }

        private void MainBtn_010_Click(object sender, EventArgs e)
        {
            MainBtn_010.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_010.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_010.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_010 PAGE10 = new MainPage_010();
            addUserControls(PAGE10);
        }

        private void MainBtn_011_Click(object sender, EventArgs e)
        {
            MainBtn_011.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_011.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_011.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_011 PAGE11 = new MainPage_011();
            addUserControls(PAGE11);
        }

        private void MainBtn_012_Click(object sender, EventArgs e)
        {
            MainBtn_012.FillColor = Color.FromArgb(255, 213, 90);
            MainBtn_012.FillColor2 = Color.FromArgb(109, 212, 126);
            MainBtn_012.ForeColor = Color.FromArgb(22, 22, 22);
            MainPage_012 PAGE12 = new MainPage_012();
            addUserControls(PAGE12);
        }

        private readonly PrivateFontCollection pfc1 = new PrivateFontCollection();
        private void MainBtn_001_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_002_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_003_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_004_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_005_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_006_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_007_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_008_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_009_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_010_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_011_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void MainBtn_012_Leave(object sender, EventArgs e)
        {
            MainBtn_001.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_001.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_001.ForeColor = Color.White;

            MainBtn_002.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_002.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_002.ForeColor = Color.White;

            MainBtn_003.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_003.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_003.ForeColor = Color.White;

            MainBtn_004.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_004.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_004.ForeColor = Color.White;

            MainBtn_005.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_005.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_005.ForeColor = Color.White;

            MainBtn_006.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_006.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_006.ForeColor = Color.White;

            MainBtn_007.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_007.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_007.ForeColor = Color.White;

            MainBtn_008.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_008.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_008.ForeColor = Color.White;

            MainBtn_009.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_009.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_009.ForeColor = Color.White;

            MainBtn_010.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_010.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_010.ForeColor = Color.White;

            MainBtn_011.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_011.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_011.ForeColor = Color.White;

            MainBtn_012.FillColor = Color.FromArgb(94, 148, 255);
            MainBtn_012.FillColor2 = Color.FromArgb(22, 22, 22);
            MainBtn_012.ForeColor = Color.White;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
            System.Windows.Forms.Application.ExitThread();
            System.Environment.Exit(0);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
           // SettingsAuthentication PAGE05 = new SettingsAuthentication();


            SettingsAuthentication f2 = new SettingsAuthentication();
            f2.ShowDialog(); // Shows Form2
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            HKSender f3 = new HKSender();
            f3.ShowDialog(); // Shows Form2
        }
    }
}
