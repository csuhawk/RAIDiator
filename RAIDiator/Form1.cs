using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
 
        }

        // Is called when the cmBox selction is changed
        private void cmbRAIDLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int minHDD = 0;
            switch (cmbRAIDLevels.SelectedItem.ToString())
            {
                default:
                    break;

                case "RAID-0":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-0").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID0;
                    break;

                case "RAID-1":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-1").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID1;
                    break;

                case "RAID-3":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-3").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID3;
                    break;

                case "RAID-5":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-5").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID5;
                    break;

                case "RAID-6":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-6").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID6;
                    break;

                case "RAID-10":
                    // Sets required Disks and current value of cmbox to the same number
                    minHDD = RAIDLevel.RAIDLevels.Find(item => item.Name == "RAID-10").MinHDD;
                    // Sets Image of RAID Level
                    pBoxRAIDLevel.Image = RAIDiator.Properties.Resources.RAID10;
                    break;
            }

            // Sets minimal HDD 
            numUpDoNumberOfDisks.Minimum = minHDD;
            numUpDoNumberOfDisks.Value = minHDD;
        }

        // Calculates the usable Space of the current Configuration
        private void btnCalcSpace_Click(object sender, EventArgs e)
        {
            if (cmbRAIDLevels.SelectedIndex > -1)
            {
                String currentRAIDLevel = cmbRAIDLevels.SelectedItem.ToString();
                // Calc Space
                txtUsableSpace.Text = RAIDLevel.RAIDLevels.Find(item => item.Name == currentRAIDLevel).calcUsableDiskSpace(Convert.ToInt16(numUpDoNumberOfDisks.Value), Convert.ToDouble(numUpDoDiskSize.Value)).ToString();
                txtUnusableSpace.Text = RAIDLevel.RAIDLevels.Find(item => item.Name == currentRAIDLevel).calcUnusableDiskSpace(Convert.ToInt16(numUpDoNumberOfDisks.Value), Convert.ToDouble(numUpDoDiskSize.Value)).ToString();
            }
        }

    }
}
