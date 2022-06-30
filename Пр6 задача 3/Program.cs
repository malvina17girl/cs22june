using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите символ");
            a = Console.ReadLine();
           

            int i;
            i = 1;
            Console.Write("\"");
            while (i <= 7)
            {
                Console.Write(a);
                
                i = i + 1;

            }
            Console.WriteLine("\"");



        }
    }
    
}
