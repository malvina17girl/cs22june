using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите значение");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("вводите значение");
            int Q = Convert.ToInt32(Console.ReadLine());

            if (P>Q)
            {
            int a = P - Q;
            Console.WriteLine(" max= {0:F0}, min= {1:F0}, разница= {2:F0}", P, Q, a);
            }
            if (Q > P)
            {
            int b = Q - P;
            Console.WriteLine("max= {0:F0}, min= {1:F0}, разница= {2:F0}", Q, P, b);
            }
            if (Q == P)
            {
                int c = Q - P;
                Console.WriteLine("max= {0:F0}, min= {1:F0}, разница= {2:F0}", Q, P, c);
            }

        }
    }
}
