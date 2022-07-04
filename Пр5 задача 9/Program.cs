using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр5_задача_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Xa, Ya, Xb, Yb, Delta_X, Delta_Y, r, angle, distance;

            Console.Write("Введите число XA");
            Xa = double.Parse(Console.ReadLine());
            Console.Write("Введите число YA");
            Ya = double.Parse(Console.ReadLine());
            Console.Write("Введите число XB");
            Xb = double.Parse(Console.ReadLine());
            Console.Write("Введите число rYB");
            Yb = double.Parse(Console.ReadLine());

           
            Delta_X = Xb - Xa;
            Delta_Y = Yb - Ya;

            
            r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;

            
            distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

            
            if (Delta_X >= 0 && Delta_Y > 0)
            {
                angle = Math.Abs(r);    

                Console.WriteLine("Угол 1 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            }

            if (Delta_X < 0 && Delta_Y >= 0)
            {
                angle = 180 - Math.Abs(r);

                Console.WriteLine("Угол 2 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);

            }

            if (Delta_X <= 0 && Delta_Y < 0)

            {
                angle = 180 + Math.Abs(r);

                Console.WriteLine("Угол 3 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);

            }

            if (Delta_X > 0 && Delta_Y <= 0)

            {
                angle = 360 - Math.Abs(r);

                Console.WriteLine("Угол в 4 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);

            }



        }
    }
}