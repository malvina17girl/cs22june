using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_3
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

            int a = Int32.Parse(Console.ReadLine());
            int b = a - 1;
            int c = a + 1;

            if (a < 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Число А должно быть в интервале [0, размер массива)");
                return;
            }
            if (a < 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Нет эллемента на индексе {}", a);

            }
            else

            {
                Console.WriteLine("Элемент на индексе " + a + " содержит значение " + arr[a]);
            }
            if (b < 0 || arr.Length - 1 < b)
            {
                Console.WriteLine("Предыдущий элемент не существует");

            }
            else
            {
                Console.WriteLine("Значение предыдущего элемента " + arr[b]);
            }

            if (c < 0 || arr.Length - 1 < c)
            {
                Console.WriteLine("Следующий элемент не существует");

            }
            else
            {
                Console.WriteLine("Значение следующего элемента " + arr[c]);
            }
        }
    }
}
