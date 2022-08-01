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
            String data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                return;
            }
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];

            int m = Int32.Parse(Console.ReadLine());

            for (int i=0; i< arr.Length;i++)
            {
                num[i] = Int32.Parse(arr[i]) * m;

            }

            for (int i=0;i<num.Length;i++)
            {
                Console.Write(num[i]+" ");
            }
        }
    }
}
