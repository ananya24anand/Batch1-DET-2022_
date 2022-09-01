using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    public class EmployeeLinq
    {
        
            public EmployeeLinq()
            {

            }

            public EmployeeLinq(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }
            public int ID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

        private static List<EmployeeLinq> GetListofEmployees()
        {
            List<EmployeeLinq> emps = new List<EmployeeLinq>();
            emps.Add(new EmployeeLinq(1, "John", "Training")); 
            emps.Add(new EmployeeLinq(2, "Mark", "Finance"));
            emps.Add(new EmployeeLinq(3, "Peter", "Technical"));
            emps.Add(new EmployeeLinq(4, "Bob", "Technical"));
            emps.Add(new EmployeeLinq(5, "Robert", "Finance"));
            emps.Add(new EmployeeLinq(6, "Jason", "Training"));

            return emps;
        }

        private static void SampleEmployeeList()
        {
            List<EmployeeLinq> emps= GetListofEmployees();
            var emp_query = from employee in emps
                            select employee;

            foreach (var item in emp_query)
            {
                Console.WriteLine("Name is "+item.Name+"and dept is "+item.Dept);

            }

        }

        public static void Main()
        {
            SampleEmployeeList();
        }
    }
}
