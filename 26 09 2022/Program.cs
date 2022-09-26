using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_09_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Work(new int[] { 5, 6, 7, 8, 9 });
            Work(new int[] { 2, 3, 3, 3, 3, 4 });
            Work(new int[] { 5 });
            Work(new int[] { 4, 5, 6, 7, 3, 2, 1 });
            Work(new int[] { 9, 8 });
            Work(new int[] { 4, 5, 6, 7, 6, 7, 8 });
            Work(new int[] { });


        }
        static void Work(int[] arr)
        {
            

            if (arr.Length == 0)
            {
                Console.WriteLine("Исходная строка пуста");
                return;

            }

            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i - 1] > arr[i])
                {
                    Console.WriteLine("Элемент со значением " + arr[i] + " на индексе " + i + " нарушает закономерность");
                    return;
                }
                
                

            }
            Console.WriteLine("Значения отсортированы по возрастанию");
           

        }
    }
}