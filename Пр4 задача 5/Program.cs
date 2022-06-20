using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение в маленькую");
            a = Console.ReadLine();
            double small;
            small = double.Parse(a);

            if (small < 0 || small > 5)
            {

                Console.WriteLine("Фактическое количество жидкости в маленькой емкости должно быть от 0 до 5 литров включительно");
                return; //завершить работу прогр
            }

            String b;
            Console.WriteLine("вводите значение в большу");
            b = Console.ReadLine();
            double big;
            big = double.Parse(b);

            if (big < 0 || big > 8)
            {
                Console.WriteLine("Фактическое количество жидкости в большой емкости должно быть от 0 до 8 литров включительно");
                return; //завершить работу прогр
            }

            if (big < 8)
            {
                big = big + small;
                small = small - small;
                if (big > 8)
                {
                    double raz;
                    raz = big - 8;
                    big = big - raz;
                    small = small + raz;
                }

            }

            Console.WriteLine("в маленькой {0:F0} из 5, в большой {1:F0} из 8", small, big);


        }
    }
}