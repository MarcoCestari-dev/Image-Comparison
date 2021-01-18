using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmNineImages : Form
    {
        public frmNineImages()
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

        private void pbOutput7_DoubleClick(object sender, EventArgs e)
        {
            callImageView(6);
        }

        private void pbOutput8_DoubleClick(object sender, EventArgs e)
        {
            callImageView(7);
        }

        private void pbOutput9_DoubleClick(object sender, EventArgs e)
        {
            callImageView(8);
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
