using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Letters("a; s; d; f".Split(';'));
            Letters("z;x;c;v".Split(';'));
            Letters("q;a;z;w;s;x;e;d;c".Split(';'));
            Letters(" ".Split(';'));
            Letters("x".Split(';'));
            Letters("x;x;x;x;x;x;x".Split(';'));
            //Letters(new char[] { 'a', 's', 'd', 'f' });
            //Letters(new char[] { 'z', 'x', 'c', 'v' });
            //Letters(new char[] { 'q', 'a', 'z', 'w', 's', 'x', 'e', 'd', 'c' });
            //Letters(new char[] { });
            //Letters(new char[] { 'x' });
            //Letters(new char[] { 'x', 'x', 'x', 'x', 'x', 'x', 'x' });


        }
        static void Letters(string[] arr)
        {
            string x = "x";
            

            for (int i = 0; i <= arr.Length - 1; i++)
            {
               
                if (arr[i] == x)
                {
                   
                     Console.WriteLine("Символ 'х' найден на позиции {0} ", i);

                }
               
                else
                {
                    Console.WriteLine("Символ 'х' отсутствует ");

                }


            }

        }
    }
}
