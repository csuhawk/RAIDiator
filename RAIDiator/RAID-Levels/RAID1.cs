using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID1 : RAIDLevel
    {
        public RAID1()
        {
            minHDD = 2;
            name = "RAID-1";
        }

        public override double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return ((numberOfDisks - numberOfDisks % 2) * sizeOfSingleDisk) / 2;
        }

        public override double calcUnusableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return ((numberOfDisks % 2) * sizeOfSingleDisk);
        }
    }
}
