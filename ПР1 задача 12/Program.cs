using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1_задача_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String CX;
            String CY;
            String R;
            String fill;
            

            Console.Write("ввод CX");
            CX = Console.ReadLine();
            Console.Write("ввод CY");
            CY = Console.ReadLine();
            Console.Write("ввод R");
            R = Console.ReadLine();
            Console.Write("ввод fill");
            fill = Console.ReadLine();


            Console.Write("<circle cx=");
            
            Console.Write("'");
            Console.Write(CX);
            Console.Write("' ");

            Console.Write("cy=");

            Console.Write("'");
            Console.Write(CY);
            Console.Write("' ");

            Console.Write("r=");

            Console.Write("'");
            Console.Write(R);
            Console.Write("' ");

            Console.Write("fill=");

            Console.Write("'");
            Console.Write(fill);
            Console.Write("'");


            Console.Write("/>");
            
        }
    }
}
