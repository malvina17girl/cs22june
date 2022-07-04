using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_18
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
                Console.WriteLine("По возрастанию");
            }
            while(a <= b)
            {
                Console.Write("{0} ", a);
                a++;
            }
            if (a > b)
            {
                Console.WriteLine("По убыванию");
            }
            while(a >= b)
            {
                Console.Write("{0} ", a);
                a--;
            }
            if (a == b)
            {
                Console.WriteLine("По убыванию \n{0}", a);
                return;
            }
            
            
        }

    }
}
