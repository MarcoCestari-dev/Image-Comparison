using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageComparison.Functions
{
    class themeChanger
    {
        public static void setDarkTheme()
        {
            #region Main
            forms.Frm_Main.logoPanel.BackColor = Color.FromArgb(2, 67, 89);

            forms.Frm_Main.btnHome.BackColor = Color.FromArgb(32, 97, 119);
            forms.Frm_Main.btnSettings.BackColor = Color.FromArgb(32, 97, 119);
            forms.Frm_Main.btnGuide.BackColor = Color.FromArgb(32, 97, 119);
            forms.Frm_Main.panelCredits.BackColor = Color.FromArgb(32, 97, 119);

            forms.Frm_Main.sidePanel.BackColor = Color.FromArgb(32, 34, 37);
            forms.Frm_Main.topPanel.BackColor = Color.FromArgb(32, 34, 37);
            forms.Frm_Main.lblNamePanel.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Main.btnHome.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Main.btnSettings.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Main.btnGuide.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Main.contentPanel.BackColor = Color.FromArgb(32, 34, 37);
            #endregion

            #region Home
            forms.Frm_Home.BackColor = Color.FromArgb(47, 49, 54);
            forms.Frm_Home.btnChooseInputImage.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Home.btnChooseInputImage.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Home.btnChooseDir.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Home.btnChooseDir.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Home.btnCompare.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Home.btnCompare.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Home.btnSaveResults.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Home.btnSaveResults.ForeColor = Color.FromArgb(240, 240, 240);

            #region labels
            forms.Frm_Home.gbImageInputInfo.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.lblInputName.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.lblTotDir.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.lblNumOutputImages.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.lblAlgorithm.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.lblFaceDetection.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.cbIncludeIdentic.ForeColor = Color.FromArgb(240, 240, 240);
            #endregion

            #endregion

            #region Settings
            forms.Frm_Settings.BackColor = Color.FromArgb(47, 49, 54);
            forms.Frm_Settings.gbAlgorithm.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.lblChooseAlgorithm.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbSSIM.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbHistogram.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbSift.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbAll.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.lblFaceDetection.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbDefault.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbFaceDetection.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbNoFaceDetection.ForeColor = Color.FromArgb(240, 240, 240);


            forms.Frm_Settings.gbInterfaceTheme.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.lblChooseTheme.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbWhite.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rbBlack.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.gbImageOutput.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.lblNumImageOutput.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rb6Images.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rb9Images.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.rb12Images.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.gbPrecalData.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.lblProgress.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.btnCalc.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Settings.btnCalc.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.btnOpenImage.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Settings.btnOpenImage.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.btnOpenImageDir.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Settings.btnOpenImageDir.ForeColor = Color.FromArgb(240, 240, 240);

            forms.Frm_Settings.btnSaveChanges.BackColor = Color.FromArgb(67, 95, 105);
            forms.Frm_Settings.btnSaveChanges.ForeColor = Color.FromArgb(240, 240, 240);



            #endregion

            #region Guide
            forms.Frm_Guide.BackColor = Color.FromArgb(47, 49, 54);
            #endregion

            #region Form 6 Images
            forms.Frm_Six.BackColor = Color.FromArgb(47, 49, 54);
            forms.Frm_Six.lblOutput1.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput2.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput3.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput4.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput5.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput6.ForeColor = Color.FromArgb(240, 240, 240);
            #endregion

            #region Form 9 Images
            forms.Frm_Nine.BackColor = Color.FromArgb(47, 49, 54);
            forms.Frm_Nine.lblOutput1.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput2.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput3.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput4.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput5.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput6.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput7.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput8.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput9.ForeColor = Color.FromArgb(240, 240, 240);
            #endregion

            #region Form 12 Images
            forms.Frm_Twelve.BackColor = Color.FromArgb(47, 49, 54);
            forms.Frm_Twelve.lblOutput1.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput2.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput3.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput4.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput5.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput6.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput7.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput8.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput9.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput10.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput11.ForeColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput12.ForeColor = Color.FromArgb(240, 240, 240);
            #endregion

            forms.Frm_Main.Refresh();
        }

        public static void setLightTheme()
        {
            #region Main
            forms.Frm_Main.logoPanel.BackColor = Color.FromArgb(248, 143, 88);

            forms.Frm_Main.btnHome.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Main.btnSettings.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Main.btnGuide.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Main.panelCredits.BackColor = Color.FromArgb(255, 204, 153);

            forms.Frm_Main.sidePanel.BackColor = Color.FromArgb(240, 230, 220);
            forms.Frm_Main.topPanel.BackColor = Color.FromArgb(240, 230, 220);
            forms.Frm_Main.lblNamePanel.ForeColor = Color.FromArgb(80, 80, 80);
            forms.Frm_Main.btnHome.ForeColor = Color.FromArgb(80, 80, 80);
            forms.Frm_Main.btnSettings.ForeColor = Color.FromArgb(80, 80, 80);
            forms.Frm_Main.btnGuide.ForeColor = Color.FromArgb(80, 80, 80);
            forms.Frm_Main.contentPanel.BackColor = Color.FromArgb(250, 240, 230);

            
            #endregion

            #region Home
            forms.Frm_Home.BackColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Home.btnChooseInputImage.BackColor = Color.FromArgb(255, 218, 185);
            forms.Frm_Home.btnChooseInputImage.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Home.btnChooseDir.BackColor = Color.FromArgb(255, 218, 185);
            forms.Frm_Home.btnChooseDir.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Home.btnCompare.BackColor = Color.FromArgb(255, 218, 185);
            forms.Frm_Home.btnCompare.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Home.btnSaveResults.BackColor = Color.FromArgb(255, 218, 185);
            forms.Frm_Home.btnSaveResults.ForeColor = Color.FromArgb(50, 50, 50);

            #region labels
            forms.Frm_Home.gbImageInputInfo.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.lblInputName.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.lblTotDir.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.lblNumOutputImages.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.lblAlgorithm.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.lblFaceDetection.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Home.cbIncludeIdentic.ForeColor = Color.FromArgb(50, 50, 50);
            #endregion

            #endregion

            #region Settings
            forms.Frm_Settings.BackColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Settings.gbAlgorithm.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.lblChooseAlgorithm.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbSSIM.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbHistogram.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbSift.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbAll.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.lblFaceDetection.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbDefault.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbFaceDetection.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbNoFaceDetection.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.gbInterfaceTheme.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.lblChooseTheme.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbWhite.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.rbBlack.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.gbImageOutput.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.lblNumImageOutput.ForeColor = Color.FromArgb(50, 50, 50); 
            forms.Frm_Settings.rb6Images.ForeColor = Color.FromArgb(50, 50, 50); 
            forms.Frm_Settings.rb9Images.ForeColor = Color.FromArgb(50, 50, 50); 
            forms.Frm_Settings.rb12Images.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.gbPrecalData.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Settings.lblProgress.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.btnCalc.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Settings.btnCalc.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.btnOpenImage.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Settings.btnOpenImage.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.btnOpenImageDir.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Settings.btnOpenImageDir.ForeColor = Color.FromArgb(50, 50, 50);

            forms.Frm_Settings.btnSaveChanges.BackColor = Color.FromArgb(255, 204, 153);
            forms.Frm_Settings.btnSaveChanges.ForeColor = Color.FromArgb(50, 50, 50);



            #endregion

            #region Guide
            forms.Frm_Guide.BackColor = Color.FromArgb(240, 240, 240);
            #endregion

            #region Form 6 Images
            forms.Frm_Six.BackColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Six.lblOutput1.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Six.lblOutput2.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Six.lblOutput3.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Six.lblOutput4.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Six.lblOutput5.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Six.lblOutput6.ForeColor = Color.FromArgb(50, 50, 50);
            #endregion

            #region Form 9 Images
            forms.Frm_Nine.BackColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Nine.lblOutput1.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput2.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput3.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput4.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput5.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput6.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput7.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput8.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Nine.lblOutput9.ForeColor = Color.FromArgb(50, 50, 50);
            #endregion

            #region Form 12 Images
            forms.Frm_Twelve.BackColor = Color.FromArgb(240, 240, 240);
            forms.Frm_Twelve.lblOutput1.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput2.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput3.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput4.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput5.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput6.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput7.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput8.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput9.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput10.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput11.ForeColor = Color.FromArgb(50, 50, 50);
            forms.Frm_Twelve.lblOutput12.ForeColor = Color.FromArgb(50, 50, 50);

            #endregion

            forms.Frm_Main.Refresh();
        }
    }
}
