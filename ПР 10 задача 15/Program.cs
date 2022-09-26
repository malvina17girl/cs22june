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

           
            Console.WriteLine("вводите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("вводите y");
            int y = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 1, 2 };


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



        }
    }
}