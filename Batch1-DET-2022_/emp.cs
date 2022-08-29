using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    public class Emp
    {
        int id;
        string name;
        string dept;
        double sal;
        DateTime doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Emp(int eid, string ename, DateTime doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public virtual string Print()
        {
            return $"Emp Id = {id}, Name = {name}, Experience = {GetYearsofExp()} years";
        }
    }
}
