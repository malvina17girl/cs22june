using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 1, 2, 3, 4, 1, 2 },1,3);
            Work(new int[] { 3, 4, 4, 2, 3, 4, 1, 2, 3, 1, 2 }, 8, 10);
            Work(new int[] { 11, 12, 13, 5, 11, 12 }, 1, 4);
            Work(new int[] { 4, 2, 3, 4, 3, 2 }, 0, 5);
            Work(new int[] { 4, 4, 4, 4, 4, 3, 2, 1 }, 0, 5);
            Work(new int[] { 1, 2, 3, 4, 1, 2 }, 4, 2);
            //Work(new int[] { 4, 4, 4, 4 }, 1, 7);
            //Work(new int[] { 4, 3 }, -1, 0);
            //Work(new int[] { 1, 2, 3, 4 }, 5, 10);


        }
        static void Work(int[]arr,int a,int b)
        {

            int i = 0;
            int min = arr[a];

            while (i< arr.Length)
            
            {
                if (i >= a && i <= b)
                {
                    Console.Write(arr[i] + " ");
                }

                if (i >= b && i <= a)
                {
                    Console.Write(arr[i] + " ");
                }
                i++;
            }
            Console.Write("\n");

            for (int y=a;y<=b;y++ )
            {
               
               if (arr[y] < min)
               {
                  min = arr[y];    
               }
            
            }

            Console.WriteLine("В массиве минимальный элемент {0}", min);
            Console.WriteLine("--------------------------------");
        }
    }
}
