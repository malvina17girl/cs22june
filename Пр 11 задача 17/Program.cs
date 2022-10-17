using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 9, 8, 7, 6, 5, 4 });
            Work(new int[] { 5, 9, 1, 6, 7, 3 });
            Work(new int[] { 100, 5, 64, 3, 87 });
            Work(new int[] { 3, 4, 5, 6, 7, 8 });
            Work(new int[] { 8, 8, 8, 8, 8, 8 });
            Work(new int[] { 5, -5, 0 });

        }
        static void Work(int[] arr)
        {


            int min = arr[0];
            int max = arr[0];
            int dif = 0;
            Console.WriteLine("Ход решения:");

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    Console.WriteLine("Промежуточное минимальное {0}", min);
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    Console.WriteLine("Промежуточное максимальное {0}", max);
                }

              
               
            }
            dif = max - min;
            Console.WriteLine("Итоговое минимальное {0}",min);
            Console.WriteLine("Итоговое минимальное {0}",max);
            Console.WriteLine("Разница:{0}",dif);
            Console.WriteLine("_______________________");
        }
    }
}
