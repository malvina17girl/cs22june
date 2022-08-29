using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic(11.13);
            Logic(-7919);
            Logic(0);
            Logic(6.00006);
            Logic(9.00004);

            String data;
            Console.WriteLine("вводите значение X");
            data = Console.ReadLine();
            double x;
            x = double.Parse(data);

            Logic(x);
        }

        static void Logic(double x)
        {
            double result;
            result = x + 7;
            Console.WriteLine("Результат: {0:F4}", result);

        }


            
        
    }
}
