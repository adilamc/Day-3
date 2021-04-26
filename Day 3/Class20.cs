using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class20
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sentence");
            String s = Console.ReadLine();
            char[] arr;
            arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsLower(arr[i]))
                {
                    Console.Write(Char.ToUpper(arr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(arr[i]));
                }
            }
            Console.ReadLine();
        }
    }
    
}
