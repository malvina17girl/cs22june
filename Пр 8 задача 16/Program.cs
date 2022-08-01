using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите символы");
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            Console.WriteLine("вводите B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("вводите E");
            int E = int.Parse(Console.ReadLine());

            int a = 0;
            string n = "k";

            Console.WriteLine("Меняю " + arr[B] + " на " + arr[E]);

            n = arr[B];
            arr[B] = arr[E];
            arr[E] = n;
            while (a <= arr.Length - 1)
            {
                
                Console.Write("{0} ", arr[a]);
                a++;
            }
        }
    }
}
