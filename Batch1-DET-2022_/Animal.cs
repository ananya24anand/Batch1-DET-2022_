using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022_
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public abstract string Sound();
    }

   
    

}

