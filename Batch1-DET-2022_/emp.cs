using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    internal class emp
    {
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public emp(int eid, string ename, DateOnly doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }
    }
}
