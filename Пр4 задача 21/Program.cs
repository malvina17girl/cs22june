using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String T;
            Console.WriteLine("вводите сколько прошло времени");
            T = Console.ReadLine();
            double t;
            t = double.Parse(T);

            double r;
            r = t%5;

            if (r >= 0 && r < 3)
            {
                Console.WriteLine("зеленый");
                return; //завершить работу прогр
            }

            if (r >= 3 && r < 5)
            {
                Console.WriteLine("красный");
                return; //завершить работу прогр
            }





          
        }
    }
}
