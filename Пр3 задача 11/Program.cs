using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x1;
            Console.WriteLine("вводите значение A");
            x1 = Console.ReadLine();
            double Ax;
            Ax = double.Parse(x1);

            String y1;
            Console.WriteLine("вводите значение B");
            y1 = Console.ReadLine();
            double Ay;
            Ay = double.Parse(y1);

            String x2;
            Console.WriteLine("вводите значение A");
            x2 = Console.ReadLine();
            double Bx;
            Bx = double.Parse(x2);

            String y2;
            Console.WriteLine("вводите значение B");
            y2 = Console.ReadLine();
            double By;
            By = double.Parse(y2);

            double amod;
            double bmod;
            amod = Math.Sqrt(Ax * Ax + Ay * Ay);
            bmod = Math.Sqrt(Bx * Bx + By * By);

            double product;
            product = Ax * Bx + Ay * By;

            double angle;
            double N;
            N = product / (amod * bmod);

         

            angle=Math.Acos(N);
            double result;
            result= 180*angle/Math.PI;

            Console.WriteLine("модуль вектора А {0:F4}", amod);
            Console.WriteLine("модуль вектора B {0:F4}", bmod);
            Console.WriteLine("Скалярное произведение векторов = {0:F4}", product);
            Console.WriteLine(" = {0:F4}", result);

        }
    }
}
