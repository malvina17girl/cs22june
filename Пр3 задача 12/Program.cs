using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр3_задача_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("Длина рулона, м");
            a = Console.ReadLine();
            double totalM;
            totalM = double.Parse(a);

            if (totalM < 0)
            {

                Console.WriteLine("Длина рулона должна быть положительна");
                return; //завершить работу прогр
            }

            String b;
            Console.WriteLine("Расход на одно изделие, см");
            b = Console.ReadLine();
            double partCm;
            partCm = double.Parse(b);

            if (partCm < 0)
            {

                Console.WriteLine("Расход материала должен быть положительным");
                return; //завершить работу прогр
            }

            double totatCM;
            totatCM = totalM * 100;
            double product;
            product= totatCM / partCm;
            double ost;
            ost= totatCM % partCm;

            Console.WriteLine("Длина рулона в сантиметрах равна {0:F0} ", totatCM);
            Console.WriteLine("Из этого материала получится {0:F0} изделий и останется {1:F0} см", product, ost);


        }
    }
}
