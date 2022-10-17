using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new char[] { 'z','x','c','v','b'}, new int[] { 1, 3, 5, 0, 4 });
        }
        static void Work(char[] arr, int[] arr1)
        {
            int i = 0;
            
            for (char a = arr[i]; i < arr.Length; i++)
            {

                for (int y = 0; y < arr1.Length; y++)
                {



                    Console.Write(arr[y] + " ");


                }
                Console.WriteLine(" ");



            }
        }
    }
}
