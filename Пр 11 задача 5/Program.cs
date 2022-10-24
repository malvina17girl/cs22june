using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'a', 'x');
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'y', 'd');
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'b', 'f');
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'w', 'u');
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'e', 'e');
            Letters(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c', 'd', 'e' }, 'i', 'i');

            //решена полностью
        }
        static void Letters(char[] arr, char a, char b)
        {
            int count = 0;
            int count1 = 0;
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    count++;
                }
                if (arr[i] == b)
                {
                    count1++;
                }
            }
            if (count==0)
            {
                Console.WriteLine($"Символ {a} отсутствует ");
            }
            if (count > 0)
            {
                Console.WriteLine($"Символ {a} найден ");
            }
            if (count1 == 0)
            {
                Console.WriteLine($"Символ {b} отсутствует ");
            }
            if (count1 > 0)
            {
                Console.WriteLine($"Символ {b} найден ");
            }

            Console.WriteLine("----------------------");
        }
    }
}

    
    
