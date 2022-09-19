using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_10_задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 100; i <= 1000; i++)
                if (i % 13 == 0)
                {
                   count++;
               
                }


            Console.WriteLine(count);
        }
    }
}
