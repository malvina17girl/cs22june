using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp;
            

            Console.WriteLine("Задача 1976");
            Console.WriteLine("Введите высоту прямоугольника");
            //Инициализируйте переменную temp - получите от пользователя строку и запишите ее в temp.
            temp = Console.ReadLine();
            //Инициализируйте переменную height - запишите в нее результат преобразования temp в число.
            double heigh;
            heigh = double.Parse(temp);
            Console.WriteLine("Введите ширину прямоугольника");
            temp = Console.ReadLine();
            double width;
            width = double.Parse(temp);

            double area;
            area = heigh * width;
            Console.WriteLine("{0:F0}Результат: Площадь прямоугольника =", area);
           // Console.WriteLine("Результат: Площадь прямоугольника =" + area);




        }
    }
}
