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
            int min = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
               
            }

             Console.WriteLine("\n");
        }  
    }
}
