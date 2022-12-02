using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("shivraj1.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}
