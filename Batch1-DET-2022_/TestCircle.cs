using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class TestCircle
    {
        public static void Main()
        {
            circle c = new circle(10);
            Console.WriteLine($"Area of cirlcle={c.GetArea()}");
        }
    }
}
