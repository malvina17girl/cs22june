using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, i;
            Console.Write("Введите число a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число n: ");
            n = int.Parse(Console.ReadLine());

            i = 0;
            

            if (a == 0 || b == 0)
            {
                Console.WriteLine("0");
            }
            if (n<=0)
            {
                Console.WriteLine(" ");
            }
            
               
            while (a<=b)
            {
                if (i == n)
                {
                    i = 0;
                    Console.Write("\n");
                }
                i++;
                Console.Write("{0}___", a);
                a++;
               
            }
            while (b <= a)
            {
                if (i == n)
                {
                    i = 0;
                    Console.Write("\n");
                }
                i++;

                Console.Write("{0}___", b);
                b++;

            }

        }
    }
}
