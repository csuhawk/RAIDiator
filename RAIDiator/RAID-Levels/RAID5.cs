﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIDiator
{
    class RAID5 : RAIDLevel
    {
        public RAID5()
        {
            minHDD = 3;
        }

        public override double calcUsableDiskSpace(int numberOfDisks, double sizeOfSingleDisk)
        {
            return (numberOfDisks - 1) * sizeOfSingleDisk;
        }
    }
}
