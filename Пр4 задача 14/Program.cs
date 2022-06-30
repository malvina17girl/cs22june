using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String m;
            Console.WriteLine("вводите скорость корабля");
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);

            if (M < 0.0000)
            {
                Console.WriteLine("Значение M должно быть полоительно");
                return; //завершить работу прогр
            }


            String p;
            Console.WriteLine("вводите скорость кометы");
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);

            if (P < 0.0000)
            {
                Console.WriteLine("Значение P должно быть полоительно");
                return; //завершить работу прогр
            }

            double P1;
            P1 = P * 3600 / 1000;

            if (P1<M)

            {
                Console.WriteLine("Скорость кометы {0:F0} м/с меньше скорости корабля {1:F0} км/ч", P, M);
                Console.WriteLine("Корабль догонит комету.");
            }
            if(P1 > M)

            {
                Console.WriteLine("Скорость кометы {0:F0} м/с больше скорости корабля {1:F0} км/ч", P, M);
                Console.WriteLine("Корабль не догонит комету.");
            }
        }
    }
}
