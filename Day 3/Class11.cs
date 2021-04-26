using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    abstract class Employee//abstract
    {
        public virtual string VirtualMethod()
        {
            return "Hello! iam getting called from base";
        }

    }
    class Class10 : Employee//concrete class
    {
        public override string VirtualMethod()
        {
            //base.VirtualMethod();
            return "Hello! iam getting called from derived base";
        }
        public static void Main()
        {
            Class10 class10 = new Class10();
            Console.WriteLine(class10.VirtualMethod());
            Console.ReadLine();
        }
    }
}
