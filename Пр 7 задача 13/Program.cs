using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите число A ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B ");
            b = int.Parse(Console.ReadLine());


            for (int i=a; i<=b;i++)
            { 
                Console.Write(" " +i);

                if (i< b)
                {
                    Console.Write(",");
                }
                if (i==b)
                { Console.Write("\n");
                }
            }
            for(int i = a; i>=b; i--)
            {
                Console.Write(" " + i);

                if (i > b)
                {
                    Console.Write(",");
                }
                if (i == b)
                {
                    Console.Write("\n");
                }
            }



        }
    }
}
