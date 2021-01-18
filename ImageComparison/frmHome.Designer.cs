
namespace ImageComparison
{
    partial class frmHome
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
            this.gbImageInputInfo = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.panelCompare = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.panelImageDir = new System.Windows.Forms.Panel();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.panelImageInput = new System.Windows.Forms.Panel();
            this.btnChooseInputImage = new System.Windows.Forms.Button();
            this.cbIncludeIdentic = new System.Windows.Forms.CheckBox();
            this.lblInputName = new System.Windows.Forms.Label();
            this.lblFaceDetection = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.lblTotDir = new System.Windows.Forms.Label();
            this.lblNumOutputImages = new System.Windows.Forms.Label();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.panelImageOutput = new System.Windows.Forms.Panel();
            this.panelHideScroll = new System.Windows.Forms.Panel();
            this.gbImageInputInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCompare.SuspendLayout();
            this.panelImageDir.SuspendLayout();
            this.panelImageInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.SuspendLayout();
            // 
            // gbImageInputInfo
            // 
            this.gbImageInputInfo.Controls.Add(this.lblProgress);
            this.gbImageInputInfo.Controls.Add(this.panel2);
            this.gbImageInputInfo.Controls.Add(this.panelCompare);
            this.gbImageInputInfo.Controls.Add(this.panelImageDir);
            this.gbImageInputInfo.Controls.Add(this.panelImageInput);
            this.gbImageInputInfo.Controls.Add(this.cbIncludeIdentic);
            this.gbImageInputInfo.Controls.Add(this.lblInputName);
            this.gbImageInputInfo.Controls.Add(this.lblFaceDetection);
            this.gbImageInputInfo.Controls.Add(this.lblAlgorithm);
            this.gbImageInputInfo.Controls.Add(this.lblTotDir);
            this.gbImageInputInfo.Controls.Add(this.lblNumOutputImages);
            this.gbImageInputInfo.Controls.Add(this.pbInput);
            this.gbImageInputInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbImageInputInfo.Location = new System.Drawing.Point(12, 12);
            this.gbImageInputInfo.Name = "gbImageInputInfo";
            this.gbImageInputInfo.Size = new System.Drawing.Size(355, 670);
            this.gbImageInputInfo.TabIndex = 0;
            this.gbImageInputInfo.TabStop = false;
            this.gbImageInputInfo.Text = "Immagine in input e informazioni varie";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(134, 626);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(141, 13);
            this.lblProgress.TabIndex = 12;
            this.lblProgress.Text = "Nessun operazione in corso.";
            this.lblProgress.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.btnSaveResults);
            this.panel2.Location = new System.Drawing.Point(6, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 40);
            this.panel2.TabIndex = 9;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSaveResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveResults.Enabled = false;
            this.btnSaveResults.FlatAppearance.BorderSize = 0;
            this.btnSaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSaveResults.Location = new System.Drawing.Point(0, 0);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(119, 40);
            this.btnSaveResults.TabIndex = 9;
            this.btnSaveResults.Text = "Salva Risultati";
            this.btnSaveResults.UseVisualStyleBackColor = false;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // panelCompare
            // 
            this.panelCompare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelCompare.Controls.Add(this.btnCompare);
            this.panelCompare.Location = new System.Drawing.Point(6, 483);
            this.panelCompare.Name = "panelCompare";
            this.panelCompare.Size = new System.Drawing.Size(343, 40);
            this.panelCompare.TabIndex = 8;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCompare.Location = new System.Drawing.Point(0, 0);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(343, 40);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Confronta";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // panelImageDir
            // 
            this.panelImageDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelImageDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelImageDir.Controls.Add(this.btnChooseDir);
            this.panelImageDir.Location = new System.Drawing.Point(189, 25);
            this.panelImageDir.Name = "panelImageDir";
            this.panelImageDir.Size = new System.Drawing.Size(160, 40);
            this.panelImageDir.TabIndex = 8;
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnChooseDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseDir.FlatAppearance.BorderSize = 0;
            this.btnChooseDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnChooseDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnChooseDir.Location = new System.Drawing.Point(0, 0);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(160, 40);
            this.btnChooseDir.TabIndex = 9;
            this.btnChooseDir.Text = "Scegli Archivio";
            this.btnChooseDir.UseVisualStyleBackColor = false;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // panelImageInput
            // 
            this.panelImageInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelImageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelImageInput.Controls.Add(this.btnChooseInputImage);
            this.panelImageInput.Location = new System.Drawing.Point(6, 25);
            this.panelImageInput.Name = "panelImageInput";
            this.panelImageInput.Size = new System.Drawing.Size(160, 40);
            this.panelImageInput.TabIndex = 7;
            // 
            // btnChooseInputImage
            // 
            this.btnChooseInputImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnChooseInputImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseInputImage.FlatAppearance.BorderSize = 0;
            this.btnChooseInputImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseInputImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnChooseInputImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnChooseInputImage.Location = new System.Drawing.Point(0, 0);
            this.btnChooseInputImage.Name = "btnChooseInputImage";
            this.btnChooseInputImage.Size = new System.Drawing.Size(160, 40);
            this.btnChooseInputImage.TabIndex = 9;
            this.btnChooseInputImage.Text = "Scegli Immagine di Input";
            this.btnChooseInputImage.UseVisualStyleBackColor = false;
            this.btnChooseInputImage.Click += new System.EventHandler(this.btnChooseInputImage_Click);
            // 
            // cbIncludeIdentic
            // 
            this.cbIncludeIdentic.AutoSize = true;
            this.cbIncludeIdentic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbIncludeIdentic.Location = new System.Drawing.Point(9, 541);
            this.cbIncludeIdentic.Name = "cbIncludeIdentic";
            this.cbIncludeIdentic.Size = new System.Drawing.Size(149, 17);
            this.cbIncludeIdentic.TabIndex = 11;
            this.cbIncludeIdentic.Text = "Escludi immagini identiche";
            this.cbIncludeIdentic.UseVisualStyleBackColor = true;
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblInputName.Location = new System.Drawing.Point(6, 89);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(282, 13);
            this.lblInputName.TabIndex = 10;
            this.lblInputName.Text = "Immagine scelta per l\'input: Nessuna immagine selezionata";
            // 
            // lblFaceDetection
            // 
            this.lblFaceDetection.AutoSize = true;
            this.lblFaceDetection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFaceDetection.Location = new System.Drawing.Point(6, 443);
            this.lblFaceDetection.Name = "lblFaceDetection";
            this.lblFaceDetection.Size = new System.Drawing.Size(148, 13);
            this.lblFaceDetection.TabIndex = 9;
            this.lblFaceDetection.Text = "  - Utilizzo Face Detection: {0}";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAlgorithm.Location = new System.Drawing.Point(6, 420);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(249, 13);
            this.lblAlgorithm.TabIndex = 7;
            this.lblAlgorithm.Text = "L\'algoritmo richiesto per effettuare il confronto è: {0}";
            // 
            // lblTotDir
            // 
            this.lblTotDir.AutoSize = true;
            this.lblTotDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTotDir.Location = new System.Drawing.Point(6, 374);
            this.lblTotDir.Name = "lblTotDir";
            this.lblTotDir.Size = new System.Drawing.Size(269, 13);
            this.lblTotDir.TabIndex = 0;
            this.lblTotDir.Text = "In totale l\'archivio contiene: nessun archivio selezionato";
            // 
            // lblNumOutputImages
            // 
            this.lblNumOutputImages.AutoSize = true;
            this.lblNumOutputImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblNumOutputImages.Location = new System.Drawing.Point(6, 397);
            this.lblNumOutputImages.Name = "lblNumOutputImages";
            this.lblNumOutputImages.Size = new System.Drawing.Size(193, 13);
            this.lblNumOutputImages.TabIndex = 5;
            this.lblNumOutputImages.Text = "Numero immagini richieste in output: {0}";
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.InitialImage = null;
            this.pbInput.Location = new System.Drawing.Point(6, 109);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(343, 250);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInput.TabIndex = 2;
            this.pbInput.TabStop = false;
            // 
            // panelImageOutput
            // 
            this.panelImageOutput.Location = new System.Drawing.Point(373, 12);
            this.panelImageOutput.Name = "panelImageOutput";
            this.panelImageOutput.Size = new System.Drawing.Size(850, 670);
            this.panelImageOutput.TabIndex = 10;
            // 
            // panelHideScroll
            // 
            this.panelHideScroll.Location = new System.Drawing.Point(1202, 0);
            this.panelHideScroll.Name = "panelHideScroll";
            this.panelHideScroll.Size = new System.Drawing.Size(33, 695);
            this.panelHideScroll.TabIndex = 11;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.panelHideScroll);
            this.Controls.Add(this.panelImageOutput);
            this.Controls.Add(this.gbImageInputInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.gbImageInputInfo.ResumeLayout(false);
            this.gbImageInputInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelCompare.ResumeLayout(false);
            this.panelImageDir.ResumeLayout(false);
            this.panelImageInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTotDir;
        public System.Windows.Forms.Label lblNumOutputImages;
        public System.Windows.Forms.Label lblAlgorithm;
        public System.Windows.Forms.PictureBox pbInput;
        public System.Windows.Forms.Label lblFaceDetection;
        public System.Windows.Forms.Label lblInputName;
        public System.Windows.Forms.GroupBox gbImageInputInfo;
        public System.Windows.Forms.CheckBox cbIncludeIdentic;
        private System.Windows.Forms.Panel panelImageDir;
        public System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.Panel panelImageInput;
        public System.Windows.Forms.Button btnChooseInputImage;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Panel panelCompare;
        public System.Windows.Forms.Button btnCompare;
        public System.Windows.Forms.Panel panelImageOutput;
        private System.Windows.Forms.Panel panelHideScroll;
        public System.Windows.Forms.Label lblProgress;
    }
}