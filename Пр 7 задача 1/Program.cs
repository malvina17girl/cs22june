using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, t,k;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine());
            t = 0;
            k = 0;
            if (a < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return; //завершить работу прогр;
            }
            if (n < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return; //завершить работу прогр;
            }

            while (a >t)
            {
                t++;
                Console.Write("#");

            }
            Console.WriteLine();
            while (n>k)
            {
                k++;
                Console.Write("#");



            }
        }
    }
}
