using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 9, 8, 7, 6, 5, 4 });
            Work(new int[] { 10, 98, 62, 37, 50, 41, 77, 2 });
            Work(new int[] { 5, 9, 7, 2 });
            Work(new int[] { -3, - 6, - 8, - 20, - 4, - 90 });

        }
        static void Work(int[] arr)
        {
            int sum = 0;


            int i = 0;
            while (i < arr.Length-2)
               

            {

                sum = Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[i + 1]) + Convert.ToInt32(arr[i + 2]);
                Console.WriteLine("Группа " + arr[i] + "," + arr[i + 1] + "," + arr[i + 2] + "," + "сумма " + sum);

                i += 3;

            }

            if (arr.Length %3 == 2)
            {
                sum = Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[i + 1]);
                Console.WriteLine("Группа " + arr[i] + "," + arr[i + 1] + "сумма " + sum);
            }
            if (arr.Length % 3 == 1)
            {
                sum = Convert.ToInt32(arr[i]) ;
                Console.WriteLine("Группа " + arr[i] + "," +  "сумма " + sum);
            }

            //int size = 3;

            //int i = 0;

            //int[][] arrays = arr.GroupBy(s => i++ / size).Select(s => s.ToArray()).ToArray();



            //foreach (var array in arrays)

            //{


            //    Console.Write("Группа ");
            //    Console.WriteLine(String.Join(",", array) + " сумма ");


            //}
        }
    }
}
