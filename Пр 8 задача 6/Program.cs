using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_6
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
            int i = 0;
            int a = 0;

            while (i <= arr.Length - 1)
            {
                Console.Write(arr[a]);
                Console.WriteLine("\t {0}", i);
                i++;
                a++;
            }
        }
    }
}
