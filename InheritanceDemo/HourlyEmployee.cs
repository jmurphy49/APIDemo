using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class HourlyEmployee : Employee
    {
        public decimal hourlyWage { get; set; }

        public HourlyEmployee ()
        {
            hourlyWage = 15.0M;
        }
    }
}
