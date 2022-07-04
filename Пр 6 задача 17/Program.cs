using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_17
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

            if (a < b)
            {
                Console.WriteLine("От А до В");
                while (a <= b)
                {
                    Console.Write("{0} ", a);
                    a++;
                }
            }
            else if (a > b)
            {
                Console.WriteLine("От В до А");
                while (a >= b)
                {
                    Console.Write("{0} ", b);
                    b++;
                }
            }
            if (a == b)
            {
                Console.WriteLine("Границы равны \n{0}", a);
                return;
            }
        }
    }
}
