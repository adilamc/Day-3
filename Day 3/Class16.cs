using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    static class Class12
    {
        static Class12()
        {
            Console.WriteLine("Hi I'm constructor");
        }
        public static string Topic = "Static Class";
        public static void sum()
        {
            Console.WriteLine("Hi I'm static function");
        }
    }
    class Client
    {
        public static void Main()
        {
            Class12.sum();
            Console.WriteLine(Class12.Topic);
            Console.ReadLine();
        }
    }
}
