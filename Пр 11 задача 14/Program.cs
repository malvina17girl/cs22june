using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter("one two three four".Split(' '), "one four five six".Split(' '));
            Letter("one two three four".Split(' '), "one two three four".Split(' '));
            Letter("one two three four".Split(' '), " ".Split(' '));
        }
        static void Letter(string[] arr1, string[] arr2)
        {
            string[] arr3 = new string[arr1.Length];
            int y = 0;
           
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {

                    if (arr1[i] != arr2[j]) 
                    {
                        arr3[y] = arr1[i];
                        y++;

                    }
                    //if (arr1[i] == arr2[j]) //такое решение выводит одиноковые элементы массива
                    //{
                    //    arr3[y] = arr1[i];
                    //    y++;

                    //}
                }
            }
    
            Console.WriteLine("\n");

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]+" ");
            }
            Console.WriteLine("\n");
            Console.Write("----------------------");



        }
    }
}
