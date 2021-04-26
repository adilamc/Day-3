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
            String y = string.Empty;
          
            for (int i = 0; i < s.Length; i++)
            {
                if (!y.Contains(s[i]))
                {
                    y += s[i];
                }
              
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }

}
