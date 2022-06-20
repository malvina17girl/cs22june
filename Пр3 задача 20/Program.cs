using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение массы");
            a = Console.ReadLine();
            double mass;
            mass = double.Parse(a);
            if (mass < 0)
            {

                Console.WriteLine("Значение должно быть положительно");
                return; //завершить работу прогр
            }

            String b;
            Console.WriteLine("вводите сзначение");
            b = Console.ReadLine();
            double aDeg;
            aDeg = double.Parse(b);
            if (aDeg < 0)
            {

                Console.WriteLine("Значение должно быть положительно");
                return; //завершить работу прогр
            }

            double aRad;
            aRad = aDeg * Math.PI / 180;

            double force;
            force = mass * 9.8067 * Math.Cos(aRad);
            Console.WriteLine("РЕзультат {0:F6} Дж", force);


        }
    }
}
