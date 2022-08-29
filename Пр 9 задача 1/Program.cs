using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_9_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Work(new int[] { 9, 8, 7, 6, 5, 4 }, 31);
            Work(new int[] { 9, 8, 7, 6, 5, 4 }, -3);
            Work(new int[] { 98, 76, 54 }, 11);
            Work(new int[] { }, 73);

            String data = Console.ReadLine();

        }

        static void Work(int[] arr, int m)
        { 

            if (arr.Length==0)
            {
                Console.WriteLine("Строка пуста");
                return;
            }
          
            int[] num = new int[arr.Length];

            for (int i=0; i< arr.Length;i++)
            {
                num[i] = arr[i] * m;


            }
            
            for (int i=0;i<num.Length;i++)
            {
                Console.Write(num[i]+" ");
                
                
            }
            Console.Write("\n");
            Console.WriteLine("------");
            
        }

        
    }
}




//String data = Console.ReadLine();
//            if (String.IsNullOrWhiteSpace(data))
//            {
//                Console.WriteLine("Строка пуста");
//                return;
//            }
//            String[] arr = data.Split(' ');
//int[] num = new int[arr.Length];

//int m = Int32.Parse(Console.ReadLine());

//            for (int i=0; i<arr.Length;i++)
//            {
//                num[i] = Int32.Parse(arr[i]) * m;

//            }

//            for (int i=0;i<num.Length;i++)
//            {
//                Console.Write(num[i]+" ");
//            }