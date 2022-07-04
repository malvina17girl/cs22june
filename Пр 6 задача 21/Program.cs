using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            d = a + 10;
            e = b + 10;
            f = c + 10;

            while (a < d | b < e | c < f)
            {
                if (a == 10 | b == 10 | c == 10)
                {
                    Console.WriteLine("{0} {1} {2} Найдено", a, b, c);
                    a++;
                    b++;
                    c++;
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    a++;
                    b++;
                    c++;


                }
            }

        }
    }
}
