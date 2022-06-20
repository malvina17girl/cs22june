using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Sin(double.Parse(Console.ReadLine()) * Math.PI / 180);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
