using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение угла");
            a = Console.ReadLine();
            double aInitial;
            aInitial = double.Parse(a);

            double aRemainder;
            aRemainder = aInitial % 360;

            Console.WriteLine(" наименьшее положительное значение угла {0:F0} ", aRemainder);
        }
    }
}
