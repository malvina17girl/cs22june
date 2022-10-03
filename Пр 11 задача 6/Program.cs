using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Letter("a".Split(' '));
            //Letter("b".Split(' '));
            //Letter("d".Split(' '));
            //Letter("h".Split(' '));
            //Letter("i".Split(' '));
            Letter('a');
            Letter('b');
            Letter('d');
            Letter('h');
            Letter('i');
        }
        static void Letter(char a)
        {
            //string data = ("a, b, c, d, e, f, g, h");
            //String[] arr1 = data.Split(',');

            for (char letter = 'a'; letter <= 'h'; letter++)
            {
                Console.Write("{0}", letter);
                

                if (a == letter)
                {
                    Console.Write("\n");

                    return; 

                }
                
          
            }
           


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == "a")
            //    {
            //        Console.Write("a");
            //    }
            //    if (arr[i] == "b")
            //    {
            //        Console.Write("ab");
            //    }
            //    if (arr[i] == "d")
            //    {
            //        Console.Write("abcd");
            //    }
            //    if (arr[i] == "h")
            //    {
            //        Console.Write("abcdefgh");
            //    }
            //    if (arr[i] == "i")
            //    {
            //        Console.Write("abcdefgh");
            //    }
            //}    








        }
    }
}
               
