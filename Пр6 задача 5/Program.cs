using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение V");
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            Console.WriteLine("Таблица умножения на ", A);

            double i;
            i = 1;

            double r;
            r = i*A;


            while (i <= 9)
            {
                Console.WriteLine("{0:F0}*{1:F0}={2:F0}",i,A,r);

                i = i + 1;
                r = i * A;

            }
        }
    }
}
