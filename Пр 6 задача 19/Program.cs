using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, str_1, str_2;
            Console.Write("Введите число A ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B ");
            b = int.Parse(Console.ReadLine());
            c = b + 1;
            d = b - 1;


            if (a < c)

            {
                str_1 = (b - a) + 1;
                c = b + 1;
                while (a < c)
                {
                    Console.WriteLine("{0} {1}", a, b);
                    a++;
                    b--;

                }
                Console.WriteLine("Всего строк {0}", str_1);

            }


            else if (a > d)
            {
                str_2 = (a - b) + 1;

                while (a > d)
                {

                    
                    Console.WriteLine("{0} {1}", b, a);
                    a--;
                    b++;
                }
                Console.WriteLine("Всего строк {0}", str_2);
            }
        }
    }
}
        