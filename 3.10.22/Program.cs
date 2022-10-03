using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'a' });
            Letter(new char[] { 'd' });
            Letter(new char[] { 'h' });
            Letter(new char[] { 'i' });
            Letter(new char[] { 'z' });

        }
        static void Letter(char[] arr)
        {
            char x = arr[0];



            for (char letter = 'a'; letter <= 'h'; letter++)
            {

                if (x == letter)
                {
                    Console.WriteLine("{0} найдено", letter);

                }
                else
                {
                    Console.WriteLine(letter);

                }


            }
        }
    }
}

