using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x1;
            Console.WriteLine("вводите значение A");
            x1 = Console.ReadLine();
            double Xa;
            Xa = double.Parse(x1);

            String y1;
            Console.WriteLine("вводите значение B");
            y1 = Console.ReadLine();
            double Ya;
            Ya = double.Parse(y1);

            String x2;
            Console.WriteLine("вводите значение A");
            x2 = Console.ReadLine();
            double Xb;
            Xb = double.Parse(x2);

            String y2;
            Console.WriteLine("вводите значение B");
            y2 = Console.ReadLine();
            double Yb;
            Yb = double.Parse(y2);

            double result;

            result = Math.Sqrt((Xb-Xa)*(Xb-Xa) + (Yb-Ya)*(Yb-Ya));
            Console.WriteLine("Результат = {0:F4}", result);
        }
    }
}
