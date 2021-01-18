using System;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmSixImages : Form
    {
        public frmSixImages()
        {
            InitializeComponent();
        }

        private void pbOutput1_DoubleClick(object sender, EventArgs e)
        {
            callImageView(0);
        }

        private void pbOutput2_DoubleClick(object sender, EventArgs e)
        {
            callImageView(1);
        }

        private void pbOutput3_DoubleClick(object sender, EventArgs e)
        {
            callImageView(2);
        }

        private void pbOutput4_DoubleClick(object sender, EventArgs e)
        {
            callImageView(3);
        }

        private void pbOutput5_DoubleClick(object sender, EventArgs e)
        {
            callImageView(4);
        }

        private void pbOutput6_DoubleClick(object sender, EventArgs e)
        {
            callImageView(5);
        }

        private void callImageView(int index)
        {
            string imagePath = frmHome.outputImagePath[index];
            if (imagePath != null)
            {
                Functions.changeTab.openImageForm(imagePath);
            }
        }
    }
}
