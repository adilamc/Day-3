using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class2
    {
        void sum()
        {
            Console.WriteLine("I'm empty");
        }
        void sum(int a, int b)
        {
            Console.WriteLine("sum of a+b =" + (a + b));
        }
        void sum(int a, int b, int c)
        {
            Console.WriteLine("sum of a+b +c=" + (a + b +c));
        }
        void sum(string a, string b)
        {
            Console.WriteLine("Contact of two string =" + (a +" " + b));
        }
        static void Main()
        {
            Class2 class2 = new Class2();
            class2.sum();
            class2.sum(1, 2);
            class2.sum(1, 2, 3);
            class2.sum("Adila", "MC");
            Console.ReadLine();
        }
    }
}
