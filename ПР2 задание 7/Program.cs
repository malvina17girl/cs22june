using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР2_задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение скорость");
            data = Console.ReadLine();
            double knots;
            knots = double.Parse(data);
            double result;
            result = knots * 2 * 0.9;

            Console.Write("{0:F2} узлов это приблезительно {1:F2}", knots, result);
            Console.WriteLine(" км/ч");

        }
    }
}
