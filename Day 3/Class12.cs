using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

    interface inter1
    {
        void display();
    }
    
    class testClass:inter1
    { 
        public void display()
        {
            Console.WriteLine("Hello");
        }
        public static void Main()
        {
            testClass t = new testClass();
            t.display();
            Console.ReadLine();
        }
    }
}
