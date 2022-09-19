using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Work("1 1 1 3 4 1".Split(' '), 3);
            Work("1 2 3 4 1 2".Split(' '), 2);
            Work("3 4 1 2 3 4 1 2 3 1 2".Split(' '), 0);
            Work("4 2 3 4 3 2".Split(' '), 4);
            Work("4 4 4 4 4 3 2 1".Split(' '), 7);
            Work("4 4 4 4".Split(' '), 1);
            Work("1 1 1 3 4 1".Split(' '), -5);
            Work("1 2 3".Split(' '), 10);

            String data = Console.ReadLine();

        }
        static void Work(String[] arr, int a)
        {

            
            if (a < 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
                Console.WriteLine("\n");
                return;
            }

            Console.WriteLine("на позиции В находится элемент" + arr[a]);
            Console.WriteLine("\n");
        }
    }
}
