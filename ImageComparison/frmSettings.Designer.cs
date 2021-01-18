
namespace ImageComparison
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbAlgorithm = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbNoFaceDetection = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbFaceDetection = new System.Windows.Forms.RadioButton();
            this.lblFaceDetection = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbSift = new System.Windows.Forms.RadioButton();
            this.rbHistogram = new System.Windows.Forms.RadioButton();
            this.rbSSIM = new System.Windows.Forms.RadioButton();
            this.lblChooseAlgorithm = new System.Windows.Forms.Label();
            this.gbImageOutput = new System.Windows.Forms.GroupBox();
            this.lblNumImageOutput = new System.Windows.Forms.Label();
            this.rb12Images = new System.Windows.Forms.RadioButton();
            this.rb9Images = new System.Windows.Forms.RadioButton();
            this.rb6Images = new System.Windows.Forms.RadioButton();
            this.gbInterfaceTheme = new System.Windows.Forms.GroupBox();
            this.lblChooseTheme = new System.Windows.Forms.Label();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.pbApplied = new System.Windows.Forms.PictureBox();
            this.gbPrecalData = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panelCalculate = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.panelApply = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenImageDir = new System.Windows.Forms.Button();
            this.gbAlgorithm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbImageOutput.SuspendLayout();
            this.gbInterfaceTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplied)).BeginInit();
            this.gbPrecalData.SuspendLayout();
            this.panelCalculate.SuspendLayout();
            this.panelApply.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlgorithm
            // 
            this.gbAlgorithm.Controls.Add(this.panel3);
            this.gbAlgorithm.Controls.Add(this.lblFaceDetection);
            this.gbAlgorithm.Controls.Add(this.rbAll);
            this.gbAlgorithm.Controls.Add(this.rbSift);
            this.gbAlgorithm.Controls.Add(this.rbHistogram);
            this.gbAlgorithm.Controls.Add(this.rbSSIM);
            this.gbAlgorithm.Controls.Add(this.lblChooseAlgorithm);
            this.gbAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbAlgorithm.Location = new System.Drawing.Point(9, 41);
            this.gbAlgorithm.Name = "gbAlgorithm";
            this.gbAlgorithm.Size = new System.Drawing.Size(527, 245);
            this.gbAlgorithm.TabIndex = 0;
            this.gbAlgorithm.TabStop = false;
            this.gbAlgorithm.Text = "Algoritmo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbNoFaceDetection);
            this.panel3.Controls.Add(this.rbDefault);
            this.panel3.Controls.Add(this.rbFaceDetection);
            this.panel3.Location = new System.Drawing.Point(188, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 75);
            this.panel3.TabIndex = 13;
            // 
            // rbNoFaceDetection
            // 
            this.rbNoFaceDetection.AutoSize = true;
            this.rbNoFaceDetection.Location = new System.Drawing.Point(3, 49);
            this.rbNoFaceDetection.Name = "rbNoFaceDetection";
            this.rbNoFaceDetection.Size = new System.Drawing.Size(302, 17);
            this.rbNoFaceDetection.TabIndex = 15;
            this.rbNoFaceDetection.TabStop = true;
            this.rbNoFaceDetection.Text = "No Face Detection - Nessuna immagine con volti in Output";
            this.rbNoFaceDetection.UseVisualStyleBackColor = true;
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(3, 4);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(253, 17);
            this.rbDefault.TabIndex = 14;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default - Qualsiasi immagine tipo di foto in output";
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // rbFaceDetection
            // 
            this.rbFaceDetection.AutoSize = true;
            this.rbFaceDetection.Location = new System.Drawing.Point(3, 26);
            this.rbFaceDetection.Name = "rbFaceDetection";
            this.rbFaceDetection.Size = new System.Drawing.Size(260, 17);
            this.rbFaceDetection.TabIndex = 13;
            this.rbFaceDetection.TabStop = true;
            this.rbFaceDetection.Text = "Face Detection - Solo immagini con volti in Output";
            this.rbFaceDetection.UseVisualStyleBackColor = true;
            // 
            // lblFaceDetection
            // 
            this.lblFaceDetection.AutoSize = true;
            this.lblFaceDetection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFaceDetection.Location = new System.Drawing.Point(9, 164);
            this.lblFaceDetection.Name = "lblFaceDetection";
            this.lblFaceDetection.Size = new System.Drawing.Size(175, 13);
            this.lblFaceDetection.TabIndex = 12;
            this.lblFaceDetection.Text = "Aggiunta della Rilevazione dei Volti:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbAll.Location = new System.Drawing.Point(9, 138);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(101, 17);
            this.rbAll.TabIndex = 10;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tutti gli Algoritmi";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbSift
            // 
            this.rbSift.AutoSize = true;
            this.rbSift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbSift.Location = new System.Drawing.Point(9, 115);
            this.rbSift.Name = "rbSift";
            this.rbSift.Size = new System.Drawing.Size(165, 17);
            this.rbSift.TabIndex = 9;
            this.rbSift.TabStop = true;
            this.rbSift.Text = "Ricerca per punti chiave - Sift";
            this.rbSift.UseVisualStyleBackColor = true;
            // 
            // rbHistogram
            // 
            this.rbHistogram.AutoSize = true;
            this.rbHistogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbHistogram.Location = new System.Drawing.Point(9, 92);
            this.rbHistogram.Name = "rbHistogram";
            this.rbHistogram.Size = new System.Drawing.Size(168, 17);
            this.rbHistogram.TabIndex = 7;
            this.rbHistogram.TabStop = true;
            this.rbHistogram.Text = "Ricerca per colore - Histogram";
            this.rbHistogram.UseVisualStyleBackColor = true;
            // 
            // rbSSIM
            // 
            this.rbSSIM.AutoSize = true;
            this.rbSSIM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbSSIM.Location = new System.Drawing.Point(9, 69);
            this.rbSSIM.Name = "rbSSIM";
            this.rbSSIM.Size = new System.Drawing.Size(164, 17);
            this.rbSSIM.TabIndex = 6;
            this.rbSSIM.TabStop = true;
            this.rbSSIM.Text = "Ricerca per differenze - SSIM";
            this.rbSSIM.UseVisualStyleBackColor = true;
            // 
            // lblChooseAlgorithm
            // 
            this.lblChooseAlgorithm.AutoSize = true;
            this.lblChooseAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblChooseAlgorithm.Location = new System.Drawing.Point(6, 36);
            this.lblChooseAlgorithm.Name = "lblChooseAlgorithm";
            this.lblChooseAlgorithm.Size = new System.Drawing.Size(161, 13);
            this.lblChooseAlgorithm.TabIndex = 5;
            this.lblChooseAlgorithm.Text = "Scelta dell\'algoritmo da utilizzare:";
            // 
            // gbImageOutput
            // 
            this.gbImageOutput.Controls.Add(this.lblNumImageOutput);
            this.gbImageOutput.Controls.Add(this.rb12Images);
            this.gbImageOutput.Controls.Add(this.rb9Images);
            this.gbImageOutput.Controls.Add(this.rb6Images);
            this.gbImageOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbImageOutput.Location = new System.Drawing.Point(546, 45);
            this.gbImageOutput.Name = "gbImageOutput";
            this.gbImageOutput.Size = new System.Drawing.Size(348, 241);
            this.gbImageOutput.TabIndex = 1;
            this.gbImageOutput.TabStop = false;
            this.gbImageOutput.Text = "Numero Immagini in Output";
            // 
            // lblNumImageOutput
            // 
            this.lblNumImageOutput.AutoSize = true;
            this.lblNumImageOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblNumImageOutput.Location = new System.Drawing.Point(6, 36);
            this.lblNumImageOutput.Name = "lblNumImageOutput";
            this.lblNumImageOutput.Size = new System.Drawing.Size(145, 13);
            this.lblNumImageOutput.TabIndex = 6;
            this.lblNumImageOutput.Text = "Numero di immagini in output:";
            // 
            // rb12Images
            // 
            this.rb12Images.AutoSize = true;
            this.rb12Images.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rb12Images.Location = new System.Drawing.Point(9, 125);
            this.rb12Images.Name = "rb12Images";
            this.rb12Images.Size = new System.Drawing.Size(81, 17);
            this.rb12Images.TabIndex = 2;
            this.rb12Images.TabStop = true;
            this.rb12Images.Text = "12 Immagini";
            this.rb12Images.UseVisualStyleBackColor = true;
            // 
            // rb9Images
            // 
            this.rb9Images.AutoSize = true;
            this.rb9Images.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rb9Images.Location = new System.Drawing.Point(9, 94);
            this.rb9Images.Name = "rb9Images";
            this.rb9Images.Size = new System.Drawing.Size(75, 17);
            this.rb9Images.TabIndex = 1;
            this.rb9Images.TabStop = true;
            this.rb9Images.Text = "9 Immagini";
            this.rb9Images.UseVisualStyleBackColor = true;
            // 
            // rb6Images
            // 
            this.rb6Images.AutoSize = true;
            this.rb6Images.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rb6Images.Location = new System.Drawing.Point(9, 63);
            this.rb6Images.Name = "rb6Images";
            this.rb6Images.Size = new System.Drawing.Size(75, 17);
            this.rb6Images.TabIndex = 0;
            this.rb6Images.TabStop = true;
            this.rb6Images.Text = "6 Immagini";
            this.rb6Images.UseVisualStyleBackColor = true;
            // 
            // gbInterfaceTheme
            // 
            this.gbInterfaceTheme.Controls.Add(this.lblChooseTheme);
            this.gbInterfaceTheme.Controls.Add(this.rbBlack);
            this.gbInterfaceTheme.Controls.Add(this.rbWhite);
            this.gbInterfaceTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbInterfaceTheme.Location = new System.Drawing.Point(901, 41);
            this.gbInterfaceTheme.Name = "gbInterfaceTheme";
            this.gbInterfaceTheme.Size = new System.Drawing.Size(322, 245);
            this.gbInterfaceTheme.TabIndex = 3;
            this.gbInterfaceTheme.TabStop = false;
            this.gbInterfaceTheme.Text = "Tema Interfaccia";
            // 
            // lblChooseTheme
            // 
            this.lblChooseTheme.AutoSize = true;
            this.lblChooseTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblChooseTheme.Location = new System.Drawing.Point(6, 24);
            this.lblChooseTheme.Name = "lblChooseTheme";
            this.lblChooseTheme.Size = new System.Drawing.Size(163, 13);
            this.lblChooseTheme.TabIndex = 7;
            this.lblChooseTheme.Text = "Scelta del tema dell\'applicazione:";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbBlack.Location = new System.Drawing.Point(14, 69);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(53, 17);
            this.rbBlack.TabIndex = 1;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Scuro";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbWhite.Location = new System.Drawing.Point(14, 46);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(55, 17);
            this.rbWhite.TabIndex = 0;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "Chiaro";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // pbApplied
            // 
            this.pbApplied.Image = ((System.Drawing.Image)(resources.GetObject("pbApplied.Image")));
            this.pbApplied.Location = new System.Drawing.Point(1047, 644);
            this.pbApplied.Name = "pbApplied";
            this.pbApplied.Size = new System.Drawing.Size(30, 30);
            this.pbApplied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplied.TabIndex = 5;
            this.pbApplied.TabStop = false;
            this.pbApplied.Visible = false;
            // 
            // gbPrecalData
            // 
            this.gbPrecalData.Controls.Add(this.lblProgress);
            this.gbPrecalData.Controls.Add(this.panelCalculate);
            this.gbPrecalData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbPrecalData.Location = new System.Drawing.Point(9, 292);
            this.gbPrecalData.Name = "gbPrecalData";
            this.gbPrecalData.Size = new System.Drawing.Size(1214, 105);
            this.gbPrecalData.TabIndex = 6;
            this.gbPrecalData.TabStop = false;
            this.gbPrecalData.Text = "Precalcolo Dati per comparazione";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(117, 37);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(141, 13);
            this.lblProgress.TabIndex = 10;
            this.lblProgress.Text = "Nessun operazione in corso.";
            // 
            // panelCalculate
            // 
            this.panelCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelCalculate.Controls.Add(this.btnCalc);
            this.panelCalculate.Location = new System.Drawing.Point(12, 31);
            this.panelCalculate.Name = "panelCalculate";
            this.panelCalculate.Size = new System.Drawing.Size(99, 40);
            this.panelCalculate.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCalc.Location = new System.Drawing.Point(0, 0);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(99, 40);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcola";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // panelApply
            // 
            this.panelApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelApply.Controls.Add(this.btnSaveChanges);
            this.panelApply.Location = new System.Drawing.Point(1083, 639);
            this.panelApply.Name = "panelApply";
            this.panelApply.Size = new System.Drawing.Size(140, 40);
            this.panelApply.TabIndex = 10;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(0, 0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 40);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Applica Modifiche";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnOpenImage);
            this.panel1.Location = new System.Drawing.Point(18, 634);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 40);
            this.panel1.TabIndex = 11;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnOpenImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenImage.FlatAppearance.BorderSize = 0;
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOpenImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenImage.Location = new System.Drawing.Point(0, 0);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(182, 40);
            this.btnOpenImage.TabIndex = 9;
            this.btnOpenImage.Text = "Mostra cartella immagine INPUT";
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.btnOpenImageDir);
            this.panel2.Location = new System.Drawing.Point(206, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 40);
            this.panel2.TabIndex = 12;
            // 
            // btnOpenImageDir
            // 
            this.btnOpenImageDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnOpenImageDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenImageDir.FlatAppearance.BorderSize = 0;
            this.btnOpenImageDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOpenImageDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenImageDir.Location = new System.Drawing.Point(0, 0);
            this.btnOpenImageDir.Name = "btnOpenImageDir";
            this.btnOpenImageDir.Size = new System.Drawing.Size(182, 40);
            this.btnOpenImageDir.TabIndex = 9;
            this.btnOpenImageDir.Text = "Mostra cartella ARCHIVIO immagini";
            this.btnOpenImageDir.UseVisualStyleBackColor = false;
            this.btnOpenImageDir.Click += new System.EventHandler(this.btnOpenImageDir_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelApply);
            this.Controls.Add(this.gbPrecalData);
            this.Controls.Add(this.pbApplied);
            this.Controls.Add(this.gbInterfaceTheme);
            this.Controls.Add(this.gbImageOutput);
            this.Controls.Add(this.gbAlgorithm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.gbAlgorithm.ResumeLayout(false);
            this.gbAlgorithm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbImageOutput.ResumeLayout(false);
            this.gbImageOutput.PerformLayout();
            this.gbInterfaceTheme.ResumeLayout(false);
            this.gbInterfaceTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplied)).EndInit();
            this.gbPrecalData.ResumeLayout(false);
            this.gbPrecalData.PerformLayout();
            this.panelCalculate.ResumeLayout(false);
            this.panelApply.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbApplied;
        public System.Windows.Forms.RadioButton rb12Images;
        public System.Windows.Forms.RadioButton rb9Images;
        public System.Windows.Forms.RadioButton rb6Images;
        public System.Windows.Forms.RadioButton rbAll;
        public System.Windows.Forms.RadioButton rbSift;
        public System.Windows.Forms.RadioButton rbHistogram;
        public System.Windows.Forms.RadioButton rbSSIM;
        public System.Windows.Forms.RadioButton rbBlack;
        public System.Windows.Forms.RadioButton rbWhite;
        public System.Windows.Forms.GroupBox gbImageOutput;
        public System.Windows.Forms.Label lblNumImageOutput;
        public System.Windows.Forms.GroupBox gbInterfaceTheme;
        public System.Windows.Forms.Label lblChooseTheme;
        public System.Windows.Forms.GroupBox gbAlgorithm;
        public System.Windows.Forms.Label lblChooseAlgorithm;
        public System.Windows.Forms.Label lblFaceDetection;
        private System.Windows.Forms.Panel panelCalculate;
        public System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel panelApply;
        public System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnOpenImageDir;
        public System.Windows.Forms.GroupBox gbPrecalData;
        public System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton rbDefault;
        public System.Windows.Forms.RadioButton rbFaceDetection;
        public System.Windows.Forms.RadioButton rbNoFaceDetection;
    }
}