using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение скорость");
            data = Console.ReadLine();
            double V;
            V = double.Parse(data);
            double result;
            result = V*5/18;

            Console.Write("{0:F2} км/ч это {1:F2}", V, result);
            Console.WriteLine(" м/с");
        }
    }
}
