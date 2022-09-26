using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_3
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
                long total2 = 1;

                for (long i = a; i <= b; i++)

                    total2 *= i;

                Console.WriteLine("Реpультат " + total2);
            }

            if (a > b)
            {
                
                long total = 1;

                for (long y = b; y <= a; y++)

                    total *= y;

                Console.WriteLine("Реpультат " + total);

            }
          

        }
    }
}
