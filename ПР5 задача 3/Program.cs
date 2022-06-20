using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР5_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение A");
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            String b;
            Console.WriteLine("вводите значение B");
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);

            String x;
            Console.WriteLine("вводите значение X");
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            if (X >= A && X <= B)
            {
                Console.WriteLine("{0:F0} попадает в интервал {1:F0} до {2:F0}", X, A, B);
            }
            else
            {
                Console.WriteLine("{0:F0} за пределами интервала {1:F0} до {2:F0}", X, A, B);
            }
        }
    }
}
