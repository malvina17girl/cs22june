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
            int w,h,a,b;
            Console.Write("Введите число: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            h = int.Parse(Console.ReadLine());
            a = 0;
            b = 0;
        
            while (w > a)
            {
                Console.Write("#",h);
                a++;
            }
            
        }
    }
}
