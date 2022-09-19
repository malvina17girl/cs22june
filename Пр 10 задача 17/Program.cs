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

            int size = 3;

            int i = 0;

            int[][] arrays = arr.GroupBy(s => i++ / size).Select(s => s.ToArray()).ToArray();

            

            foreach (var array in arrays)

            {

                Console.Write("{0} ", i);



                Console.Write("Группа ");
                Console.Write(String.Join(",", array) + " сумма ", sum);
                Console.WriteLine(" сумма ");

            }
        }
    }
}
