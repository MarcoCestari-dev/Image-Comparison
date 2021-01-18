using ImageComparison.Functions;
using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public static string[] outputImagePath = new string[13];

        private void btnChooseInputImage_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Cursor.Current = Cursors.WaitCursor;
                    filePath = openFileDialog.FileName;
                    Properties.Settings.Default.default_input_image = filePath;
                    Properties.Settings.Default.Save();

                    pbInput.Image = Image.FromFile(Properties.Settings.Default.default_input_image);
                    lblInputName.Text = String.Format(setLanguage.lblInputName_Text, Path.GetFileName(Properties.Settings.Default.default_input_image));

                    interconnectorPy.runPyFile("cpickleFiles\\cpickleHistInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");
                    interconnectorPy.runPyFile("cpickleFiles\\cpickleSSIMInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");
                    interconnectorPy.runPyFile("cpickleFiles\\cpickleSiftInput", Properties.Settings.Default.default_input_image, Application.StartupPath, "False");
                    Cursor.Current = Cursors.Default;

                }
            }
        }

        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            using (var openDirDialog = new FolderBrowserDialog())
            { 
                DialogResult result = openDirDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openDirDialog.SelectedPath))
                {
                    DialogResult dialogResult = MessageBox.Show(setLanguage.messageRecalculate, "Attention:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DirectoryInfo dirImages = new DirectoryInfo(openDirDialog.SelectedPath);
                        FileInfo[] Images = dirImages.GetFiles("*.jpg");

                        Properties.Settings.Default.default_dir = openDirDialog.SelectedPath;
                        Properties.Settings.Default.Save();

                        String dir = Properties.Settings.Default.default_dir;
                        dir = dir.Substring(dir.LastIndexOf("\\"));
                        lblTotDir.Text = String.Format(setLanguage.lblTotDir_Text, dir, Images.Length);

                        Properties.Settings.Default.last_number_of_images = Images.Length;
                        Properties.Settings.Default.Save();
                        calculate.calculateData();

                    }                    
                }
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.default_dir != "" && Properties.Settings.Default.default_input_image != "")
            {
                btnCompare.Enabled = false;
                btnCompare.Text = setLanguage.btnCompareProgress_Text;
                Cursor.Current = Cursors.WaitCursor;
                forms.Frm_Home.Refresh();

                string result = "";

                DirectoryInfo dirImages = new DirectoryInfo(Properties.Settings.Default.default_dir);
                FileInfo[] Images = dirImages.GetFiles("*.jpg");

                if (Images.Length != Properties.Settings.Default.last_number_of_images)
                {
                    DialogResult dialogResult = MessageBox.Show(setLanguage.messageRecalculateDifferent, "Attention:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String dir = Properties.Settings.Default.default_dir;
                        dir = dir.Substring(dir.LastIndexOf("\\"));
                        lblTotDir.Text = String.Format(setLanguage.lblTotDir_Text, dir, Images.Length);
                        forms.Frm_Home.Refresh();

                        Properties.Settings.Default.last_number_of_images = Images.Length;
                        Properties.Settings.Default.Save();

                        calculate.calculateData();

                        result = interconnectorPy.getResultsComparison();
                    }
                }
                else
                {
                    result = interconnectorPy.getResultsComparison();
                }


                if (result == "OK\r\n")
                {
                    string fullPath = Application.StartupPath + "\\algorithms\\database\\Database.db";
                    SqliteConnection conread = new SqliteConnection("Data Source=" + fullPath);
                    conread.Open();

                    var command = conread.CreateCommand();

                    PictureBox[] pbOutputs = new PictureBox[Properties.Settings.Default.pref_image_output];
                    Label[] lblOutputs = new Label[Properties.Settings.Default.pref_image_output];

                    if (Properties.Settings.Default.pref_image_output == 6)
                    {
                        pbOutputs[0] = forms.Frm_Six.pbOutput1;
                        pbOutputs[1] = forms.Frm_Six.pbOutput2;
                        pbOutputs[2] = forms.Frm_Six.pbOutput3;
                        pbOutputs[3] = forms.Frm_Six.pbOutput4;
                        pbOutputs[4] = forms.Frm_Six.pbOutput5;
                        pbOutputs[5] = forms.Frm_Six.pbOutput6;

                        lblOutputs[0] = forms.Frm_Six.lblOutput1;
                        lblOutputs[1] = forms.Frm_Six.lblOutput2;
                        lblOutputs[2] = forms.Frm_Six.lblOutput3;
                        lblOutputs[3] = forms.Frm_Six.lblOutput4;
                        lblOutputs[4] = forms.Frm_Six.lblOutput5;
                        lblOutputs[5] = forms.Frm_Six.lblOutput6;

                    }
                    else if (Properties.Settings.Default.pref_image_output == 9)
                    {
                        pbOutputs[0] = forms.Frm_Nine.pbOutput1;
                        pbOutputs[1] = forms.Frm_Nine.pbOutput2;
                        pbOutputs[2] = forms.Frm_Nine.pbOutput3;
                        pbOutputs[3] = forms.Frm_Nine.pbOutput4;
                        pbOutputs[4] = forms.Frm_Nine.pbOutput5;
                        pbOutputs[5] = forms.Frm_Nine.pbOutput6;
                        pbOutputs[6] = forms.Frm_Nine.pbOutput7;
                        pbOutputs[7] = forms.Frm_Nine.pbOutput8;
                        pbOutputs[8] = forms.Frm_Nine.pbOutput9;

                        lblOutputs[0] = forms.Frm_Nine.lblOutput1;
                        lblOutputs[1] = forms.Frm_Nine.lblOutput2;
                        lblOutputs[2] = forms.Frm_Nine.lblOutput3;
                        lblOutputs[3] = forms.Frm_Nine.lblOutput4;
                        lblOutputs[4] = forms.Frm_Nine.lblOutput5;
                        lblOutputs[5] = forms.Frm_Nine.lblOutput6;
                        lblOutputs[6] = forms.Frm_Nine.lblOutput7;
                        lblOutputs[7] = forms.Frm_Nine.lblOutput8;
                        lblOutputs[8] = forms.Frm_Nine.lblOutput9;
                    }
                    else if (Properties.Settings.Default.pref_image_output == 12)
                    {
                        pbOutputs[0] = forms.Frm_Twelve.pbOutput1;
                        pbOutputs[1] = forms.Frm_Twelve.pbOutput2;
                        pbOutputs[2] = forms.Frm_Twelve.pbOutput3;
                        pbOutputs[3] = forms.Frm_Twelve.pbOutput4;
                        pbOutputs[4] = forms.Frm_Twelve.pbOutput5;
                        pbOutputs[5] = forms.Frm_Twelve.pbOutput6;
                        pbOutputs[6] = forms.Frm_Twelve.pbOutput7;
                        pbOutputs[7] = forms.Frm_Twelve.pbOutput8;
                        pbOutputs[8] = forms.Frm_Twelve.pbOutput9;
                        pbOutputs[9] = forms.Frm_Twelve.pbOutput10;
                        pbOutputs[10] = forms.Frm_Twelve.pbOutput11;
                        pbOutputs[11] = forms.Frm_Twelve.pbOutput12;

                        lblOutputs[0] = forms.Frm_Twelve.lblOutput1;
                        lblOutputs[1] = forms.Frm_Twelve.lblOutput2;
                        lblOutputs[2] = forms.Frm_Twelve.lblOutput3;
                        lblOutputs[3] = forms.Frm_Twelve.lblOutput4;
                        lblOutputs[4] = forms.Frm_Twelve.lblOutput5;
                        lblOutputs[5] = forms.Frm_Twelve.lblOutput6;
                        lblOutputs[6] = forms.Frm_Twelve.lblOutput7;
                        lblOutputs[7] = forms.Frm_Twelve.lblOutput8;
                        lblOutputs[8] = forms.Frm_Twelve.lblOutput9;
                        lblOutputs[9] = forms.Frm_Twelve.lblOutput10;
                        lblOutputs[10] = forms.Frm_Twelve.lblOutput11;
                        lblOutputs[11] = forms.Frm_Twelve.lblOutput12;
                    }

                    if (Properties.Settings.Default.face_detection == "AllType")
                    {
                        command.CommandText = "SELECT * FROM Images ORDER BY TemporaryResultComparision DESC LIMIT " + (Convert.ToInt32(Properties.Settings.Default.pref_image_output) + 1);
                    }
                    else if (Properties.Settings.Default.face_detection == "OnlyFaces")
                    {
                        command.CommandText = "SELECT * FROM Images WHERE Face_detected >= 1  ORDER BY TemporaryResultComparision DESC LIMIT " + (Convert.ToInt32(Properties.Settings.Default.pref_image_output) + 1);
                    }
                    else if (Properties.Settings.Default.face_detection == "NoFaces")
                    {
                        command.CommandText = "SELECT * FROM Images WHERE Face_detected == 0 ORDER BY TemporaryResultComparision DESC LIMIT " + (Convert.ToInt32(Properties.Settings.Default.pref_image_output) + 1);
                    }

                    SqliteDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {

                        for (int counter = 0; counter < Properties.Settings.Default.pref_image_output; counter++)
                        {
                            reader.Read();
                            if (cbIncludeIdentic.Checked == true && Convert.ToString(reader.GetString(1)) == "100" && counter == 0)
                            {
                                reader.Read();
                            }
                            outputImagePath[counter] = Convert.ToString(reader.GetString(0));
                            lblOutputs[counter].Text = String.Format(setLanguage.lblResults_Text, Path.GetFileName(Convert.ToString(reader.GetString(0))), Convert.ToString(reader.GetString(1)));
                            pbOutputs[counter].Image = Image.FromFile(outputImagePath[counter]);

                        }
                    }
                    conread.Close();
                }
                else
                {
                    MessageBox.Show("An error has occurred.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnCompare.Enabled = true;
                btnCompare.Text = setLanguage.btnCompare_Text;
                Cursor.Current = Cursors.Default;
                btnSaveResults.Enabled = true;
            }
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            using (var openDirDialog = new FolderBrowserDialog())
            {
                DialogResult result = openDirDialog.ShowDialog();
                string fileName;
                string destFile;
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openDirDialog.SelectedPath))
                {
                    for (int i = 0; i < Properties.Settings.Default.pref_image_output; i++)
                    {
                        fileName = Path.GetFileName(frmHome.outputImagePath[i]);
                        destFile = Path.Combine(openDirDialog.SelectedPath, fileName);
                        File.Copy(frmHome.outputImagePath[i], destFile, true);
                    }
                    MessageBox.Show(setLanguage.messageSaveResults, "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
