using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee emp0 = new Employee();
            emp0.EmpNum = 0;
            emp0.fName = "Steve";
            emp0.lName = "Jobs";

            WorseEmployee emp1 = new WorseEmployee();
            emp1.EmpNum = 1;
            emp1.fName = "Bill";
            emp1.lName = "Gates";
            emp1.hourlyWage = 15.0M;

            Employee emp2 = emp1;

            Console.WriteLine("Emp0: " + emp0.PaySummary);
            Console.WriteLine("Emp0.ToString(): " + emp0.ToString());
            Console.WriteLine("Emp1: " + emp1.PaySummary);
            Console.WriteLine("Emp1.ToString(): " + emp1.ToString());
            Console.WriteLine("Emp2: " + emp2.PaySummary);
            Console.WriteLine("Emp2.ToString(): " + emp2.ToString());
        }
    }
}
