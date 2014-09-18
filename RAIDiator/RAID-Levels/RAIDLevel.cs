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
    }
}
