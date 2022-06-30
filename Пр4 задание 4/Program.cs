using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String m;
            Console.WriteLine("вводите значение");
            m = Console.ReadLine();
            double M;
            M = double.Parse(m);

            String p;
            Console.WriteLine("вводите значение");
            p = Console.ReadLine();
            double P;
            P = double.Parse(p);

            if (P == 0) 
            {
                Console.WriteLine("Значение P не должно быть равно нулю");
                return; //завершить работу прогр
            }

            if (M % P != 0)
            {
                Console.WriteLine("{0:F0}не делится нацело на {1:F0}", M, P);
                return; //завершить работу прогр
            }
           
            double total;
            total= M / P;
            Console.WriteLine(total);

        }
    }
}
