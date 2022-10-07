using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Students(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
