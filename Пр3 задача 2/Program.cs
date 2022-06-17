using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение edge");
            a = Console.ReadLine();
            double edge;
            edge = double.Parse(a);

            String b;
            Console.WriteLine("вводите значение height");
            b = Console.ReadLine();
            double height;
            height = double.Parse(b);

            if (edge <= 0)
            {

                Console.WriteLine("Длина основания треугольника должна быть положительна");
                return; //завершить работу прогр
            }

            if (height <= 0)
            {

                Console.WriteLine("Высота треугольника должна быть положительна");
                return; //завершить работу прогр
            }
            double result;
            result = edge * height / 2;

            Console.WriteLine("Площадь прямоугольного треугольника area= {0:F0}", result);
        }
    }
}
