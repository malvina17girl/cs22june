using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_6_задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return; //завершить работу прогр;
            }
            if (a <= 20)
            {
                for (int i = 0; i < a; i++)
                    Console.Write("#");
                Console.ReadKey();
            }
            if (a > 20)
            {
                int b;
                b = 20;
                for (int i = 0; i < b; b--)

                    Console.Write("*");

            }


        }     
    }
}
  