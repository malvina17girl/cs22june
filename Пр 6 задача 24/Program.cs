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
            int a,n,t;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            n = 0;
            t= 0;
            if (a < 0)
            {
                Console.WriteLine("Введенное значение должно быть неотрицательным");
                return; //завершить работу прогр;
            }
            while (a >n)
            {
                n++;
                Console.Write("#", n);

            }
            if (t==19)
            {
                t = 0;
                Console.Write("#\n");

               

            }


        }     
    }
}
  