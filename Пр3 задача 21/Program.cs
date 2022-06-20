using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("вводите значение A");
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
          
            String b;
            Console.WriteLine("вводите сзначение");
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
           
            String c;
            Console.WriteLine("вводите значение");
            c = Console.ReadLine();
            double C;
            C = double.Parse(c);

            if (A == 0)
            {

                Console.WriteLine("Уравнение y={0:F0}X^2+{1:F0}X+{2:F0} не является квадратным", A, B, C);
                return; //завершить работу прогр
            }

            else
            {
                double discriminant;
                discriminant = B * B - 4 * A * C;

                Console.WriteLine("Результат {0:F4}", discriminant);
            }



        }
    }
}
