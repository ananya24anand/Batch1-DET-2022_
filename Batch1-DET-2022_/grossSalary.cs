using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class grossSalary
    {
        int empno;
        string name;
        string address;
        int pin;
        int phone;
        int grossalary;
        int pf;

        public grossSalary(int empno, string name, string address, int pin, int phone, int grossalary)
        {
            this.empno = empno;
            this.name = name;
            this.address = address;
            this.pin = pin;
            this.phone = phone;
            this.grossalary = grossalary;
        }
        public char grade()
        {
            pf = 12 * grossalary / 100;
            int netsal = grossalary - pf;
            if (netsal > 10000)
                return 'A';
            else if (netsal > 5000)
                return 'B';
            else
                return 'C';
        }
    }
}
