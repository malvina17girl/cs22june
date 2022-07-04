using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Введите число X");
            x = int.Parse(Console.ReadLine());
            y = 10;
            while (y <= 20)
            {


                if (x == y)
                {
                    Console.WriteLine("{0} Найдено", y);
                }
                else
                {

                    Console.WriteLine(y);
                }
                y++;




            }
        }
    }
}