using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите х");
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            double i;
            i = 1;
           double r;
            r = 3;

            
            Console.Write(A+" ");

            while (i <= 10)
            {
               
                Console.Write(A+r+ " ");
                
              
                i = i + 1;
                r = r + 3;

            }
           
            
        }
    }
}
