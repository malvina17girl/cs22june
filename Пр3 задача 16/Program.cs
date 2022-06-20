using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите скорость автомобиля 1");
            a = Console.ReadLine();
            double velocity1;
            velocity1 = double.Parse(a);
            if (velocity1 < 0)
            {

                Console.WriteLine("Скорость не должна быть отрицательная");
                return; //завершить работу прогр
            }

            String b;
            Console.WriteLine("вводите скорость автомобиля 2");
            b = Console.ReadLine();
            double velocity2;
            velocity2 = double.Parse(b);
            if (velocity2 < 0)
            {

                Console.WriteLine("Скорость не должна быть отрицательная");
                return; //завершить работу прогр
            }

            String c;
            Console.WriteLine("вводите расстояние ");
            c = Console.ReadLine();
            double distance;
            distance = double.Parse(c);
            if (distance < 0)
            {

                Console.WriteLine("Расстояние не должно быть отрицательным");
                return; //завершить работу прогр
            }

            double total;
            total = velocity1 + velocity2;
            double t;
            t = distance/ total;

            Console.WriteLine("Автомобили встретятся через {0:F4} ", t);
        }
    }
}
