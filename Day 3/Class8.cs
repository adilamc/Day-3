using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    
    class Class6
    {
        public int a;
        Class6(int a)
        {
            this.a = a; //This refers to Class6
        }
        static void Main()
        {
            Class6 class6 = new Class6(6);
            Console.WriteLine(class6.a);
            Console.ReadLine();
        }
    }
}
