using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        public int EmpNum { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public virtual string PaySummary
        {
            get
            {
                return "No pay for plebs.";
            }
        }

        public override string ToString()
        {
            return "Employee number "+ EmpNum + ", " + fName + " " + lName;
        }
    }
}

