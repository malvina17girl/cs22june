using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение А должно быть не больше значения В");
                return;
            }
            
            while (a <= b)
            {
                Console.Write("{0};", a);
                a++;
            }

           
            
            
        }
    }
}
