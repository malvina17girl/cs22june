using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_02
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение a");
            data = Console.ReadLine();
            float a;
            a = float.Parse(data);
            Console.WriteLine("Значение a: {0:F4}", a);

            Console.WriteLine("вводите значение b");
            data = Console.ReadLine();
            float b;
            b = float.Parse(data);
            Console.WriteLine("Значение b: {0:F4}", b);

            Console.WriteLine("вводите значение c");
            data = Console.ReadLine();
            float c;
            c = float.Parse(data);
            Console.WriteLine("Значение c: {0:F4}", c);
        }
    }
}
