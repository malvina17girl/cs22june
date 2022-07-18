using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задаа_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,h;
            Console.Write("Введите символ: ");
            string c = Console.ReadLine();
            Console.Write("Введите высоту: ");
            h = int.Parse(Console.ReadLine());

            if ( h < 0)
            {
                Console.WriteLine("Значение не может быть отриц");
                return;
            }

            for (a = 0; a < h; a++)
            { 
                for (b = -1; b < a; b++)
                { 
                    Console.Write(c); 
                }
                Console.WriteLine();
            }
            
        }
    }
}
