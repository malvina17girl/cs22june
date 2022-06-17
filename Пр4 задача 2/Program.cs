using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            Console.WriteLine("вводите значение");
            data = Console.ReadLine();
            double K;
            K = double.Parse(data);
            

            if (K <= 0)
            {
                double N;
                N = K*K;
                Console.WriteLine("Квадрат из = {0:F4}, равен = {1:F4}", K, N);
            }
            if (K > 0)
            {
                double S;
                S = Math.Sqrt(K);
                Console.WriteLine("Корень из = {0:F4}, равен = {1:F4}", K, S);
                {
               
            
        }
            }
        }
    }
}

