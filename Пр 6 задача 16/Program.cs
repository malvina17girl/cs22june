using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите число A ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Значение А должно быть не больше значения В");
                return;
            }
            Console.Write("{ ");
            while(b >= a)
            {
                Console.Write("{0} ", b);
                b--;
            }
            Console.WriteLine("}");
        }
    }
}
