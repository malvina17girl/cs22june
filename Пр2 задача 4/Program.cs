using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение aDeg");
            data = Console.ReadLine();
            double aDeg;
            aDeg = double.Parse(data);
            double result;
            result = aDeg*Math.PI/180;
            Console.WriteLine("Результат: aRad = {0:F4}", result);
            
        }
    }
}
