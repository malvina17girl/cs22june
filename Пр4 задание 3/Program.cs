using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение");
            data = Console.ReadLine();
            double K;
            K = double.Parse(data);

            double result;
            result=Math.Abs(K);

            Console.WriteLine("Абсолютное значение числа ={0:F0}",result);
        }
    }
}
