using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, y, n;
            Console.Write("Введите число: ");
            y = int.Parse(Console.ReadLine());
            i = 1;
            n = 15 - y;

            if (y < 0)
            {
                Console.WriteLine("Значение A должно быть отрицательным");
                Console.ReadKey();
            }
            if (y > 15)
            {
                Console.WriteLine("Значение не дожно быть больше 15");
                Console.ReadKey();
            }

            while (i <= y)
            {
                Console.Write("#", y);
                i++;

                
            }
            for (int j = 0; j <= n; j++)
            { 
            
                    Console.Write("*",n);
                }
                



           





        }
    }
}
    

