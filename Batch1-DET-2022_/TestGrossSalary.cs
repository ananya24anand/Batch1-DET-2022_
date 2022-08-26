using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class TestGrossSalary
    {
        public static void Main()
        {
            grossSalary g = new grossSalary(21, "Ananya", "Bangalore", 78, 1234567890, 40000);
            Console.WriteLine($"Grade is : {g.grade()}");
        }
    }
}
