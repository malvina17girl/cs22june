using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение a");
            a = Console.ReadLine();
            String b;
            Console.WriteLine("вводите значение b");
            b = Console.ReadLine();
            String c;
            Console.WriteLine("вводите значение c");
            c = Console.ReadLine();


            Console.WriteLine("Квадратное уравнение "+ a + "*x*x + " + b + "*x +"+ c + "=0 ");
          
            Console.WriteLine("Его дискриминант вычисляется по формуле: d = " + b + "*"+b + "- 4*" +a+"*"+c);


        }
    }
}
