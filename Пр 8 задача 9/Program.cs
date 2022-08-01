using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_9
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

            if (B >= arr.Length || B < 0)
            {
                Console.WriteLine("Число В должно быть в интервале {0}", arr.Length);
                return;
            }
            if (E >= arr.Length || E < 0)
            {
                Console.WriteLine("Число E должно быть в интервале {0}", arr.Length);
                return;
            }
            while (B == E)
            {
                Console.Write("{0} ", arr[E]);
                return;
            }

            while (B < arr.Length - 1 && arr.Length <= 5)
            {
                Console.Write("{0} ", arr[B]);
                B++;

            }

            while (B < E && B < arr.Length && arr.Length > 5)
            {
                Console.Write("{0} ", arr[B]);
                B++;

            }

            while (B >= E && E <= arr.Length && arr.Length > 5)
            {
                Console.Write("{0} ", arr[E]);
                E++;

            }
        }
    }
}
