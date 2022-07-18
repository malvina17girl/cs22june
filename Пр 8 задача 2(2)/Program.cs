using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                return;
            }
            String[] arr = data.Split(',');

            int a = 0;
            int b = 2;
            int c = 3;
            int d = 5;


            if (a < 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Нет эллемента на индексе {}", a);

            }
            else

            {
                Console.WriteLine("Значение элемента на индексе " + a + " это " + arr[a]);
            }

            if (b < 0 || arr.Length - 1 < b)
            {
                Console.WriteLine("Нет эллемента на индексе {0}", b);

            }
            else
            {
                Console.WriteLine("Значение элемента на индексе " + b + " это " + arr[b]);
            }

            if (c < 0 || arr.Length - 1 < c)
            {
                Console.WriteLine("Нет эллемента на индексе {0}", c);

            }
            else
            {
                Console.WriteLine("Значение элемента на индексе " + c + " это " + arr[c]);
            }

            if (d < 0 || arr.Length - 1 < d)
            {
                Console.WriteLine("Нет эллемента на индексе {0}", d);
                return;
            }
            else
            {
                Console.WriteLine("Значение элемента на индексе " + d + " это " + arr[d]);
            }
        }
    }
}
