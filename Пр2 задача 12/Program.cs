using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String b;
            Console.WriteLine("вводите значение угла");
            b = Console.ReadLine();
            double Deg;
            Deg = double.Parse(b);

            double rad;
            rad = Deg * Math.PI / 180;

            double cos;
            cos = Math.Cos(rad);

            double result;
            result= 5 *cos;

            Console.WriteLine("Результат {0:F4} ", result);
            
        }
    }
}
