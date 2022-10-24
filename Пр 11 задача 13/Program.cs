using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'q', 'w', 'e', 'r' });
            Letter(new char[] { 'q', 'w', 'q', 'r' });
            Letter(new char[] { 'q', 'w', 'q', 'q' });
            Letter(new char[] { 'q', 'w', 'q', 'w' });
            Letter(new char[] { 'r', 'r', 'r', 'r' });
            Letter(new char[] { 'a', 'b', 'c', 'd', 'q', 'w', 'e', 'r' });

            //РЕШЕНА ПОЛНОСТЬЮ
        }
        static void Letter(char[] arr1)
        {
            int h = 0;

            for (int i = 0; i < (arr1.Length - 1); i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        h++;
                    }
                }
            }
            if (h == 0)
            {
                Console.WriteLine("ПОВТОРЕНИЙ НЕТ");
            }
            if (h > 0)
            {
                Console.WriteLine("ПОВТОРЕНИЯ ЕСТЬ");
            }
 
            Console.WriteLine("___________________________");
        }
    }
}
