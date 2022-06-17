using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            String b;
            String c;

            Console.WriteLine("Введите значение а");
            a = Console.ReadLine();
            Console.WriteLine("Введите значение b");
            b = Console.ReadLine();
            
            c = b + " " + a;
            Console.Write(c);


        }
    }
}
