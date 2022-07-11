using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Введите число x: ");
            x = int.Parse(Console.ReadLine());
            y = 0;

            if (x <= 0)
            {
                Console.WriteLine("Значение X должно быть положительным");
            }
            while(y<=x)
            {
                y++;
                if (x % y == 0)
                {
                    Console.WriteLine("{0}", y);
                }

            }

        }
    }
}
