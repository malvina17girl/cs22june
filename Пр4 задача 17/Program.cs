using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр4_задача_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine().ToLower();
            
            Console.WriteLine("вводите букву");
            char x= Convert.ToChar(Console.ReadLine().ToLower());

            Console.Write("Слова начинающиеся на букву {0}: ", x)




            Console.WriteLine(text.IndexOf(x));

            
        }
    }
}
