using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите х");
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);


            //0+1=1
               // 1+2=3
               // 3+3=6
               // 6+4=10

            double b;
            b = 0;
            double i;
            i = 1;

            double n;
            n = 1;
            
            
            Console.Write(b + " ");

            while (i < A)
            {

                Console.Write(b + n + " ");
                i = i + 1;
                b = b + n;
                n = b + 1;

                

            }

        }
    }
}
