using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


           

            for (int i = 100; i <= 500; i++)

            {
                Console.Write(sum +" ");
                sum += i;
            
            }
           
            Console.WriteLine("Ответ: "+ sum);
        }
    }
}


