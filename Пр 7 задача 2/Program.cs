using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, m, n,k;
            Console.Write("Введите число: ");
            w = int.Parse(Console.ReadLine());
            n = 0;
            m = 0;
            k = 0;
            if (w < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return; //завершить работу прогр;
            }

            if (w==1)
            {   Console.WriteLine("+");
                Console.WriteLine("|");
                Console.WriteLine("+");
                return;

            }
            if (w == 2)
            {
                Console.WriteLine("++");
                Console.WriteLine("||");
                Console.WriteLine("++");
                return;

            }
            Console.Write("+");
            w -= 2;
            while (w > n)
            {
                Console.Write("-", n);
                n++;
            }

            Console.WriteLine("+");
            Console.Write("|");
            while (w > k)
            {
                Console.Write(".", k);
                k++;
            }
            Console.WriteLine("|");

            Console.Write("+");
            while (w > m)
            {
                Console.Write("-", m);
                m++;
            }
            Console.WriteLine("+");



        }
    }
}
