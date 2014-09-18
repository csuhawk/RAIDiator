using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID0 : RAIDLevel
    {
        public RAID0()
        {
            minHDD = 2;
            name = "RAID-0";
        }
       
       override public double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
       {
            return numberOfDisks * sizeOfSingleDisk;
       }
    }
}
