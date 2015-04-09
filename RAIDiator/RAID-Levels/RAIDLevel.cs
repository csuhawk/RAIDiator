using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    /// <summary>
    /// Represents a RAIDLevel
    /// </summary>
    abstract class RAIDLevel
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RAIDLevel()
        {

        }

        /// <summary>
        /// List of all RAIDLevels
        /// </summary>
        static public List<RAIDLevel> RAIDLevels = new List<RAIDLevel>();

        /// <summary>
        /// Minimal number of HDDs
        /// </summary>
        protected int minHDD;

        /// <summary>
        /// Name of the RAID-Level
        /// </summary>
        protected String name;

        /// <summary>
        /// Name of the RAID-Level
        /// </summary>
        public String Name
        {
            get { return name; }
        }

        /// <summary>
        /// Minimal number of HDDs
        /// </summary>
        public int MinHDD 
        {
            get { return minHDD; }
        }

        /// <summary>
        /// Calculates how many HDD-Space is usable
        /// </summary>
        /// <returns></returns>
        abstract public double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk);
        abstract public double calcUnusableDiskSpace(int numberOfDisks, double sizeOfSingleDisk);

        /// <summary>
        /// Override the toString Methode so that is returns the name of the RAID Level.
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return name;
        }

        static public void initAllRAIDLevels()
        {
            // Add all RAID Levels
            RAIDLevel.RAIDLevels.Add(new RAID0());
            RAIDLevel.RAIDLevels.Add(new RAID1());
            RAIDLevel.RAIDLevels.Add(new RAID3());
            RAIDLevel.RAIDLevels.Add(new RAID5());
            RAIDLevel.RAIDLevels.Add(new RAID6());
            RAIDLevel.RAIDLevels.Add(new RAID10());
        }
    }
}
