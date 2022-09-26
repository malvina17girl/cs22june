using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 4, 1, 1, 1 });
            Work(new int[] { 1, 4, 2, 1 });
            Work(new int[] { 3,4, 1, 5 });
            Work(new int[] { 1, 2, 3, 4, 1, 2 });
            Work(new int[] { 9, 8, 9, 1, 1, 5, 1, 1 });
            Work(new int[] { 5, 5, 5, 5, 5 });
            Work(new int[] { 1, 9, 1, 30, 9, 1, 100 });
            Work(new int[] { });
            Work(new int[] { 19, });

        }
        static void Work(int[] arr)
        {
            int t = 0;
            int a = 0;
            int y = 0;
            while (t <= arr.Length)
            {
                Console.Write("Шаг {0} ",t);
                for (int i = 1; i < arr.Length; i++)
                {
                    int n = 0;

                    if (arr[i - 1] <= arr[i])
                    {

                        Console.Write("Оставляем {0} и {1} ", arr[i - 1], arr[i]);

                    }
                    else
                    {

                        Console.Write("Меняем {0} и {1} ", arr[i - 1], arr[i]);
                        n = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = n;

                    }

                }
                t++;
                Console.Write("\n");
               
            }
            while (y<= arr.Length - 1)
            {
                Console.Write(arr[a]);
                //Console.WriteLine("{0}", y);
                a++;
                y++;
              
            }
            Console.Write("\n");


            //Console.Write("Шаг 1 ");
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int n = 0;

            //    if (arr[i - 1] <= arr[i] )
            //    {

            //        Console.Write("Оставляем {0} и {1} ", arr[i - 1], arr[i]);

            //    }
            //    else
            //    {

            //        Console.Write("Меняем {0} и {1} ", arr[i - 1], arr[i]);
            //        n = arr[i - 1];
            //        arr[i - 1] = arr[i];
            //        arr[i] = n;

            //    }

            //}
            //Console.Write("\n");
            //Console.Write("Шаг 2 ");
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int n = 0;

            //    if (arr[i - 1] <= arr[i])
            //    {

            //        Console.Write("Оставляем {0} и {1} ", arr[i - 1], arr[i]);

            //    }
            //    else
            //    {

            //        Console.Write("Меняем {0} и {1} ", arr[i - 1], arr[i]);
            //        n = arr[i - 1];
            //        arr[i - 1] = arr[i];
            //        arr[i] = n;

            //    }

            //}
            //Console.Write("\n");



























            //int min = 0;
            //int temp = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    min = i;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[min])
            //        {
            //            min = j;
            //        }
            //    }
            //    temp = arr[min];
            //    arr[min] = arr[i];
            //    arr[i] = temp;

            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);

            //}

            // Console.WriteLine("\n");
        }  
    }
}
