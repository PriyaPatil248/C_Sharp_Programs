using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multilevelinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.show();
            obj.display();
            obj.greet();
            Console.ReadLine();
        }
        class A
        {
            public void show()
            {
                Console.WriteLine("Hello from class A:Batch 1");
            }
        }
        class B : A
        {
            public void display()
            {
                Console.WriteLine("Hello from class B:Batch 2");
            }
        }
        class C : B
        {
            public void greet()
            {
                Console.WriteLine("Hello from class C:Batch 1 & 2");
            }

        }
    }
}
