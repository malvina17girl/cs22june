using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение edge");
            data = Console.ReadLine();
            double edge;
            edge = double.Parse(data);
            if (edge <= 0)
            {

                Console.WriteLine("Длина ребра куба должна быть положительна");
                return; //завершить работу прогр
            }
            double result;
            result = edge* edge* edge;

            Console.WriteLine("Площадь боковой поверхности куба volume= {0:F0}", result);
        }
    }
}
