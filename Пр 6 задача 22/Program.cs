using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b, a;
            a = 0;
            Console.Write("Введите число N ");
            n = int.Parse(Console.ReadLine());
            b = 0;



            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }


            while (b <= n)
            {

                Console.WriteLine("{0} - {1}", b, a);
                b++;
                a++;


                if (a == 4)
                {
                    a = 0;

                }
            }
        }
    }
}
