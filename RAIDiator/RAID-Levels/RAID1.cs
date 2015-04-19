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
        }

        public override double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return ((numberOfDisks - numberOfDisks % 2) * sizeOfSingleDisk) / 2;
        }

    }
}
