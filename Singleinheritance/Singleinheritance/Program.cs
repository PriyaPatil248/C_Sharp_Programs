using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer P1 = new Programmer();
            Console.WriteLine("Salary:" + P1.salary);
            Console.WriteLine("Bonus:" + P1.bonus);
            Console.ReadLine();
        }
        public class Employee
        {
            public float salary = 70000;
        }
        public class Programmer : Employee
        {
            public float bonus = 40000;

        }
    }
}
