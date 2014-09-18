using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAIDCalculation
    {
        public RAIDCalculation()
        {

        }

        public RAIDCalculation(int numberOfDisks, double sizeOfSingleDisk, double usableStorageSpace, String usedRAIDLevel)
        {

        }

        private int numberOfDisks;
        private double sizeOfSingleDisk;
        private double usableStorageSpace;
        private String usedRAIDLevel;

        public int NumberOfDisks
        {
            get { return numberOfDisks; }
        }

        
        public double SizeOfSingleDisk
        {
            get { return sizeOfSingleDisk; }
        }


        public double UsableStorageSpace
        {
            get { return usableStorageSpace; }
        } 
        
        public String UsedRAIDLevel
        {
            get { return usedRAIDLevel; }
        }
    }
}
