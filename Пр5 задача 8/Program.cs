using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр5_задача_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число redA");
            int redA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число redB");
            int redB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число greenA");
            int greenA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число greenb");
            int greenB = Convert.ToInt32(Console.ReadLine());
            
                if (greenA < redB && greenA < greenB && redA < redB && redA < greenB)
                {
                    Console.WriteLine("Интервалы пересекаются");
                }
                if (redA < redB && redA < greenB && greenA > redB && greenA < greenB)
                {
                    Console.WriteLine("Интервалы не пересекаются. Правый край красного левее левого края зеленого.");
                }
                if (redA < redB && redA > greenB && greenA < redB && greenA < greenB) 
                {
                    Console.WriteLine("не пересекаются. Правый край зеленого левее левого края красного");
                }
                if (redA > redB && redA < greenB && greenA > redB && greenA < greenB) 
                {
                    Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
                }
        }
    }
}
