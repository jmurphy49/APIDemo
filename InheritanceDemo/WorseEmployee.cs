using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class WorseEmployee : HourlyEmployee
    {
        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + hourlyWage + " per hour.";
            }
        }

            public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
