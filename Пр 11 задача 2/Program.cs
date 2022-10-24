using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new int[] { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 },10);
            Letter(new int[] { 11, 13, 17, 19, 10, 12, 14, 15,16, 18, 20 }, 15);
            Letter(new int[] { 11, 13, 17, 19, 10, 12, 14, 15,16, 18, 20 }, 20);
            Letter(new int[] { 11, 13, 17, 19, 10, 12, 14, 15,16, 18, 20 }, 9);
            Letter(new int[] { 11, 13, 17, 19, 10, 12, 14, 15,16, 18, 20 }, 23);
            //решена полностью

        }
        static void Letter(int[] arr, int a)
        {

            for (int n = 0; n < arr.Length; n++)
            {

                Console.WriteLine( arr[n]);

                if (arr[n]==a)
                {
                    Console.WriteLine("{0} найдено", arr[n]);

                }
                

            }
            
            Console.WriteLine("________________");
        }
    }
}
