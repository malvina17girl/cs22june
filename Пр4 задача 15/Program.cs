using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите значение");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("вводите значение");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("вводите значение");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x >= 0)
            {
                double S;
                S = x * x;
                Console.Write("{0:F0}", S);
                Console.Write(";");
            }
            else if (x<0)
            {
                Console.Write(x);
                Console.Write(";");
            }
            if (y >= 0)
            {
                double N;
                N = y * y;
                Console.Write("{0:F0}", N);
                Console.Write(";");
            }
            else if (y < 0)
            {
                Console.Write(y);
                Console.Write(";");
            }
            if (z >= 0)
            {
                double L;
                L = z * z;
                Console.Write("{0:F0}", L);
                Console.Write(";");
            }
            else if (z < 0)
            {
                Console.Write(z);
                Console.Write(";");
            }
            
        }
    }
}

