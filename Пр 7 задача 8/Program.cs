using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_7_задача_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i,j;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            string c = "#";

            b = a + 11;
            i = 0;
            j = 0;

            while (i <= b)
            {
                

                if ((i + 1) % 3 == 0)


                {  
                     Console.Write("{0} ", i);

                    while (j <i)
                    {
 
                        Console.Write(c);
                        j++;
                    }
                    
                 
                    Console.Write("\n");

                }
                else 
                {
                    Console.WriteLine(i);
                    
                }
                i++;
                j = 0;


                


                //for (int i = 0; i < b; i++)
                //{
                //    for (int j = 0; (i + 1) % 3 == 0; j ++)

                //    { 
                //        Console.WriteLine(c);
                //    }
                //    Console.WriteLine();
                //}


            }
        }
    }
}

 

