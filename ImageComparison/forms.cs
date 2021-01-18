
using System.Windows.Forms;

namespace ImageComparison
{
    class forms
    {
        public static frmMain Frm_Main = new frmMain();
        public static frmHome Frm_Home = new frmHome();
        public static frmSettings Frm_Settings = new frmSettings();
        public static frmGuide Frm_Guide = new frmGuide();

        public static frmNineImages Frm_Nine = new frmNineImages();
        public static frmTwelveImages Frm_Twelve = new frmTwelveImages();
        public static frmSixImages Frm_Six = new frmSixImages();

        public static frmViewImage Frm_ViewImage = new frmViewImage();

        public static void Run()
        {
            Application.Run(Frm_Main);
        }
    }
}
