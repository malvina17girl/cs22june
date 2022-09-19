using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Work(new int[] { 9, 8, 9, 1, 1, 5, 1, 1 });
                Work(new int[] { 1, 2, 3, 4, 1, 3, 4, 4, 4, 4 });
                Work(new int[] { 5, 5, 5, 5, 5 });
                Work(new int[] { });
                Work(new int[] { 1, 9, 1, 30, 9, 1, 100 });
                Work(new int[] { 1000000, 1, 1 });
        }
        static void Work(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("0,000000");
                return;
            }

            else
            {
                int sum = arr.Sum();
                //Console.WriteLine(sum);

                int mid = 0;
                mid = sum / arr.Length;

                Console.WriteLine("{0:F6}", mid);
            }



        }
    }
}
