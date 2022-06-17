using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_4
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
            result = 2*Math.PI*radius;

            Console.WriteLine("длина окружности= {0:F0}", result);
        }
    }
}
