using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР2_задача_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение катета");
            a = Console.ReadLine();
            double cathetus;
            cathetus = double.Parse(a);

            String b;
            Console.WriteLine("вводите значение угла");
            b = Console.ReadLine();
            double angleDeg;
            angleDeg = double.Parse(b);

            double c;
            c= angleDeg* Math.PI/180;

            double cos;
            cos=Math.Cos(c);

            double hypotenuse;
            hypotenuse = cathetus / cos;

            Console.WriteLine("Значение угла в радианах {0:F4} ", c);
            Console.WriteLine("Косинус этого угла {0:F4} ", cos);
            Console.WriteLine("Длина гипотенузы {0:F4} ", hypotenuse);









        }
    }
}
