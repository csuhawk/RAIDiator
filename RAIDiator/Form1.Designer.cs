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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbRAIDLevels = new System.Windows.Forms.ComboBox();
            this.lblRAIDLevel = new System.Windows.Forms.Label();
            this.lblNumberOfDisks = new System.Windows.Forms.Label();
            this.numUpDoNumberOfDisks = new System.Windows.Forms.NumericUpDown();
            this.lblDiskSize = new System.Windows.Forms.Label();
            this.numUpDoDiskSize = new System.Windows.Forms.NumericUpDown();
            this.lblUsableSpace = new System.Windows.Forms.Label();
            this.txtUsableSpace = new System.Windows.Forms.TextBox();
            this.btnCalcSpace = new System.Windows.Forms.Button();
            this.pBoxRAIDLevel = new System.Windows.Forms.PictureBox();
            this.lblUnusableSpace = new System.Windows.Forms.Label();
            this.txtUnusableSpace = new System.Windows.Forms.TextBox();
            this.SpaceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGBDiskSize = new System.Windows.Forms.Label();
            this.lblGBUsableSpace = new System.Windows.Forms.Label();
            this.lblGBUnusableSpace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoNumberOfDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoDiskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRAIDLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRAIDLevels
            // 
            this.cmbRAIDLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAIDLevels.FormattingEnabled = true;
            this.cmbRAIDLevels.Location = new System.Drawing.Point(81, 10);
            this.cmbRAIDLevels.Name = "cmbRAIDLevels";
            this.cmbRAIDLevels.Size = new System.Drawing.Size(155, 21);
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
            this.lblNumberOfDisks.Location = new System.Drawing.Point(13, 37);
            this.lblNumberOfDisks.Name = "lblNumberOfDisks";
            this.lblNumberOfDisks.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfDisks.TabIndex = 2;
            this.lblNumberOfDisks.Text = "Number of disks";
            // 
            // numUpDoNumberOfDisks
            // 
            this.numUpDoNumberOfDisks.Location = new System.Drawing.Point(16, 54);
            this.numUpDoNumberOfDisks.Name = "numUpDoNumberOfDisks";
            this.numUpDoNumberOfDisks.Size = new System.Drawing.Size(120, 20);
            this.numUpDoNumberOfDisks.TabIndex = 3;
            // 
            // lblDiskSize
            // 
            this.lblDiskSize.AutoSize = true;
            this.lblDiskSize.Location = new System.Drawing.Point(13, 76);
            this.lblDiskSize.Name = "lblDiskSize";
            this.lblDiskSize.Size = new System.Drawing.Size(49, 13);
            this.lblDiskSize.TabIndex = 4;
            this.lblDiskSize.Text = "Disk size";
            // 
            // numUpDoDiskSize
            // 
            this.numUpDoDiskSize.DecimalPlaces = 2;
            this.numUpDoDiskSize.Location = new System.Drawing.Point(16, 92);
            this.numUpDoDiskSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDoDiskSize.Name = "numUpDoDiskSize";
            this.numUpDoDiskSize.Size = new System.Drawing.Size(85, 20);
            this.numUpDoDiskSize.TabIndex = 5;
            // 
            // lblUsableSpace
            // 
            this.lblUsableSpace.AutoSize = true;
            this.lblUsableSpace.Location = new System.Drawing.Point(289, 37);
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
            this.txtUsableSpace.Location = new System.Drawing.Point(289, 53);
            this.txtUsableSpace.Name = "txtUsableSpace";
            this.txtUsableSpace.ReadOnly = true;
            this.txtUsableSpace.Size = new System.Drawing.Size(120, 20);
            this.txtUsableSpace.TabIndex = 8;
            // 
            // btnCalcSpace
            // 
            this.btnCalcSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSpace.Location = new System.Drawing.Point(289, 10);
            this.btnCalcSpace.Name = "btnCalcSpace";
            this.btnCalcSpace.Size = new System.Drawing.Size(265, 23);
            this.btnCalcSpace.TabIndex = 9;
            this.btnCalcSpace.Text = "Calculate Space";
            this.btnCalcSpace.UseVisualStyleBackColor = true;
            this.btnCalcSpace.Click += new System.EventHandler(this.btnCalcSpace_Click);
            // 
            // pBoxRAIDLevel
            // 
            this.pBoxRAIDLevel.Location = new System.Drawing.Point(12, 117);
            this.pBoxRAIDLevel.Name = "pBoxRAIDLevel";
            this.pBoxRAIDLevel.Size = new System.Drawing.Size(265, 203);
            this.pBoxRAIDLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxRAIDLevel.TabIndex = 10;
            this.pBoxRAIDLevel.TabStop = false;
            // 
            // lblUnusableSpace
            // 
            this.lblUnusableSpace.AutoSize = true;
            this.lblUnusableSpace.Location = new System.Drawing.Point(289, 76);
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
            this.txtUnusableSpace.Location = new System.Drawing.Point(289, 92);
            this.txtUnusableSpace.Name = "txtUnusableSpace";
            this.txtUnusableSpace.ReadOnly = true;
            this.txtUnusableSpace.Size = new System.Drawing.Size(120, 20);
            this.txtUnusableSpace.TabIndex = 12;
            // 
            // SpaceChart
            // 
            this.SpaceChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin5;
            chartArea1.Name = "ChartAreaSpace";
            this.SpaceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SpaceChart.Legends.Add(legend1);
            this.SpaceChart.Location = new System.Drawing.Point(289, 117);
            this.SpaceChart.Name = "SpaceChart";
            this.SpaceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartAreaSpace";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "UsedVSUnusedSpace";
            this.SpaceChart.Series.Add(series1);
            this.SpaceChart.Size = new System.Drawing.Size(265, 204);
            this.SpaceChart.TabIndex = 13;
            this.SpaceChart.Text = "Space Charts";
            // 
            // lblGBDiskSize
            // 
            this.lblGBDiskSize.AutoSize = true;
            this.lblGBDiskSize.Location = new System.Drawing.Point(107, 95);
            this.lblGBDiskSize.Name = "lblGBDiskSize";
            this.lblGBDiskSize.Size = new System.Drawing.Size(36, 13);
            this.lblGBDiskSize.TabIndex = 14;
            this.lblGBDiskSize.Text = "GByte";
            // 
            // lblGBUsableSpace
            // 
            this.lblGBUsableSpace.AutoSize = true;
            this.lblGBUsableSpace.Location = new System.Drawing.Point(415, 56);
            this.lblGBUsableSpace.Name = "lblGBUsableSpace";
            this.lblGBUsableSpace.Size = new System.Drawing.Size(36, 13);
            this.lblGBUsableSpace.TabIndex = 15;
            this.lblGBUsableSpace.Text = "GByte";
            // 
            // lblGBUnusableSpace
            // 
            this.lblGBUnusableSpace.AutoSize = true;
            this.lblGBUnusableSpace.Location = new System.Drawing.Point(415, 95);
            this.lblGBUnusableSpace.Name = "lblGBUnusableSpace";
            this.lblGBUnusableSpace.Size = new System.Drawing.Size(36, 13);
            this.lblGBUnusableSpace.TabIndex = 16;
            this.lblGBUnusableSpace.Text = "GByte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.Controls.Add(this.lblGBUnusableSpace);
            this.Controls.Add(this.lblGBUsableSpace);
            this.Controls.Add(this.lblGBDiskSize);
            this.Controls.Add(this.SpaceChart);
            this.Controls.Add(this.txtUnusableSpace);
            this.Controls.Add(this.lblUnusableSpace);
            this.Controls.Add(this.pBoxRAIDLevel);
            this.Controls.Add(this.btnCalcSpace);
            this.Controls.Add(this.txtUsableSpace);
            this.Controls.Add(this.lblUsableSpace);
            this.Controls.Add(this.numUpDoDiskSize);
            this.Controls.Add(this.lblDiskSize);
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
            ((System.ComponentModel.ISupportInitialize)(this.SpaceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRAIDLevels;
        private System.Windows.Forms.Label lblRAIDLevel;
        private System.Windows.Forms.Label lblNumberOfDisks;
        private System.Windows.Forms.NumericUpDown numUpDoNumberOfDisks;
        private System.Windows.Forms.Label lblDiskSize;
        private System.Windows.Forms.NumericUpDown numUpDoDiskSize;
        private System.Windows.Forms.Label lblUsableSpace;
        private System.Windows.Forms.TextBox txtUsableSpace;
        private System.Windows.Forms.Button btnCalcSpace;
        private System.Windows.Forms.PictureBox pBoxRAIDLevel;
        private System.Windows.Forms.Label lblUnusableSpace;
        private System.Windows.Forms.TextBox txtUnusableSpace;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpaceChart;
        private System.Windows.Forms.Label lblGBDiskSize;
        private System.Windows.Forms.Label lblGBUsableSpace;
        private System.Windows.Forms.Label lblGBUnusableSpace;

    }
}

