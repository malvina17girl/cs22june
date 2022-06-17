using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1_задача_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a, b, c, d;

            c = "успех";
            a = "тоже провал";
            b = "провал";

            d = c;
            b = d;
            c = b;
            d = b;
          
            
            a = b;
            
            Console.WriteLine(a);

        }
    }
}
