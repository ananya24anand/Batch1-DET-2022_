using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Emp
    {
        public DateTime Doj;
        int id;
        string name;
        string dept;
        double sal;
        //DateTime doj;
        public DateTime doj { get; set; }
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
