using ImageComparison.Functions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            pbApplied.Visible = true;
            forms.Frm_Settings.Refresh();
            frmHome.outputImagePath = new string[13];
            forms.Frm_Home.btnSaveResults.Enabled = false;

            if (rbSSIM.Checked==true)
            {
                Properties.Settings.Default.pref_algorithm = "SSIM";
            }
            if(rbHistogram.Checked == true)
            {
                Properties.Settings.Default.pref_algorithm = "Histogram";
            }
            if (rbSift.Checked == true)
            {
                Properties.Settings.Default.pref_algorithm = "Sift";
            }
            if (rbAll.Checked == true)
            {
                Properties.Settings.Default.pref_algorithm = "All";
            }

            if (rbDefault.Checked == true)
            {
                Properties.Settings.Default.face_detection = "AllType";
            }
            else if (rbFaceDetection.Checked == true)
            {
                Properties.Settings.Default.face_detection = "OnlyFaces";
            }
            else if (rbNoFaceDetection.Checked == true)
            {
                Properties.Settings.Default.face_detection = "NoFaces";
            }

            if (rb6Images.Checked == true)
            {
                Properties.Settings.Default.pref_image_output = 6;
            }
            if (rb9Images.Checked == true)
            {
                Properties.Settings.Default.pref_image_output = 9;
            }
            if (rb12Images.Checked == true)
            {
                Properties.Settings.Default.pref_image_output = 12;
            }

            if (rbWhite.Checked == true)
            {
                Properties.Settings.Default.theme = "White";
                themeChanger.setLightTheme();
            }
            if (rbBlack.Checked == true)
            {
                Properties.Settings.Default.theme = "Black";
                themeChanger.setDarkTheme();
            }


            setLanguage.ClearOutput();
            
            

            Properties.Settings.Default.Save();

            Thread.Sleep(300);
            pbApplied.Visible = false;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calculate.calculateData();
        }

        private void btnOpenImageDir_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.default_dir);
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(Properties.Settings.Default.default_input_image));
        }
    }
}
