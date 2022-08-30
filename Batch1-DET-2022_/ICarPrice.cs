using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal interface ICarPrice
    {
        int GetPrice(string name);
    }

    class BMW : ICarPrice
    {
        public string Name { get; set; }
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 13000000;
            else if (name == "X7")
                return 1000000;
            else
                return 9000000;
        }

    }

    class Hundai : ICarPrice
    {
        public string Name { get; set; }
        public int GetPrice(string name)
        {
            if (name == "Creta")
                return 1000000;
            else if (name == "tucson")
                return 2500000;
            else
                return 1000000;
        }
    }

    class TestICar
    {
        public static void Main()
        {
            BMW a = new BMW { Name = "bmw" };
            Hundai sa = new Hundai { Name = "hundai" };

            Console.WriteLine(a.GetPrice("M3"));

            Console.WriteLine(sa.GetPrice("santro"));
        }
    }
}
