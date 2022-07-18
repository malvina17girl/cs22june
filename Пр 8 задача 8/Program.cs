using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_8
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

            int i = 0;
            int a = 0;

            String[] arr = data.Split(',');


            while (i >= arr.Length - 1)
            {
                Console.Write(arr[a]);
                
              
                a--;
            }
        }
    }
}
