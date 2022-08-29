using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    public class Commerce:Students
    {
        public int economics { get; set; }
        public int accounts { get; set; }
        public int banking { get; set; }

        public override double GetAvgMarks()
        {
            return (economics + accounts + banking) / 3;
        }
    }
}
    

