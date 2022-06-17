using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();
            double x;
            x = double.Parse(data);
            double result;
            result = x + 7;
            Console.Write("Результат: {0:F4}", result);
        }
    }
}
