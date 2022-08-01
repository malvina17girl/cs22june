using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите строку");
            String data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                return;
            }
            String[] arr = data.Split(',');

            Console.WriteLine("вводите B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("вводите строку");
            String data1 = Console.ReadLine();


            int a = 0;
            while (a<= arr.Length - 1)
            {
                if (a == B)
                {
                    arr[B] = data1;
                }
                Console.Write("{0} ", arr[a]);
                a++;
            }

        }
    }
}
