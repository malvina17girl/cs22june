using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, h, b, c;
            Console.Write("Введите символ: ");
            string a = Console.ReadLine();
            Console.Write("Введите символ: ");
            string d = Console.ReadLine();
            Console.Write("Введите ширину: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = int.Parse(Console.ReadLine());
            //n = 0;
            if (w < 0 || h < 0)
            {
                Console.WriteLine("Значение не может быть отриц");
                return;
            }

            for (b = 0; b < h; b++)
            {
                
                    for (c = 0; c < w; c++)
                    {
                        if (c % 2 == 0 )
                        {
                          Console.Write(a);
                        }
                    
                        else
                        {
                           Console.Write(d);
                        }
                   
                    }
                
                Console.WriteLine();
            }
        }
    }
}
