using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_18
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
            double velocity;
            velocity = double.Parse(b);
            if (velocity < 0)
            {

                Console.WriteLine("Значение должно быть положительно");
                return; //завершить работу прогр
            }

            String c;
            Console.WriteLine("вводите значение");
            c = Console.ReadLine();
            double height;
            height = double.Parse(c);
            if (height < 0)
            {

                Console.WriteLine("Расстояние не должно быть отрицательным");
                return; //завершить работу прогр
            }
            double kineticEnergy;
            kineticEnergy = (mass * (velocity * velocity)) / 2;
            double potentialEnergy;
            potentialEnergy = mass * 9.8067 * height;

            Console.WriteLine("Кинетическая энергия составляет {0:F4} Дж", kineticEnergy);
            Console.WriteLine("Потенциальная энергия составляет {0:F4} Дж", potentialEnergy);

        }
    }
}
