using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_9_поиск_решения
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'q', 'a', 'z', 'w', 's', 'x' }, new char[] { 'q', 'w', 'e' });
        }
        static void Letter(char[] arr1, char[] arr2)
        {
            int w = Convert.ToInt32(arr1.Length);
            int n = 0;
            int k = 0;
            int m = 0;
            int h = Convert.ToInt32(arr2.Length);
            int i = 0;
            
            Console.Write(" ");
            while (w > n)
            {
                Console.Write(" "+arr1[n]);
                n++;
            }

            Console.WriteLine(" ");
           
            while ( h>i)
            {
                Console.Write(arr2[i]);

                for (k = 0; k < w; k++)
                {
                    if (arr1[k] == arr2[i])
                    {
                        Console.Write(" "+"+");
                    }
                    else
                    {
                        Console.Write(" "+"*", arr2[i]);
                    }
                  
                }
                Console.Write("|");
                Console.Write("\n");
                i++;

            }
            
            while (w > m)
            {
                Console.Write(" " +"-", m);
                m++;
            }
            Console.Write("\n");

        }
    }
}
