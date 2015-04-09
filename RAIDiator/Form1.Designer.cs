namespace RAIDiator
{
    partial class Form1
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
            this.cmbRAIDLevels = new System.Windows.Forms.ComboBox();
            this.lblRAIDLevel = new System.Windows.Forms.Label();
            this.lblNumberOfDisks = new System.Windows.Forms.Label();
            this.numUpDoNumberOfDisks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDoDiskSize = new System.Windows.Forms.NumericUpDown();
            this.lblUsableSpace = new System.Windows.Forms.Label();
            this.txtUsableSpace = new System.Windows.Forms.TextBox();
            this.btnCalcSpace = new System.Windows.Forms.Button();
            this.pBoxRAIDLevel = new System.Windows.Forms.PictureBox();
            this.lblUnusableSpace = new System.Windows.Forms.Label();
            this.txtUnusableSpace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoNumberOfDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoDiskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRAIDLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRAIDLevels
            // 
            this.cmbRAIDLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAIDLevels.FormattingEnabled = true;
            this.cmbRAIDLevels.Location = new System.Drawing.Point(115, 10);
            this.cmbRAIDLevels.Name = "cmbRAIDLevels";
            this.cmbRAIDLevels.Size = new System.Drawing.Size(121, 21);
            this.cmbRAIDLevels.TabIndex = 0;
            this.cmbRAIDLevels.SelectedIndexChanged += new System.EventHandler(this.cmbRAIDLevels_SelectedIndexChanged);
            // 
            // lblRAIDLevel
            // 
            this.lblRAIDLevel.AutoSize = true;
            this.lblRAIDLevel.Location = new System.Drawing.Point(13, 13);
            this.lblRAIDLevel.Name = "lblRAIDLevel";
            this.lblRAIDLevel.Size = new System.Drawing.Size(62, 13);
            this.lblRAIDLevel.TabIndex = 1;
            this.lblRAIDLevel.Text = "RAID-Level";
            // 
            // lblNumberOfDisks
            // 
            this.lblNumberOfDisks.AutoSize = true;
            this.lblNumberOfDisks.Location = new System.Drawing.Point(13, 40);
            this.lblNumberOfDisks.Name = "lblNumberOfDisks";
            this.lblNumberOfDisks.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfDisks.TabIndex = 2;
            this.lblNumberOfDisks.Text = "Number of disks";
            // 
            // numUpDoNumberOfDisks
            // 
            this.numUpDoNumberOfDisks.Location = new System.Drawing.Point(116, 38);
            this.numUpDoNumberOfDisks.Name = "numUpDoNumberOfDisks";
            this.numUpDoNumberOfDisks.Size = new System.Drawing.Size(120, 20);
            this.numUpDoNumberOfDisks.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Disk size ( in GB)";
            // 
            // numUpDoDiskSize
            // 
            this.numUpDoDiskSize.DecimalPlaces = 2;
            this.numUpDoDiskSize.Location = new System.Drawing.Point(116, 64);
            this.numUpDoDiskSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDoDiskSize.Name = "numUpDoDiskSize";
            this.numUpDoDiskSize.Size = new System.Drawing.Size(120, 20);
            this.numUpDoDiskSize.TabIndex = 5;
            // 
            // lblUsableSpace
            // 
            this.lblUsableSpace.AutoSize = true;
            this.lblUsableSpace.Location = new System.Drawing.Point(2, 120);
            this.lblUsableSpace.Name = "lblUsableSpace";
            this.lblUsableSpace.Size = new System.Drawing.Size(98, 13);
            this.lblUsableSpace.TabIndex = 6;
            this.lblUsableSpace.Text = "Usable Disk Space";
            // 
            // txtUsableSpace
            // 
            this.txtUsableSpace.BackColor = System.Drawing.SystemColors.Info;
            this.txtUsableSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsableSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUsableSpace.Location = new System.Drawing.Point(115, 117);
            this.txtUsableSpace.Name = "txtUsableSpace";
            this.txtUsableSpace.ReadOnly = true;
            this.txtUsableSpace.Size = new System.Drawing.Size(120, 20);
            this.txtUsableSpace.TabIndex = 8;
            // 
            // btnCalcSpace
            // 
            this.btnCalcSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSpace.Location = new System.Drawing.Point(116, 88);
            this.btnCalcSpace.Name = "btnCalcSpace";
            this.btnCalcSpace.Size = new System.Drawing.Size(119, 23);
            this.btnCalcSpace.TabIndex = 9;
            this.btnCalcSpace.Text = "Calculate Space";
            this.btnCalcSpace.UseVisualStyleBackColor = true;
            this.btnCalcSpace.Click += new System.EventHandler(this.btnCalcSpace_Click);
            // 
            // pBoxRAIDLevel
            // 
            this.pBoxRAIDLevel.Location = new System.Drawing.Point(242, 10);
            this.pBoxRAIDLevel.Name = "pBoxRAIDLevel";
            this.pBoxRAIDLevel.Size = new System.Drawing.Size(169, 127);
            this.pBoxRAIDLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxRAIDLevel.TabIndex = 10;
            this.pBoxRAIDLevel.TabStop = false;
            // 
            // lblUnusableSpace
            // 
            this.lblUnusableSpace.AutoSize = true;
            this.lblUnusableSpace.Location = new System.Drawing.Point(2, 148);
            this.lblUnusableSpace.Name = "lblUnusableSpace";
            this.lblUnusableSpace.Size = new System.Drawing.Size(110, 13);
            this.lblUnusableSpace.TabIndex = 11;
            this.lblUnusableSpace.Text = "Unusable Disk Space";
            // 
            // txtUnusableSpace
            // 
            this.txtUnusableSpace.BackColor = System.Drawing.SystemColors.Info;
            this.txtUnusableSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnusableSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUnusableSpace.Location = new System.Drawing.Point(115, 145);
            this.txtUnusableSpace.Name = "txtUnusableSpace";
            this.txtUnusableSpace.ReadOnly = true;
            this.txtUnusableSpace.Size = new System.Drawing.Size(120, 20);
            this.txtUnusableSpace.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 170);
            this.Controls.Add(this.txtUnusableSpace);
            this.Controls.Add(this.lblUnusableSpace);
            this.Controls.Add(this.pBoxRAIDLevel);
            this.Controls.Add(this.btnCalcSpace);
            this.Controls.Add(this.txtUsableSpace);
            this.Controls.Add(this.lblUsableSpace);
            this.Controls.Add(this.numUpDoDiskSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDoNumberOfDisks);
            this.Controls.Add(this.lblNumberOfDisks);
            this.Controls.Add(this.lblRAIDLevel);
            this.Controls.Add(this.cmbRAIDLevels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "RAIDiator";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoNumberOfDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoDiskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRAIDLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRAIDLevels;
        private System.Windows.Forms.Label lblRAIDLevel;
        private System.Windows.Forms.Label lblNumberOfDisks;
        private System.Windows.Forms.NumericUpDown numUpDoNumberOfDisks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDoDiskSize;
        private System.Windows.Forms.Label lblUsableSpace;
        private System.Windows.Forms.TextBox txtUsableSpace;
        private System.Windows.Forms.Button btnCalcSpace;
        private System.Windows.Forms.PictureBox pBoxRAIDLevel;
        private System.Windows.Forms.Label lblUnusableSpace;
        private System.Windows.Forms.TextBox txtUnusableSpace;

    }
}

