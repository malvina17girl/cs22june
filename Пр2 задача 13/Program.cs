using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение угла");
            a = Console.ReadLine();
            double aDeg;
            aDeg = double.Parse(a);

            String b;
            Console.WriteLine("вводите значение угла");
            b = Console.ReadLine();
            double bDeg;
            bDeg = double.Parse(b);

            double aRad;
            aRad = aDeg * Math.PI / 180;

            double bRad;
            bRad = bDeg * Math.PI / 180;

            double acos;
            acos = Math.Cos(aRad);
            double asin;
            asin = Math.Sin(aRad);

            double bcos;
            bcos = Math.Cos(bRad);
            double bsin;
            bsin = Math.Cos(bRad);

            double result;
            result = asin * bcos + acos * bsin;

            Console.WriteLine("Результат {0:F4} ", result);
            
        }
    }
}
