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
            Letter("a".Split(' '));
            Letter("b".Split(' '));
            Letter("d".Split(' '));
            Letter("h".Split(' '));
            Letter("i".Split(' '));
            //Letter(new char[] { 'a' });
            //Letter(new char[] { 'b' });
            //Letter(new char[] { 'd' });
            //Letter(new char[] { 'h' });
            //Letter(new char[] { 'i' });
        }
        static void Letter(string[] arr)
        {
            //string data = ("a, b, c, d, e, f, g, h");
            //String[] arr1 = data.Split(',');

            string x = arr[0];
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "a")
                {
                    Console.Write("a");
                }
                if (arr[i] == "b")
                {
                    Console.Write("ab");
                }
                if (arr[i] == "d")
                {
                    Console.Write("abcd");
                }
                if (arr[i] == "h")
                {
                    Console.Write("abcdefgh");
                }
                if (arr[i] == "i")
                {
                    Console.Write("abcdefgh");
                }
            }    


                //while (i <= arr1.Length - 1)
                //{


                //if (x == arr1[i])
                //{
                //Console.Write("{0}", arr1[i]);
                //i++;
                //}

                //else
                //{
                //    return;
                //}




                Console.Write("\n");
        }
    }
}
               
