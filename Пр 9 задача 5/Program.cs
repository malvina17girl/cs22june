using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_9_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String fragments = Console.ReadLine();
            String indexes = Console.ReadLine();

            String[] frags = fragments.Split(' ');
            String[] index = indexes.Split(' ');

            int[] num;
            num = new int[frags.Length];
           
            int i = 0;

            for (int y = 0; y < index.Length; y++)

            {
                i = Int32.Parse(index[y]);

                if (i < 0 || frags.Length - 1 < i)
                {
                    Console.WriteLine("Нет эллемента на индексе {}", i);

                }
                else

                {
                    Console.WriteLine("Значение элемента на индексе " + i + " это " + frags[i]);
                }
               
            }
        }
    }
}