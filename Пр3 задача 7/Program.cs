using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение X");
            data = Console.ReadLine();
            double X;
            X = double.Parse(data);
            if (61-X <= 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; //завершить работу прогр
            }
            double result;
            result = 3*Math.Sqrt(61-X);

            Console.WriteLine(" Результат= {0:F0}", result);
        }
    }
}
