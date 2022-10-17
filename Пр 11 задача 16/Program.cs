using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 6, 5, 7, 8, 3, 4, 1 });
            Work(new int[] { 1, 2, 3, 4, 5, 6 });
            Work(new int[] { 3, 4, 1, 2, 3, 4, 1, 2, 3, 1, 2 });
            Work(new int[] { 4, 2, 3, 4, 3, 2 });
            Work(new int[] { 4, 4, 4, 4, 4, 3, 8, 9 });
            Work(new int[] { 4, 4, 4, 4, 4 });
            Work(new int[] { 4, 3 });
        }
        static void Work(int[] arr)
        {
            Console.WriteLine("Ход решения:");
            Console.WriteLine("Начинаю с {0}", arr[0]);
           
            int min = arr[0];
            int t = 0;
            while (t < arr.Length)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.WriteLine("Сравниваю {0} и {1}", arr[i-1], arr[i]);

                    if (arr[i] < min)
                    {
                        Console.WriteLine("Замняем");
                        min = arr[i];
                    }
                    
                }
                t++;
            }
            Console.WriteLine("В массиве минимальный элемент {0}", min) ;
            Console.WriteLine("---------------------------------------");
        }
           

        
    }
}

//Алгоритм поиска наименьшего числа
//int min = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//}
//Console.WriteLine(min);