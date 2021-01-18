using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComparison.Functions
{
    class calculate
    {
        public static void calculateData()
        {
            Cursor.Current = Cursors.WaitCursor;

            forms.Frm_Home.btnChooseDir.Enabled = false;
            forms.Frm_Home.lblProgress.Visible = true;
            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressFirst_Text;

            forms.Frm_Settings.btnCalc.Enabled = false;
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressFirst_Text;

            forms.Frm_Home.Refresh();
            forms.Frm_Settings.Refresh();

            interconnectorPy.runPyFile("database\\Database", Properties.Settings.Default.default_dir, Application.StartupPath, "True");
            Thread.Sleep(700);

            Directory.Delete(Application.StartupPath + "\\algorithms\\cpickleFiles\\Histograms", true);
            Directory.Delete(Application.StartupPath + "\\algorithms\\cpickleFiles\\Sift", true);
            Directory.Delete(Application.StartupPath + "\\algorithms\\cpickleFiles\\SSIM", true);
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressSecond_Text;
            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressSecond_Text;

            forms.Frm_Settings.Refresh();
            Thread.Sleep(700);

            Directory.CreateDirectory(Application.StartupPath + "\\algorithms\\cpickleFiles\\Histograms");
            Directory.CreateDirectory(Application.StartupPath + "\\algorithms\\cpickleFiles\\Sift");
            Directory.CreateDirectory(Application.StartupPath + "\\algorithms\\cpickleFiles\\SSIM");

            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (1/4)";
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (1/4)";
            forms.Frm_Settings.Refresh();
            forms.Frm_Home.Refresh();
            interconnectorPy.runPyFile("cpickleFiles\\cpickleHist", Properties.Settings.Default.default_dir, Application.StartupPath, "False");
            interconnectorPy.runPyFile("cpickleFiles\\cpickleHistInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");

            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (2/4)";
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (2/4)";
            forms.Frm_Settings.Refresh();
            forms.Frm_Home.Refresh();
            interconnectorPy.runPyFile("cpickleFiles\\cpickleSSIM", Properties.Settings.Default.default_dir, Application.StartupPath, "False");
            interconnectorPy.runPyFile("cpickleFiles\\cpickleSSIMInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");

            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (3/4)";
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (3/4)";
            forms.Frm_Settings.Refresh();
            forms.Frm_Home.Refresh();
            interconnectorPy.runPyFile("cpickleFiles\\cpickleSift", Properties.Settings.Default.default_dir, Application.StartupPath, "False");
            interconnectorPy.runPyFile("cpickleFiles\\cpickleSiftInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");

            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (4/4)";
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressSecond_Text + " (4/4)";
            forms.Frm_Settings.Refresh();
            forms.Frm_Home.Refresh();
            interconnectorPy.runPyFile("Face_Detection", Properties.Settings.Default.default_dir, Application.StartupPath, "False");

            forms.Frm_Home.btnChooseDir.Enabled = true;
            forms.Frm_Home.lblProgress.Visible = false;
            forms.Frm_Home.lblProgress.Text = setLanguage.lblProgressThird_Text;

            forms.Frm_Settings.btnCalc.Enabled = true;
            forms.Frm_Settings.lblProgress.Text = setLanguage.lblProgressThird_Text;

            Cursor.Current = Cursors.Default;
        }
    }
}
