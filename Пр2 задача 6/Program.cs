using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение aRad");
            data = Console.ReadLine();
            double aRad;
            aRad = double.Parse(data);
            double result;
            result = 180*aRad/ Math.PI;
            
            Console.Write("{0:F4} радиан это {1:F4}", aRad, result);
            Console.WriteLine(" градусов");
        }
    }
}
