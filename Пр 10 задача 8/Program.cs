using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                int sum= 0;

                for (int i = a; i <= b; i++)
                    if (i%7==0)
                    { 
                        sum += i;
                    }
                Console.WriteLine("Результат " + sum);
            }

            if (a > b)
            {

                int sum2 = 0;

                for (int y = b; y <= a; y++)
                    if (y % 7 == 0)
                    {
                        sum2 += y;
                    }
                Console.WriteLine("Результат " + sum2);

            }
        }
    }
}
