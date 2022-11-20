using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hierarchicalinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.show();
            b1.display();

            C c1 = new C();
            c1.show();
            c1.print();
            Console.ReadLine();
        }
    }
    class A
    {
        public void show()
        {
            Console.WriteLine("Welcome BCS III");
        }
    }
    class B : A
    {
        public void display()
        {
            Console.WriteLine("Welcome BCS III-Batch 1");
        }
    }
    class C : A
    {
        public void print()
        {
            Console.WriteLine("Welcome BCS III-Batch 2");
        }
    }
}
  
