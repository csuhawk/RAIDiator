using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID0 : RAIDLevel
    {
       
       override public double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
       {
            return numberOfDisks * sizeOfSingleDisk;
       }
    }
}
