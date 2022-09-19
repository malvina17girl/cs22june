using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 1, 2, 3, 4, 5, 6 });
            Work(new int[] { 12, 34, 56, 78, 90 });
            Work(new int[] { 123, 234, 345, 456 });
            Work(new int[] { 9876, 5432, 1987 });
            Work(new int[] { 77777, 44444 });
            Work(new int[] { 987654 });

        }
        static void Work(int[] arr)
        {
            if (arr.Length >= 5)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                int r = arr[0];
                Console.WriteLine("Промежуточный итог:" + r);
                Console.WriteLine("Значение элемента на индексе 1 это " + arr[1]);
                r += arr[1];
                Console.WriteLine("Промежуточный итог:" + r);
                Console.WriteLine("Значение элемента на индексе 3 это " + arr[3]);
                r += arr[3];
                Console.WriteLine("Промежуточный итог:" + r);
                Console.WriteLine("Значение элемента на индексе 4 это " + arr[4]);
                r += arr[4];
                Console.WriteLine("Промежуточный итог:" + r);
                Console.WriteLine("Финальный итог:" + r);
                Console.WriteLine("\n");
                return;
            }
            if (3 < arr.Length && arr.Length <= 4)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                int l = arr[0];
                Console.WriteLine("Промежуточный итог:" + l);
                Console.WriteLine("Значение элемента на индексе 1 это " + arr[1]);
                l += arr[1];
                Console.WriteLine("Промежуточный итог:" + l);
                Console.WriteLine("Значение элемента на индексе 3 это " + arr[3]);
                l += arr[3];
                Console.WriteLine("Промежуточный итог:" + l);
                Console.WriteLine("Нет эллемента на индексе 4");
                Console.WriteLine("Финальный итог:" + l);
                Console.WriteLine("\n");
                return;
            }
            if (1 < arr.Length && arr.Length <= 3)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                int w = arr[0];
                Console.WriteLine("Промежуточный итог:" + w);
                Console.WriteLine("Значение элемента на индексе 1 это " + arr[1]);
                w += arr[1];
                Console.WriteLine("Промежуточный итог:" + w);
                Console.WriteLine("Нет эллемента на индексе 3");
                Console.WriteLine("Нет эллемента на индексе 4");
                Console.WriteLine("Финальный итог:" + w);
                Console.WriteLine("\n");
                return;
            }
            if (arr.Length <= 1)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                int k = arr[0];
                Console.WriteLine("Промежуточный итог:" + k);
                Console.WriteLine("Нет эллемента на индексе 1");
                Console.WriteLine("Нет эллемента на индексе 3");
                Console.WriteLine("Нет эллемента на индексе 4");
                Console.WriteLine("Финальный итог:" + k);
                Console.WriteLine("\n");
                return;

            }
        }
    }
}
