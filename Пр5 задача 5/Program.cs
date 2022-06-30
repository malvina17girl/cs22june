using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр5_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            Console.WriteLine("вводите значение X");
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);

            String y;
            Console.WriteLine("вводите значение Y");
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);

            String z;
            Console.WriteLine("вводите значение Z");
            z = Console.ReadLine();
            double Z;
            Z = double.Parse(z);


            if (X >= -11 && X <= 13)
            {
                Console.Write("{0:F0}, ", X);
            }

            if (Y >= -11 && Y <= 13)
            {
                Console.Write("{0:F0}, ", Y);
            }

            if (Z >= -11 && Z <= 13)
            {
                Console.Write("{0:F0}, ", Z);
            }
            
        }
    }
}
