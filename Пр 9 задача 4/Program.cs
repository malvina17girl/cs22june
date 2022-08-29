using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_9_задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 1, 5, 3, 10, 8, 15, 18, 20 });
            Work(new int[] { 19, 25, 0, 3, 100, 120 });
            Work(new int[] { 10, 19, 20, 29, 30, 39 });
            Work(new int[] { 19, 8, 5, 10, 34, 19 });
            Work(new int[] { 1, 1, 20, 60, 20, 20, 19, 19 });
            Work(new int[] { 3, 17, 90, 65 });
            Work(new int[] { 1, 100, 2, 99, 3, 98, 4, 97, 5, 96 });
            Work(new int[] { 1, 5, 3 });
        }

        static void Work(int[] arr)
        {
            int y = 0;



            int a = arr[y];
            y += 1;
            int b = arr[y];
            y += 1;
            if (a > b)
            {
                int c = 0;
                c = a;
                a = b;
                b = c;
            }

            if (19 >= a && 19 <= b)
            {
                Console.Write("От " + a + " до " + b);
                Console.WriteLine("<--");
            }
            else
            {
                Console.WriteLine("От " + a + " до " + b);
            }
           

            a = arr[y];
            y += 1;
            b = arr[y];
            Console.WriteLine("От " + a + " до " + b);
            
            
            Console.Write("\n");
            Console.WriteLine("------");

        }
        static void Work2(int[] arr)
        {
            int y = 0;
            while (y< arr.Length)
                {   int a = arr[y];
                     y += 1;
            int b = arr[y];
            y += 1;
            if (a > b)
            {
                int c = 0;
                c = a;
                a = b;
                b = c;
            }

            if (19 >= a && 19 <= b)
            {
                Console.Write("От " + a + " до " + b);
                Console.WriteLine("<--");
            }
            else
            {
                Console.WriteLine("От " + a + " до " + b);
            }


            a = arr[y];
            y += 1;
            b = arr[y];
            Console.WriteLine("От " + a + " до " + b);


            Console.Write("\n");
            Console.WriteLine("------");

        }
    }
}
