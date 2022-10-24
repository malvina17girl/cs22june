using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new int[] { 9,8, 9, 1, 1 ,5, 1, 1 });
            //Letter(new int[] { 1, 2, 3, 4, 1, 3, 4, 4, 4, 4 });
            //Letter(new int[] { 5, 5, 5, 5, 5 });
            //Letter(new int[] { 1, 9, 1, 30, 9, 1, 100 });
            //Letter(new int[] { 1000000, 1, 1 });
        }
        static void Letter(int[] arr)
        {
            int temp = 0;
            int a = 0;
            int y = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j=i+1; j<arr.Length;j++)
                { 
                    

                    if (arr[min] > arr[j])
                    {
                        min = j;
                        Console.WriteLine("Минимальное значение {0}  на индексе {1}", arr[j], j);
                    }
                   
                    temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                    Console.Write(arr[i] + " ");

                }

                while (y <= arr.Length - 1)
                {
                Console.Write(arr[a]);

                a++;
                y++;

                }
            }
            
            
            Console.WriteLine("\n");
            for (int i=0; i< arr.Length; i++)
            { 
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("__________________________");
        }
    }
}



// Алгоритм сортировки от наимельшего к наибольшему
//int temp = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr[i] < arr[j])
//        {
//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;

//        }

//    }
//}