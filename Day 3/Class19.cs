using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class19
    {
        public static void Main()
        {
            string x = "It is a bad color";
            Console.WriteLine("string: " + x);
            string y = "is a";
            Console.WriteLine("Substring: " + y);
            if (x.Contains(y))
            {
                Console.WriteLine("substring 'is a' is present");
            }
            Console.ReadLine();
        }
    }
}
