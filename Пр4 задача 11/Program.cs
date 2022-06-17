using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите значение");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("вводите значение");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("Первое");
            }


            else if (B > A)
            {
                Console.WriteLine("Второе");
            }

            else
            {
                Console.WriteLine("Числа равны");

            
        }

    }
    }
}
