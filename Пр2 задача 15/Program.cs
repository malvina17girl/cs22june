using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите длину линии");
            a = Console.ReadLine();
            double distance;
            distance = double.Parse(a);

            if (distance <= 0)
            {

                Console.WriteLine("Горизонтальное проложение линии должно быть положительно");
                return; //завершить работу прогр
            }
            String b;
            Console.WriteLine("вводите значение дирекционного угла");
            b = Console.ReadLine();
            double angleDeg;
            angleDeg = double.Parse(b);

            if(angleDeg < 0)
            {

                Console.WriteLine("Угол должен быть неотрицательным");
                return; //завершить работу прогр
            }


            String xa;
            Console.WriteLine("вводите координату X");
            xa = Console.ReadLine();
            double Xa;
            Xa = double.Parse(xa);

            String ya;
            Console.WriteLine("вводите координату X");
            ya = Console.ReadLine();
            double Ya;
            Ya = double.Parse(ya);

            double bRad;
            bRad = angleDeg * Math.PI / 180;

            double cosb;
            double sinb;
            cosb=Math.Cos(bRad);
            sinb=Math.Sin(bRad);

            double dX;
            double dY;
            dX = distance * cosb;
            dY = distance * sinb;

            double Xb;
            double Yb;
            Xb = Xa + dX;
            Yb= Ya + dY;

            Console.WriteLine("Приращение координат:X= {0:F4}, Y= {1:F4}", dX, dY);
            Console.Write("Координаты второй точки ( {0:F4};{1:F4}",Xb,Yb);
            Console.WriteLine(")");






        }
    }
}
