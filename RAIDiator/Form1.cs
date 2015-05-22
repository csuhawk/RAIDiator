using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RAIDiator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RAIDLevel.initAllRAIDLevels();

            // Add all RAID Levels from List to cmbBox
            foreach (RAIDLevel currentRAIDLevel in RAIDLevel.RAIDLevels)
            {
                cmbRAIDLevels.Items.Add(currentRAIDLevel);
            }  

            // Set Default Raid Level0
            cmbRAIDLevels.SelectedItem = RAIDLevel.RAIDLevels.Find(item => item.ToString() == "RAID0");
 
        }

        // Is called when the cmBox selction is changed
        private void cmbRAIDLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int minHDD = 0;
            String rlevelName = cmbRAIDLevels.SelectedItem.ToString();
            switch (rlevelName)
            {
                default:
                    break;

                case "RAID0":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID0;
                    break;

                case "RAID1":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID1;
                    break;

                case "RAID3":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID3;
                    break;

                case "RAID5":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID5;
                    break;

                case "RAID6":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID6;
                    break;

                case "RAID10":
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID10;
                    break;
            }

            // Sets required Disks and current value of cmbox to the same number
            minHDD = RAIDLevel.RAIDLevels.Find(item => item.ToString() == rlevelName).MinHDD;

            // Sets minimal HDD 
            numUpDoNumberOfDisks.Minimum = minHDD;
            if (numUpDoNumberOfDisks.Value < minHDD)
            {
                numUpDoNumberOfDisks.Value = numUpDoNumberOfDisks.Minimum;
            }

            // Recalculate Space
            calcSpace();

        }

        // Calculates the usable Space of the current Configuration
        private void calcSpace()
        {
            if (cmbRAIDLevels.SelectedIndex > -1)
            {
                String currentRAIDLevel = cmbRAIDLevels.SelectedItem.ToString();
                // Calc Space
                RAIDLevel rlevel = RAIDLevel.RAIDLevels.Find(item => item.ToString() == currentRAIDLevel);
                txtUsableSpace.Text = rlevel.calcUsableDiskSpace(Convert.ToInt32(numUpDoNumberOfDisks.Value), Convert.ToDouble(numUpDoDiskSize.Value)).ToString();
                txtUnusableSpace.Text = rlevel.calcUnusableDiskSpace(Convert.ToInt32(numUpDoNumberOfDisks.Value), Convert.ToDouble(numUpDoDiskSize.Value)).ToString();
                // Generate ChartData
                Series ser = SpaceChart.Series.FindByName("UsedVSUnusedSpace");
                ser.Points.Clear();                       // clear DataPoints
                ser.Points.AddY(txtUsableSpace.Text);     // Sets usable Space
                ser.Points.AddY(txtUnusableSpace.Text);   // Sets unusable space    
                // Set Color for Datapoints
                ser.Points[0].Color = Color.FromArgb(128, 255, 128); //Greenish
                ser.Points[1].Color = Color.FromArgb(255, 128, 128); // Redish
                // Set Legend for Datapoints
                ser.Points[0].LegendText = "Usable";
                ser.Points[1].LegendText = "Unusable";
            }
        }

        private void numUpDoNumberOfDisks_ValueChanged(object sender, EventArgs e)
        {
            // Recalculate Space
            calcSpace();
        }

        private void numUpDoDiskSize_ValueChanged(object sender, EventArgs e)
        {
            // Recalculate Space
            calcSpace();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Show About dialog
            using(AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }

        }

    }
}
