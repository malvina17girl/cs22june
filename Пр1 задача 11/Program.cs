using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String X;
            String Y;

            Console.Write("ввод X");
            X = Console.ReadLine();
            Console.Write("ввод Y");
            Y = Console.ReadLine();

            Console.Write("INSERT INTO points (x, y) VALUES (");

           
            Console.Write("'");
            Console.Write(X);
            Console.Write("', ");
            Console.Write("'");
            Console.Write(Y);
            Console.Write("')");

        }
    }
}
