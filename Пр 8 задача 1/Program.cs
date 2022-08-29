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

            Work("qw er ty ui".Split(' '), 0);
            Work("qw er ty ui".Split(' '), 3);
            Work("q w e r t y u i o p".Split(' '), 9);
            Work("qwer tyui".Split(' '), 3);
            Work("qw er ty ui".Split(' '), -1);
            Work("".Split(' '), 0);

            String data = Console.ReadLine();
        }
        static void Work(String[] arr, int a)
        {


            if (arr.Length==0)
            {
                Console.WriteLine("Строка пуста");
                return;
            }

       
            if (a < 0 || arr.Length - 1 < a)
            {
                Console.WriteLine("Число А должно быть в интервале [0, размер массива)");
                return;
            }
            Console.WriteLine("В массиве длиной {0} ", arr.Length);
            Console.WriteLine("на индексе " + a);
            Console.WriteLine("находится элемент со значением " + arr[a]);
        }

    }
}









//Решение задачи без статического метода
//String data = Console.ReadLine();
//            if (String.IsNullOrWhiteSpace(data))
//            {
//                Console.WriteLine("Строка пуста");
//                    return;
//            }
//            String[] arr = data.Split(' ');
//int a = Int32.Parse(Console.ReadLine());
//            if (a<0 ||arr.Length-1<a)
//            {
//                Console.WriteLine("Число А должно быть в интервале [0, размер массива)");
//                return;
//            }
//            Console.WriteLine("В массиве длиной {0} ", arr.Length);
//            Console.WriteLine("на индексе "+ a);
//            Console.WriteLine("находится элемент со значением "  + arr[a]);