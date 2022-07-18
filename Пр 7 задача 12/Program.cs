using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, h, a, b;
            string c = "+";
            string d = "#";
            Console.Write("Введите ширину: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = int.Parse(Console.ReadLine());
            a = 0;
            b = 0;
            if (w < 0 || h < 0)
            {
                Console.WriteLine("Значение не может быть отриц");
                return;
            }
            for (a = 0; a < h ;a++ )
            {
                for (b = -w; b < -a; b++)
                {

                    Console.Write(c);
                }
                for (b = 0; b < a;b++) 

                {
                    Console.Write(d);
                }

                Console.WriteLine();
            }




            //while (a <= w && b <= h)
            //{
            //    a++;
            //    b++;

            //    if (h > w)
            //{
            //    h = h - w;

            //  Console.Write(c);    
            // }



            //Console.WriteLine();
        }
            
        }
    }

