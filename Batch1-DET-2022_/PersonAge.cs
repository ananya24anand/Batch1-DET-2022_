using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022_
{
    public class PersonAge
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter age ");
                int age = int.Parse(Console.ReadLine());
                if (age < 0 || age > 120)
                    throw new InvalidAgeException("Invalid Age");
            }
            
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
    
}
