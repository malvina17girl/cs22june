using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_9_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String left = Console.ReadLine();
            String right = Console.ReadLine();

           if (left.Length != right.Length)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
                return;
            } 
            
            String[] arr = left.Split(' ');
            String[] arr1 = right.Split(' ');

            int[] num;
            num= new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                num[i] = Int32.Parse(arr[i]) * Int32.Parse(arr1[i]);
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            


        }
    }
}
