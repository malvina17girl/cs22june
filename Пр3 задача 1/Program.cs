using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic(1);
            Logic(5);
            Logic(0);
            Logic(-2);

            String data;
            Console.WriteLine("вводите значение edge");
            data = Console.ReadLine();
            double edge;
            edge = double.Parse(data);

            Logic(edge);
        }

        static void Logic(double edge)
        {

            if (edge <= 0)
            {

                Console.WriteLine("Длина ребра куба должна быть положительна");
                return; //завершить работу прогр
            }
            double result;
            result = 6 * edge * edge;

            Console.WriteLine("Площадь боковой поверхности куба area= {0:F0}", result);
        }
        
    }
}
