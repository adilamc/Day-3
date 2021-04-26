using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class3
    {
        void sum()
        {
            Console.WriteLine("I'm empty");
        }
        void sum(int a, int b)
        {
            Console.WriteLine("sum of a+b =" + (a + b));
        }
        void sum(double a, double b)
        {
            Console.WriteLine("sum of a+b=" + (a + b));
        }
        void sum(string a, string b)
        {
            Console.WriteLine("Contact of two string =" + (a + " " + b));
        }
        static void Main()
        {
            Class3 class3 = new Class3();
            class3.sum();
            class3.sum(1, 2);
            class3.sum(1.2, 2.3);
            class3.sum("Adila", "MC");
            Console.ReadLine();
        }
    }
}
