using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDefineException
{
    class UserDefineException : Exception
    {
        public UserDefineException(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program2
    {
        static void Main()
        {
            UserDefineException M = new UserDefineException("User define Exception");
            try
            {
                throw M;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }

}
