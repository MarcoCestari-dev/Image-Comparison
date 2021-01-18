using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class frmViewImage : Form
    {
        public frmViewImage()
        {
            InitializeComponent();
        }

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
                this.SetDesktopLocation(MousePosition.X - (MValX), MousePosition.Y - MValY);
            }
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

        private void frmViewImage_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            forms.Frm_ViewImage.Hide();
            forms.Frm_Main.Enabled = true;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
