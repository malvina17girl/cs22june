using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_4
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
            String[] arr = data.Split('#');

            int a = arr.Length - 3;

            if (a <= 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Массив слишком маленький");
                return;
            }
            
            else

            {
                Console.WriteLine("Индекс третьего элемента с конца {0} ", +a);
                Console.WriteLine("значение этого элемента " + arr[a]);
            }
        }
    }
}
