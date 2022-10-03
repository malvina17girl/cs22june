using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'q', 'w', 'e', 'r', 'q', 'w' }, 'e');
            Letter(new char[] { 'q', 'w', 'e', 'r', 'q', 'w', 'q', 'w', 'e', 'r', 'q', 'w', 'e' }, 't');
            Letter(new char[] { 'e', 'w', 'w', 'w', 'w', 'w' }, 'w');
            Letter(new char[] { 'r', 'r', 'r', 'r', 'r', 'r', }, 'q');


        }
        static void Letter(char[] arr, char a)
        {
            int i = 0;
            int count = 0;
         

            while (i<arr.Length)
            {
            
                if (a == arr[i])
                {
                    count++;

                    
                }
              
                i++;

            }
                Console.WriteLine(count);
        }

    }
}
