using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8_задача_11
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
            int a = arr.Length - 1;
            int t = 0;

          
            if (a <= 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Массив слишком маленький");
                return;
            }

            else

            {
                Console.WriteLine("Индекс последнего элемента  {0} ", +a);
                Console.WriteLine("значение последнего элемента " + arr[a]);

            }

            int n = 0;
          
            
            Console.WriteLine("Вместо " + arr[n] + " запишем "+ arr[a]);
            arr[0] = arr[arr.Length - 1];
            Console.WriteLine("Элементы массива" );
            while (t <= arr.Length-1)
            {
                Console.Write("{0} ", arr[t]);
                t++;
            }


           





        }
    }
}

