﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    public abstract class Students
    {
        public int regno { get; set; }
        public string Name { get; set; }
        public abstract double GetAvgMarks();

    }


}
