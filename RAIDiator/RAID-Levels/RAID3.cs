using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID3 : RAIDLevel
    {
        public RAID3()
        {
            minHDD = 3;
        }

        public override double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return (numberOfDisks - 1) * sizeOfSingleDisk; 
        }
    }
}
