using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_10_задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 1, 2, 3, 4, 1, 2 },1,33);
            Work(new int[] { 1, 2, 3, 4, 1, 2 },3,55);
            Work(new int[] { 1, 2, 3, 4, 1, 2 },5,1);

        }

        static void Work(int[] arr, int x, int y)
        {
            int a = 0;
            while (a <= arr.Length - 1)
            {
                if (arr[a] == x)
                {
                    arr[a] = y;
                }
                Console.Write("{0} ", arr[a]);
                a++;
            }
            Console.WriteLine("\n");
        }



        
    }
}