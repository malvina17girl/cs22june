using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение A");
            a = Console.ReadLine();
            double A;
            A= double.Parse(a);

            String b;
            Console.WriteLine("вводите значение B");
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);

            
            if (-7 * B <= 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return; //завершить работу прогр
            }
            double result;
            result = A * Math.Sqrt(-7 * B);

            Console.WriteLine(" Результат= {0:F4}", result);
        }
    }
}
