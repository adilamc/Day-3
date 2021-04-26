using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    sealed class Class8
    {
        public int a;
    }
    class Class9
    {
        public static void Main()
        {
            Class8 class9 = new Class8();
            class9.a = 1;
            Console.WriteLine(class9.a);
            Console.ReadLine();
        }
    }
}
