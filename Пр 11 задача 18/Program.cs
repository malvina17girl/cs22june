using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new int[] { 5, 4, 6, 2, 3, 1 });
            Letter(new int[] { 1, 2, 3, 4, 1, 2 });
            Letter(new int[] { 3,4, 1, 2, 3, 4, 1, 2, 3, 1, 2 });
            Letter(new int[] { 4, 2, 3, 4, 3, 2 });
            Letter(new int[] { 4, 4, 4, 4, 4, 3, 2, 1 });
            Letter(new int[] { 4, 4, 4, 4 });
            Letter(new int[] { 4, 3 });
            //решена полностью
        }
        static void Letter(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
           int y = 0;
            
            int[] arr3 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr3[y] = arr[i] - min;
                y++;

            }
            for (y = 0; y < arr3.Length; y++)
            {
                Console.Write(arr3[y] + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("----------------------");

        }
    }
}
