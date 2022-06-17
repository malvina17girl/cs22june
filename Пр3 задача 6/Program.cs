using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_6
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
            if (X <= 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; //завершить работу прогр
            }
            double result;
            result = Math.Sqrt(X);

            Console.WriteLine(" Результат= {0:F0}", result);
        }
    }
}
