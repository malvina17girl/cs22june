using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_заадача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, a,b,c;
            Console.Write("Введите число: ");
            w = int.Parse(Console.ReadLine());
            
            a = 0;
            b = 0;
            c = 0;
           

            if (w==1)
            {   Console.WriteLine("a\nb\nc\nd\n");
                
            }

            while (w>a)
            {
                Console.Write("a");
                a++;
            }
            if (a==w)
            {
                a = 0;
            }
            Console.WriteLine();
            while (w > a)
            {
                Console.Write("b");
                a++;
            }
            if (a == w)
            {
                a = 0;
            }
            Console.WriteLine();
            while (w > a)
            {
                Console.Write("c");
                a++;
            }
        }
    }
}
