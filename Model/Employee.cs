using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Post { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}