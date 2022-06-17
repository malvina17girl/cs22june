using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            c = "успех";
            b = "тоже провал";
            a = "провал";
            b = a;
            b = c;
            c = b;
            a = b;
            Console.WriteLine(a);

        }
    }
}
