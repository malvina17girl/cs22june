using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, x;
            x = 0;
            Console.Write("Введите число N ");
            n = int.Parse(Console.ReadLine());
            t = 0;
            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }

            while (n > t)
            {
                t++;
                Console.Write("!", n);
                

                if (x == 4)
                {
                    x = 0;
                    Console.Write(" ");
                }
                x++;
                
                

            }
            



           /* if (n == 18)
            {
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! ");

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! "); 

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! ");

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");

            }*/


        }
    }
}
