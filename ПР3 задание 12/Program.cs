using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3_задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите значение");
            int a= Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine("вводите значение");
            int b = Convert.ToInt32(Console.ReadLine());

         
            int res1 = a / b;
            int res2 = a % b;

            Console.WriteLine("Делимое= {0:F0}, делитель= {1:F0}, частное= {2:F0}, остаток= {3:F0}", a, b, res1, res2);


        }
    }
}
