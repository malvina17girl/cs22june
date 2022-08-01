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

            

            String[] arr = data.Split(',');
            Array.Reverse(arr);
            for (int i = 0; i<arr.Length; i++)
            {

                Console.Write("{0} ", arr[i]);
            }

            
        }
    }
}

