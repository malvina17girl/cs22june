using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение радиус");
            data = Console.ReadLine();
            double radius;
            radius = double.Parse(data);
            if (radius <= 0)
            {

                Console.WriteLine("Радиус должен быть положительным");
                return; //завершить работу прогр
            }
            double result;
            result = 4 * Math.PI * radius* radius* radius/3;

            Console.WriteLine(" объём шара volume= {0:F0}", result);
        }
    }
}
