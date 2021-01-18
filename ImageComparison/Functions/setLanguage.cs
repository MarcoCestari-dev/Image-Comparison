using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageComparison.Functions
{
    class setLanguage
    {
        public static string lblInputName_Text;
        public static string lblTotDir_Text;
        public static string lblNumOutpuImages_Text;
        public static string lblAlgorithm_Text;
        public static string lblFaceDetection_Text;

        public static string lblFDAny_Text;
        public static string lblFDOn_Text;
        public static string lblFDOff_Text;

        public static string lblResults_Text;

        public static string funcHist_Text;
        public static string funcSsim_Text;
        public static string funcSift_Text;
        public static string funcAll_Text;
        public static string funcFD_Text;

        public static string lblProgressFirst_Text;
        public static string lblProgressSecond_Text;
        public static string lblProgressThird_Text;

        public static string typeImageHist_Text;
        public static string typeImageSsim_Text;
        public static string typeImageSift_Text;
        public static string typeImageAll_Text;
        public static string typeImageFD_Text;
        public static string btnHome_Text;
        public static string btnSettings_Text;
        public static string btnGuide_Text;
        public static string btnCompareProgress_Text;
        public static string btnCompare_Text;

        public static string messageSaveResults;
        public static string messageRecalculate;
        public static string messageRecalculateDifferent;

        public static string NoImages;

        public static void setEnglish()
        {
            btnHome_Text = "    Home";
            btnSettings_Text = "    Settings";
            btnGuide_Text = "    Guide";
            forms.Frm_Main.btnHome.Text = btnHome_Text;
            forms.Frm_Main.btnSettings.Text = btnSettings_Text;
            forms.Frm_Main.btnGuide.Text = btnGuide_Text;

            forms.Frm_Home.gbImageInputInfo.Text = "Image in input and other Informations";
            forms.Frm_Home.btnChooseInputImage.Text = "Choose your Input image";
            forms.Frm_Home.btnChooseDir.Text = "Choose your Directory";
            messageRecalculate = "It is necessary to recalculate the data now to make the comparisons:\nAre you sure you want to do it?\nIt may take a few minutes.";
            messageRecalculateDifferent = "The number of images in the default folder seems to be changed. Do you want to recalculate the data to be able to make the comparisons again?";

            btnCompareProgress_Text = "Compare in progress...";
            btnCompare_Text = "Compare";
            forms.Frm_Home.btnCompare.Text = btnCompare_Text;
            forms.Frm_Home.btnSaveResults.Text = "Save Results";
            forms.Frm_Home.cbIncludeIdentic.Text = "Exclude Identical Images";

            lblResults_Text = "Image: {0} \nAffidability: {1} %";

            forms.Frm_Settings.gbImageOutput.Text = "Images in Output";
            forms.Frm_Settings.lblNumImageOutput.Text = "Number of images in Output:";
            forms.Frm_Settings.rb6Images.Text = "6 Images";
            forms.Frm_Settings.rb9Images.Text = "9 Images";
            forms.Frm_Settings.rb12Images.Text = "12 Images";
            forms.Frm_Settings.gbInterfaceTheme.Text = "Interface Theme";
            forms.Frm_Settings.lblChooseTheme.Text = "Choose the Application Theme:";
            forms.Frm_Settings.rbWhite.Text = "Light";
            forms.Frm_Settings.rbBlack.Text = "Dark";
            forms.Frm_Settings.gbAlgorithm.Text = "Algorithm";
            forms.Frm_Settings.lblChooseAlgorithm.Text = "Choice of Algorithms to be used:";
            forms.Frm_Settings.rbSSIM.Text = "Search by difference - SSIM";
            forms.Frm_Settings.rbHistogram.Text = "Search by Color - Histogram";
            forms.Frm_Settings.rbSift.Text = "Search by Key Points - Sift";
            forms.Frm_Settings.rbAll.Text = "All Algorithms";
            forms.Frm_Settings.lblFaceDetection.Text = "Added Face Detection: ";
            forms.Frm_Settings.rbDefault.Text = "Default - Any type of output image";
            forms.Frm_Settings.rbFaceDetection.Text = "Face Detection - Only images with faces in Output";
            forms.Frm_Settings.rbNoFaceDetection.Text = "No Face Detection - No image with faces in Output";

            forms.Frm_Settings.gbPrecalData.Text = "Pre-calculation of data for comparison";
            forms.Frm_Settings.btnCalc.Text = "Calculate";
            forms.Frm_Settings.lblProgress.Text = "There's no operation in progress.";
            lblProgressFirst_Text = "Deleting the previous data...";
            lblProgressSecond_Text = "Recreating the new files... \nIt may take few minutes ...";
            lblProgressThird_Text = "Operation complete. \nNo other operations in progress.";
            forms.Frm_Settings.btnOpenImage.Text = "Show INPUT image folder";
            forms.Frm_Settings.btnOpenImageDir.Text = "Show image ARCHIVE folder";
            forms.Frm_Settings.btnSaveChanges.Text = "Save Changes";

            forms.Frm_Home.lblInputName.Text = "Choosen image for Input: No Image selected";
            lblInputName_Text = "Choosen image for Input: {0}";

            forms.Frm_Home.lblTotDir.Text = "In total the archive contains: no archive selected";
            lblTotDir_Text = "In total the {0} archive contains: {1} Images";

            forms.Frm_Home.lblNumOutputImages.Text = "Number of Images requested in Output: {0}";
            lblNumOutpuImages_Text = "Number of Images requested in output: {0}";

            forms.Frm_Home.lblAlgorithm.Text = "Algorithm required to make the Comparison: {0}";
            lblAlgorithm_Text = "Algorithm required to make the Comparison: {0}";

            forms.Frm_Home.lblFaceDetection.Text = "- Use Face Detection: {0}";
            lblFaceDetection_Text = "- Use Face Detection: {0}";
            lblFDAny_Text = "Any photo in Output";
            lblFDOn_Text = "Enabled";
            lblFDOff_Text = "Disabled";

            #region Guide

            funcHist_Text = "The algorithm, for each image, creates a histogram that represents the intensity and variability of the colors present in the images. Then compares the two histograms providing a percentage of similarity.";
            funcSsim_Text = "The algorithm focuses on the differences. It transforms the images into grayscale, overlaps them and makes the difference in the intensity of gray of the pixels, thus finding the differences between the images and subsequently returns a percentage of evaluation.";
            funcSift_Text = "The algorithm detects and describes the characteristics of digital images. It identifies the key points of the image and provides quantitative information about them, then makes a comparison with the key points of the other images and gives a percentage.";
            funcAll_Text = "It uses all the algorithms to make a similarity assessment between the images, weighs their results to obtain a satisfactory result. Using all three algorithms leads to a higher computational load.";
            funcFD_Text = "It is a secondary algorithm, because it does not provide a percentage of similarity, but allows you to check for the presence of faces. It has three modes: \n- Default: allows to output any type of image (both with and without faces) \n- Face Detection: allows to output only images WITH FACES \n- No Face Detection: allows output only images WITHOUT FACES";

            typeImageHist_Text = "Images with few colors but defined and uniform, that is with few shades. \nExamples: fruits, objects, mountain landscapes ...";
            typeImageSsim_Text = "Images with well-defined structure or with images where filters or artifacts have been applied. \nExamples: sunsets, buildings ...";
            typeImageSift_Text = "Images with a fixed and defined object as main subject. \nExamples: buildings, monuments ...";
            typeImageAll_Text = "";
            typeImageFD_Text = "";

            #endregion

            messageSaveResults = "Successfully saved in the provided folder.";

            NoImages = "There's no images uploaded.";
            ClearOutput();
        }

        public static void setItaliano()
        {
            btnHome_Text = "    Home";
            btnSettings_Text = "    Impostazioni";
            btnGuide_Text = "    Guida";
            forms.Frm_Main.btnHome.Text = btnHome_Text;
            forms.Frm_Main.btnSettings.Text = btnSettings_Text;
            forms.Frm_Main.btnGuide.Text = btnGuide_Text;

            forms.Frm_Home.gbImageInputInfo.Text = "Immagini in input e altre informazioni";
            forms.Frm_Home.btnChooseInputImage.Text = "Scegli l'immagine di Input";
            forms.Frm_Home.btnChooseDir.Text = "Scegli l'archivio";
            messageRecalculate = "E' necessario ricalcolare ora i dati per effettuare i confronti:\nSicuro di volerlo fare?\nPotrebbe richiedere alcuni minuti.";
            messageRecalculateDifferent = "Il numero delle immagini nella cartella di default sembra essere cambiato. Vuoi ricalcolare i dati per poter effettuare di nuovo i confronti?";

            btnCompareProgress_Text = "Confronto in corso...";
            btnCompare_Text = "Confronta";
            forms.Frm_Home.btnCompare.Text = btnCompare_Text;
            forms.Frm_Home.btnSaveResults.Text = "Salva Risultati";
            forms.Frm_Home.cbIncludeIdentic.Text = "Escludi immagini identiche";
            
            lblResults_Text = "Immagine: {0} \nAffidabilità: {1} %";

            forms.Frm_Settings.gbImageOutput.Text = "Immagini in Output";
            forms.Frm_Settings.lblNumImageOutput.Text = "Numero di immagini in Output:";
            forms.Frm_Settings.rb6Images.Text = "6 Immagini";
            forms.Frm_Settings.rb9Images.Text = "9 Immagini";
            forms.Frm_Settings.rb12Images.Text = "12 Immagini";
            forms.Frm_Settings.gbInterfaceTheme.Text = "Tema Interfaccia";
            forms.Frm_Settings.lblChooseTheme.Text = "Scegli il tema dell'applicazione:";
            forms.Frm_Settings.rbWhite.Text = "Chiaro";
            forms.Frm_Settings.rbBlack.Text = "Scuro";
            forms.Frm_Settings.gbAlgorithm.Text = "Algoritmi";
            forms.Frm_Settings.lblChooseAlgorithm.Text = "Scelta degli algortimi da utilizzare:";
            forms.Frm_Settings.rbSSIM.Text = "Ricerca per differenze - SSIM";
            forms.Frm_Settings.rbHistogram.Text = "Ricerca per colore - Histogram";
            forms.Frm_Settings.rbSift.Text = "Ricerca per punti chiave - Sift";
            forms.Frm_Settings.rbAll.Text = "Tutti gli Algoritmi";
            forms.Frm_Settings.lblFaceDetection.Text = "Aggiunta della Rilevazione dei Volti:";
            forms.Frm_Settings.rbDefault.Text = "Default - Qualsiasi tipo di immagine in Output";
            forms.Frm_Settings.rbFaceDetection.Text = "Face Detection - Solo immagini con volti in Output";
            forms.Frm_Settings.rbNoFaceDetection.Text = "No Face Detection - Nessuna immagine con volti in Output";

            forms.Frm_Settings.gbPrecalData.Text = "Pre-Calcolo Dati per Comparazione";
            forms.Frm_Settings.btnCalc.Text = "Calcola";
            forms.Frm_Settings.lblProgress.Text = "Nessun altra operazione in corso.";
            lblProgressFirst_Text = "Cancellando i dati precedenti...";
            lblProgressSecond_Text = "Ricreando i nuovi files... \nPotrebbe metterci alcuni minuti ...";
            lblProgressThird_Text = "Operazione completata. \nNon ci sono altre operazioni in corso.";
            forms.Frm_Settings.btnOpenImage.Text = "Mostra cartella immagine INPUT";
            forms.Frm_Settings.btnOpenImageDir.Text = "Mostra cartella ARCHIVIO immagini";
            forms.Frm_Settings.btnSaveChanges.Text = "Applica modifiche";

            forms.Frm_Home.lblInputName.Text = "Immagine scelta per l'input: Nessuna immagine selezionata";
            lblInputName_Text = "Immagine scelta per l'input: {0}";

            forms.Frm_Home.lblTotDir.Text = "In totale l'archivio contiene: nessun archivio selezionato";
            lblTotDir_Text = "In totale l'archivio {0} contiene: {1} Immagini";

            forms.Frm_Home.lblNumOutputImages.Text = "Numero di Immagini richieste in Output: {0}";
            lblNumOutpuImages_Text = "Numero di Immagini richieste in Output: {0}";

            forms.Frm_Home.lblAlgorithm.Text = "Algoritmo richiesto per fare il confronto: {0}";
            lblAlgorithm_Text = "Algoritmo richiesto per fare il confronto: {0}";

            forms.Frm_Home.lblFaceDetection.Text = "- Utilizzo Face Detection: {0}";
            lblFaceDetection_Text = "- Utilizzo Face Detection: {0}";
            lblFDAny_Text = "Qualsiasi foto in Output";
            lblFDOn_Text = "Attivato";
            lblFDOff_Text = "Disattivato";

            #region Guide

            funcHist_Text = "L'algoritmo, per ogni immagine, crea un istogramma che rappresenti l'intensità e la variabilità dei colori presenti all'interno di essa. Confronta poi i due istogrammi fornendo una percentuale di somiglianza.";
            funcSsim_Text = "L'algoritmo si concentra sulle differenze. Trasforma le immagini in scala di grigio, le sovrappone e fa la differenza dell'intensità di grigio dei pixel, trovando così le differenze tra le immagini e restituisce successivamente una percentuale di valutazione.";
            funcSift_Text = "L'algoritmo rileva e descrive le caratteristiche delle immagini digitali. Individua i punti chiave della immagine e fornisce informazioni quantitative su di essi, poi fa un contronto con i punti chiave delle altre immagini e fornisce una percentuale.";
            funcAll_Text = "Utilizza tutti gli algoritmi per fare una valutazione di somiglianza tra le immagini, pondera i loro risultati per ottenere un risultato soddisfacente. L'utilizzo di tutti e tre gli algoritmi porta a un carico computazionale maggiore.";
            funcFD_Text = "E' un algoritmo secondario, perchè non fornisce una percentuale di somiglianza, ma permette di verificare la presenza di volti. Presenta tre modalità:\n- Default: permette in output qualsiasi tipo di immagine (sia con volti che senza)\n- Face Detection: permette in output solo immagini CON VOLTI\n- No Face Detection: permette in output solo immagini SENZA VOLTI";

            typeImageHist_Text = "Immagini con pochi colori ma definiti e uniformi, cioè con poche sfumature.\nEsempi: frutti, oggetti, paesaggi montani...";
            typeImageSsim_Text = "Immagini con struttura ben definita o con immagini dove sono stati applicati filtri o artefatti. \nEsempi: tramonti, edifici...";
            typeImageSift_Text = "Immagini con soggetto principale un oggetto fisso e definito. \nEsempi: edifici, monumenti...";
            typeImageAll_Text = "";
            typeImageFD_Text = "";

            #endregion

            messageSaveResults = "Salvati correttamente nella cartella richiesta.";

            NoImages = "Nessuna immagine caricata.";
            ClearOutput();
        }

        public static void ClearOutput()
        {
            if (Properties.Settings.Default.pref_image_output == 6)
            {
                forms.Frm_Six.pbOutput1.Image = null;
                forms.Frm_Six.pbOutput2.Image = null;
                forms.Frm_Six.pbOutput3.Image = null;
                forms.Frm_Six.pbOutput4.Image = null;
                forms.Frm_Six.pbOutput5.Image = null;
                forms.Frm_Six.pbOutput6.Image = null;

                forms.Frm_Six.lblOutput1.Text = NoImages;
                forms.Frm_Six.lblOutput2.Text = NoImages;
                forms.Frm_Six.lblOutput3.Text = NoImages;
                forms.Frm_Six.lblOutput4.Text = NoImages;
                forms.Frm_Six.lblOutput5.Text = NoImages;
                forms.Frm_Six.lblOutput6.Text = NoImages;

            }
            if (Properties.Settings.Default.pref_image_output == 9)
            {
                forms.Frm_Nine.lblOutput1.Text = NoImages;
                forms.Frm_Nine.lblOutput2.Text = NoImages;
                forms.Frm_Nine.lblOutput3.Text = NoImages;
                forms.Frm_Nine.lblOutput4.Text = NoImages;
                forms.Frm_Nine.lblOutput5.Text = NoImages;
                forms.Frm_Nine.lblOutput6.Text = NoImages;
                forms.Frm_Nine.lblOutput7.Text = NoImages;
                forms.Frm_Nine.lblOutput8.Text = NoImages;
                forms.Frm_Nine.lblOutput9.Text = NoImages;

                forms.Frm_Nine.pbOutput1.Image = null;
                forms.Frm_Nine.pbOutput2.Image = null;
                forms.Frm_Nine.pbOutput3.Image = null;
                forms.Frm_Nine.pbOutput4.Image = null;
                forms.Frm_Nine.pbOutput5.Image = null;
                forms.Frm_Nine.pbOutput6.Image = null;
                forms.Frm_Nine.pbOutput7.Image = null;
                forms.Frm_Nine.pbOutput8.Image = null;
                forms.Frm_Nine.pbOutput9.Image = null;
            }
            if (Properties.Settings.Default.pref_image_output == 12)
            {
                forms.Frm_Twelve.lblOutput1.Text = NoImages;
                forms.Frm_Twelve.lblOutput2.Text = NoImages;
                forms.Frm_Twelve.lblOutput3.Text = NoImages;
                forms.Frm_Twelve.lblOutput4.Text = NoImages;
                forms.Frm_Twelve.lblOutput5.Text = NoImages;
                forms.Frm_Twelve.lblOutput6.Text = NoImages;
                forms.Frm_Twelve.lblOutput7.Text = NoImages;
                forms.Frm_Twelve.lblOutput8.Text = NoImages;
                forms.Frm_Twelve.lblOutput9.Text = NoImages;
                forms.Frm_Twelve.lblOutput10.Text = NoImages;
                forms.Frm_Twelve.lblOutput11.Text = NoImages;
                forms.Frm_Twelve.lblOutput12.Text = NoImages;

                forms.Frm_Twelve.pbOutput1.Image = null;
                forms.Frm_Twelve.pbOutput2.Image = null;
                forms.Frm_Twelve.pbOutput3.Image = null;
                forms.Frm_Twelve.pbOutput4.Image = null;
                forms.Frm_Twelve.pbOutput5.Image = null;
                forms.Frm_Twelve.pbOutput6.Image = null;
                forms.Frm_Twelve.pbOutput7.Image = null;
                forms.Frm_Twelve.pbOutput8.Image = null;
                forms.Frm_Twelve.pbOutput9.Image = null;
                forms.Frm_Twelve.pbOutput10.Image = null;
                forms.Frm_Twelve.pbOutput11.Image = null;
                forms.Frm_Twelve.pbOutput12.Image = null;
            }

            forms.Frm_Home.lblNumOutputImages.Text = String.Format(setLanguage.lblNumOutpuImages_Text, Properties.Settings.Default.pref_image_output);
            forms.Frm_Home.lblAlgorithm.Text = String.Format(setLanguage.lblAlgorithm_Text, Properties.Settings.Default.pref_algorithm);

            if (Properties.Settings.Default.face_detection == "AllType")
            {
                forms.Frm_Home.lblFaceDetection.Text = String.Format(setLanguage.lblFaceDetection_Text, setLanguage.lblFDAny_Text);
            }
            else if (Properties.Settings.Default.face_detection == "OnlyFaces")
            {
                forms.Frm_Home.lblFaceDetection.Text = String.Format(setLanguage.lblFaceDetection_Text, setLanguage.lblFDOn_Text);
            }
            else if (Properties.Settings.Default.face_detection == "NoFaces")
            {
                forms.Frm_Home.lblFaceDetection.Text = String.Format(setLanguage.lblFaceDetection_Text, setLanguage.lblFDOff_Text);
            }

            if (File.Exists(Properties.Settings.Default.default_input_image))
            {
                forms.Frm_Home.lblInputName.Text = String.Format(setLanguage.lblInputName_Text, Path.GetFileName(Properties.Settings.Default.default_input_image));
                forms.Frm_Home.pbInput.Image = Image.FromFile(Properties.Settings.Default.default_input_image);
            }
            else
            {
                forms.Frm_Home.lblInputName.Text = "";
                Properties.Settings.Default.default_input_image = "";
            }

            if (Directory.Exists(Properties.Settings.Default.default_dir))
            {
                DirectoryInfo dirImages = new DirectoryInfo(Properties.Settings.Default.default_dir);
                FileInfo[] Images = dirImages.GetFiles("*.jpg");

                String dirPath = Properties.Settings.Default.default_dir;
                dirPath = dirPath.Substring(dirPath.LastIndexOf("\\")); //C://ciao/utente/dataset --> dataset

                forms.Frm_Home.lblTotDir.Text = String.Format(setLanguage.lblTotDir_Text, dirPath, Images.Length);
            }
            else
            {
                forms.Frm_Home.lblTotDir.Text = "";
                Properties.Settings.Default.default_dir = "";
            }
        }

        public static void setGuide()
        {
            forms.Frm_Guide.dgvGuide.Rows.Clear();
            forms.Frm_Guide.dgvGuide.Rows.Add("Histogram", setLanguage.funcHist_Text, setLanguage.typeImageHist_Text);
            forms.Frm_Guide.dgvGuide.Rows.Add("SSIM", setLanguage.funcSsim_Text, setLanguage.typeImageSsim_Text);
            forms.Frm_Guide.dgvGuide.Rows.Add("SIFT", setLanguage.funcSift_Text, setLanguage.typeImageSift_Text);
            forms.Frm_Guide.dgvGuide.Rows.Add("All", setLanguage.funcAll_Text, setLanguage.typeImageAll_Text);
            forms.Frm_Guide.dgvGuide.Rows.Add("Face Detection", setLanguage.funcFD_Text, setLanguage.typeImageFD_Text);
        }

    }
}
