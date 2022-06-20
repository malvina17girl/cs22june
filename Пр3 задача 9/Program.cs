using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x;
            Console.WriteLine("вводите значение A");
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);

            String y;
            Console.WriteLine("вводите значение B");
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);

            if (Y < 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; //завершить работу прогр
            }


            if (X + Math.Sqrt(Y) < 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; //завершить работу прогр
            }
            double result;
            result = -5 * Math.Sqrt(X+ Math.Sqrt(Y));

            Console.WriteLine(" Результат= {0:F4}", result);
        }
    }
}
