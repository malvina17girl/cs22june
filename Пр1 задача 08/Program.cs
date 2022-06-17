using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_08
{
    class Program
    {
        static void Main(string[] args)
        {
           String companyName;
           String productName;
           String productCost;
           String messagePart;
         
           Console.WriteLine("Задача 1910");
           Console.WriteLine("Введите название компании");
           companyName = Console.ReadLine();
           Console.WriteLine("Введите наименование товара");
           productName = Console.ReadLine();
           Console.WriteLine("Введите цену товара");
           productCost = Console.ReadLine();
           messagePart = "Распродажа в " + companyName + "!";
            Console.WriteLine(messagePart);
            messagePart = "Наши " + productName + " по супер цене" + "! " + "Всего " + productCost + "!";
            Console.WriteLine(messagePart);
            Console.WriteLine("Торопитесь, предложение ограничено!");
        }
    }
}
