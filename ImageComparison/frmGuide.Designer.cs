
namespace ImageComparison
{
    partial class frmGuide
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGuide = new System.Windows.Forms.DataGridView();
            this.dgvColAlg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTypeImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuide
            // 
            this.dgvGuide.AllowUserToAddRows = false;
            this.dgvGuide.AllowUserToDeleteRows = false;
            this.dgvGuide.AllowUserToResizeColumns = false;
            this.dgvGuide.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuide.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuide.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColAlg,
            this.DgvColFunc,
            this.dgvColTypeImage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuide.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuide.Location = new System.Drawing.Point(12, 12);
            this.dgvGuide.MultiSelect = false;
            this.dgvGuide.Name = "dgvGuide";
            this.dgvGuide.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuide.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuide.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGuide.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuide.RowTemplate.Height = 125;
            this.dgvGuide.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvGuide.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuide.Size = new System.Drawing.Size(1200, 650);
            this.dgvGuide.TabIndex = 0;
            // 
            // dgvColAlg
            // 
            this.dgvColAlg.HeaderText = "Algorithm:";
            this.dgvColAlg.MinimumWidth = 205;
            this.dgvColAlg.Name = "dgvColAlg";
            this.dgvColAlg.ReadOnly = true;
            this.dgvColAlg.Width = 205;
            // 
            // DgvColFunc
            // 
            this.DgvColFunc.HeaderText = "How:";
            this.DgvColFunc.MinimumWidth = 650;
            this.DgvColFunc.Name = "DgvColFunc";
            this.DgvColFunc.ReadOnly = true;
            this.DgvColFunc.Width = 650;
            // 
            // dgvColTypeImage
            // 
            this.dgvColTypeImage.HeaderText = "Where:";
            this.dgvColTypeImage.MinimumWidth = 300;
            this.dgvColTypeImage.Name = "dgvColTypeImage";
            this.dgvColTypeImage.ReadOnly = true;
            this.dgvColTypeImage.Width = 300;
            // 
            // frmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.dgvGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuide";
            this.Text = "frmGuide";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvGuide;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTypeImage;
    }
}