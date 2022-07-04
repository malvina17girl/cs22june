using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit, x, y;
            x = 0;
            y = 1;
            limit = int.Parse(Console.ReadLine());
            if (limit < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return;
            }
            while (limit > x)
            {
                Console.Write("{0} ", x);
                x = x + y;
                y = y + 1;
            }
        }
    }
}
