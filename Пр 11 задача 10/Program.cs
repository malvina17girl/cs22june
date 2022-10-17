using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Letters("a s d f a".Split(' '), "a s d f a".Split(' '));
            Letters("a s d f a".Split(' '), "a s d f g".Split(' '));
            Letters("qwerty asdfgh zxcvb".Split(' '), "qwerty asdfgh asdfgh".Split(' '));
            Letters("qaz wsx edc".Split(' '), "wsx edc qaz".Split(' '));
            Letters("qaz wsx edc".Split(' '), "qaz wsx edc rfv".Split(' '));
            //Letters("qaz wsx edc rfv tgb".Split(' '), "qaz wsx edc rfv".Split(' '));
            //Letters("qaz wsx edc".Split(' '), "qaz tgb ujm yhn".Split(' '));
            //Letters("qaz tgb ujm yhn".Split(' '), "qaz wsx edc".Split(' '));
        }
        static void Letters(string[] arr1, string[] arr2)
        {

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("Массивы начинают различаться на индексе {0} ", i);
                        return;
                    }
                }
            }
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("Массивы начинают различаться на индексе {0} ", i);
                        return;
                    }
                }
            }
            if (arr1.Length < arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("Массивы начинают различаться на индексе {0} ", i);
                        return;
                    }
                }
            }
        }
    }
}
