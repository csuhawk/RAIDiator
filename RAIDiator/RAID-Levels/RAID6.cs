using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID6 : RAIDLevel
    {
        public  RAID6()
        {
            minHDD = 4;
        }

        public override double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return (numberOfDisks - 2) * sizeOfSingleDisk;
        }
    }
}
