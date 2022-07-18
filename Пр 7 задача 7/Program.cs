using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, h, b, c;
            Console.Write("Введите символ: ");
            string a = Console.ReadLine();
            Console.Write("Введите ширину: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = int.Parse(Console.ReadLine());

            
           

            if (w<0||h<0)
            {
                Console.WriteLine("Значение не может быть отриц");
                return;
            }

            for (b = 0; b < h; b++)
            {
                for (c = 0; c < w; c++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }




            //while (w > a)
            //{
            //    Console.Write(c);
            //    a++;

            //}
            //b += 1;
            //if (a == w)
            //{
            //    a = 0;
            //}
            //Console.WriteLine();
            //while (w > a)
            //{
            //    Console.Write(b);
            //    a++;

            //}
            //b += 1;
            //if (a == w)
            //{
            //    a = 0;
            //}
            //Console.WriteLine();
            //while (w > a)
            //{
            //    Console.Write(b);
            //    a++;

            //}
            //b += 1;
            //if (a == w)
            //{
            //    a = 0;
            //}
            //Console.WriteLine();
            //while (w > a)
            //{
            //    Console.Write(b);
            //    a++;

            //}
            //b += 1;
            //if (a == w)
            //{
            //    a = 0;
            //}
            //Console.WriteLine();
            //while (w > a)
            //{
            //    Console.Write(b);
            //    a++;

            //}
            //b += 1;
            //if (a == w)
            //{
            //    a = 0;
            //}
            //Console.WriteLine();

        }
    }
}
