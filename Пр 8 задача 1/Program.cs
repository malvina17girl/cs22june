using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String data=Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                    return;
            }
            String[] arr = data.Split(' ');
            int a = Int32.Parse(Console.ReadLine());
            if (a<0 ||arr.Length-1<a)
            {
                Console.WriteLine("Число А должно быть в интервале [0, размер массива)");
                return;
            }
            Console.WriteLine("В массиве длиной {0} ", arr.Length);
            Console.WriteLine("на индексе "+ a);
            Console.WriteLine("находится элемент со значением "  + arr[a]);
        }
    }
}
