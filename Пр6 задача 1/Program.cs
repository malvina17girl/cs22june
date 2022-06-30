using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Предисловие");
            int i;
            i = 1;
            while (i<=7)
            { Console.WriteLine("Глава " + i);
                i = i + 1;

            }
            Console.WriteLine("Послесловие");

        }
    }
}
