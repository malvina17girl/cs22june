using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String m;
            Console.WriteLine("вводите длину дороги");
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);

            if (M == 0.0000)
            {
                Console.WriteLine("Значение M не должно быть равно нулю");
                return; //завершить работу прогр
            }


            String p;
            Console.WriteLine("вводите длину кабеля");
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);

            if (P == 0.0000)
            {
                Console.WriteLine("Значение P не должно быть равно нулю");
                return; //завершить работу прогр
            }

            double M1;
            M1 = M * 1000;
            double M2;
            M2 = M1 / 0.305;

            double P1;
            P1 = P * 0.305;
            double P2;
            P2 = P1 / 1000;

            if (M1 < P1)
            {
                Console.WriteLine("Расстояние {0:F4} км это {1:F4} футов", M, M2);
                Console.WriteLine("Длина кабеля {0:F4} футов это {1:F4} км", P, P2);
                Console.WriteLine("Кабеля хватит. Расстояние меньше длины кабеля.");
            }
            if (M1 > P1)
            {
                Console.WriteLine("Расстояние {0:F4} км это {1:F4} футов", M, M2);
                Console.WriteLine("Длина кабеля {0:F4} футов это {1:F4} км", P, P2);
                Console.WriteLine("Кабеля не хватит. Расстояние больше длины кабеля.");
            }






        }
    }
}
