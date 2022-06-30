using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("фунт \t грамм");

            int i;
            i = 1;
            int r;
            r = i * 453;


            while (i <= 20)
            {
                Console.WriteLine("{0:F0}\t {1:F0}",i,r);
              
                i = i + 1;
                r = i * 453;

            }
           
        }
    }
}
