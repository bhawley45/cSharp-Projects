using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAsignment
{
    internal class Employee : Person
    {
        public int IdNumber { get; set; }

        public static bool operator== (Employee a, Employee b)
        {
            return a.IdNumber == b.IdNumber;
        }

        public static bool operator!= (Employee a, Employee b)
        {
            return a.IdNumber == b.IdNumber;
        }
    }
}
