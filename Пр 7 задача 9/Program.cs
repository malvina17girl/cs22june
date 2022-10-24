using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(1, 1);
            Letter(7, 3);
            Letter(5, 5);

            //Решено полностью
        }
        static void Letter(int a, int b)
        {

            int n = 0;
            int i = 0;
            int m = 0;
            int k = 0;

            Console.Write(" ");
            while (a > n)
            {
                Console.Write(" " + n);
                n++;
            }
            Console.WriteLine(" ");
          
            while (b > i)
            {
                Console.Write(i);

                for (k = 0; k < a; k++)
                {
                    Console.Write(" "+".", i);

                }
                Console.Write("|");
                Console.Write("\n");
                i++;
               
            }
            Console.Write(" ");
            while (a > m)
            {
                Console.Write(" " + "-", m);
                m++;
            }
            Console.Write("\n");

            Console.Write("-----------------------------");
            Console.Write("\n");
        }
    }
}
    

        
    

