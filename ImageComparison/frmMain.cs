using ImageComparison.Functions;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        protected bool maximize = false;

        #region Chiudere/Abbassare/Massimizzare Form
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Bordi Smussati
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Spostare Form
        bool TogMove;
        int MValX;
        int MValY;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - (MValX + 365), MousePosition.Y - MValY);
            }
        }
        #endregion


        private void frmMain_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20)); //Crea i bordi
            if (Properties.Settings.Default.language == "Ita")
            {
                setLanguage.setItaliano();
            }
            if (Properties.Settings.Default.language == "Eng")
            {
                setLanguage.setEnglish();
            }

            // Theme Setter
            if (Properties.Settings.Default.theme == "White")
            {
                themeChanger.setLightTheme();
            }
            if (Properties.Settings.Default.theme == "Black")
            {
                themeChanger.setDarkTheme();
            }

            loadHomeConfig();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadHomeConfig();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadSettingsConfig();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel(setLanguage.btnGuide_Text, forms.Frm_Guide);
            setLanguage.setGuide();
        }

        private void loadSettingsConfig()
        {
            if (Properties.Settings.Default.pref_algorithm == "SSIM")
            {
                forms.Frm_Settings.rbSSIM.Checked = true;
            }
            if (Properties.Settings.Default.pref_algorithm == "Histogram")
            {
                forms.Frm_Settings.rbHistogram.Checked = true;
                
            }
            if (Properties.Settings.Default.pref_algorithm == "Sift")
            {
                forms.Frm_Settings.rbSift.Checked = true;
            }
            if (Properties.Settings.Default.pref_algorithm == "All")
            {
                forms.Frm_Settings.rbAll.Checked = true;
            }

            if (Properties.Settings.Default.face_detection == "AllType")
            {
                forms.Frm_Settings.rbDefault.Checked = true;
            }
            else if (Properties.Settings.Default.face_detection == "OnlyFaces")
            {
                forms.Frm_Settings.rbFaceDetection.Checked = true;
            }
            else if (Properties.Settings.Default.face_detection == "NoFaces")
            {
                forms.Frm_Settings.rbNoFaceDetection.Checked = true;
            }

            if (Properties.Settings.Default.theme == "White")
            {
                forms.Frm_Settings.rbWhite.Checked = true;
            }
            if (Properties.Settings.Default.theme == "Black")
            {
                forms.Frm_Settings.rbBlack.Checked = true;
            }

            if (Properties.Settings.Default.pref_image_output == 6)
            {
                forms.Frm_Settings.rb6Images.Checked = true;
            }
            if (Properties.Settings.Default.pref_image_output == 9)
            {
                forms.Frm_Settings.rb9Images.Checked = true;
            }
            if (Properties.Settings.Default.pref_image_output == 12)
            {
                forms.Frm_Settings.rb12Images.Checked = true;
            }

            changeTab.changeControlPanel(setLanguage.btnSettings_Text, forms.Frm_Settings);

        }

        private void loadHomeConfig()
        {
            if (Properties.Settings.Default.pref_image_output == 6)
            {
                changeTab.changeImageOutputPanel(forms.Frm_Six);
            }
            else if (Properties.Settings.Default.pref_image_output == 9)
            {
                changeTab.changeImageOutputPanel(forms.Frm_Nine);
            }
            else if (Properties.Settings.Default.pref_image_output == 12)
            {
                changeTab.changeImageOutputPanel(forms.Frm_Twelve);
            }

            changeTab.changeControlPanel(setLanguage.btnHome_Text, forms.Frm_Home);
        }

        private void pcCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Programma ideato e creato da:\n - Giada Figliolini (202121)\n - Marco Cestari (205306)\n - Alissya Valer (200593)",
                                   "Crediti Sviluppatori", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information,
                                   MessageBoxDefaultButton.Button1, 0);
        }

        private void pbEng_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.language != "Eng")
            {
                Properties.Settings.Default.language = "Eng";
                setLanguage.setEnglish();
                forms.Frm_Main.lblNamePanel.Text = setLanguage.btnSettings_Text;
                setLanguage.setGuide();
                Properties.Settings.Default.Save();
            }

        }

        private void pbIta_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.language != "Ita")
            {
                Properties.Settings.Default.language = "Ita";
                setLanguage.setItaliano();
                forms.Frm_Main.lblNamePanel.Text = setLanguage.btnSettings_Text;
                setLanguage.setGuide();
                Properties.Settings.Default.Save();
            }
        }
    }
}
