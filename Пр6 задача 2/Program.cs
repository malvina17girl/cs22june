using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_2
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

            int i;
            i = 1;
            Console.WriteLine(A);
            Console.WriteLine("---");
            while (i <= 10)
            {
                Console.WriteLine(A + i);
                Console.WriteLine("---");
                i = i + 1;
               
            }
        }
    }
}
