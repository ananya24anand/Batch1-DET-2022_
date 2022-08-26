using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class circle
    {
        int r;

        public circle(int r)
        {
            this.r = r;
        }
        public double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
