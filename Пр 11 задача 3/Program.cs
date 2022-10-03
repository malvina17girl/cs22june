using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Letters("-.. --- -... .-. -.-- .--- -.. . -. --.--".Split(' '));
            Letters(".--. . .-. . -.. .- .-- .- .--- - . -- . -.. .-.. . -. -. . .".Split(' '));
            Letters(".-.- -. .. ---. . --. --- -. . .--. --- -. .. -- .- ..--".Split(' '));
            Letters(".--. --- -- --- --. .. - .".Split(' '));
            Letters("-. .- -. .- ... . -.. . - ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--.. ..--..".Split(' '));
            Letters("-.- --- --- .-. -.. .. -. .- - -.-- -.-. . .-.. .. .---- ...-- .. ----. -----".Split(' '));
            Letters(".--. .-. --- -- .- ....".Split(' '));
            Letters(".--. --- .--. .- .-..".Split(' '));
            Letters("-.- --- -. . -.-. ... .-- .-.- --.. ..".Split(' '));

        }
        static void Letters(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == "..--..")
                {
                    Console.Write("?");
                }
                if (arr[i] == ".-")
                {
                    Console.Write("А");
                }
                if (arr[i] == "-...")
                {
                    Console.Write("Б");
                }
                if (arr[i] == ".--")
                {
                    Console.Write("В");
                }
                if (arr[i] == "--.")
                {
                    Console.Write("Г");
                }
                if (arr[i] == "-..")
                {
                    Console.Write("Д");
                }
                if (arr[i] == ".")
                {
                    Console.Write("Е");
                }
                if (arr[i] == "...-")
                {
                    Console.Write("Ж");
                }
                if (arr[i] == "--..")
                {
                    Console.Write("З");
                }
                if (arr[i] == "..")
                {
                    Console.Write("И");
                }
                if (arr[i] == ".---")
                {
                    Console.Write("Й");
                }
                if (arr[i] == "-.-")
                {
                    Console.Write("К");
                }
                if (arr[i] == ".-..")
                {
                    Console.Write("Л");
                }
                if (arr[i] == "--")
                {
                    Console.Write("М");
                }
                if (arr[i] == "-.")
                {
                    Console.Write("Н");
                }
                if (arr[i] == "---")
                {
                    Console.Write("О");
                }
                if (arr[i] == ".--.")
                {
                    Console.Write("П");
                }
                if (arr[i] == ".-.")
                {
                    Console.Write("Р");
                }
                if (arr[i] == "...")
                {
                    Console.Write("С");
                }
                if (arr[i] == "-")
                {
                    Console.Write("Т");
                }
                if (arr[i] == "..-")
                {
                    Console.Write("У");
                }
                if (arr[i] == "..-.")
                {
                    Console.Write("Ф");
                }
                if (arr[i] == "....")
                {
                    Console.Write("Х");
                }
                if (arr[i] == "-.-.")
                {
                    Console.Write("Ц");
                }
                if (arr[i] == "---.")
                {
                    Console.Write("Ч");
                }
                if (arr[i] == "----")
                {
                    Console.Write("Ш");
                }
                if (arr[i] == "--.-")
                {
                    Console.Write("Щ");
                }
                if (arr[i] == "--.--")
                {
                    Console.Write("Ъ");
                }
                if (arr[i] == "-.--")
                {
                    Console.Write("Ы");
                }
                if (arr[i] == "-.--")
                {
                    Console.Write("Ь");
                }
                if (arr[i] == "..-..")
                {
                    Console.Write("Э");
                }
                if (arr[i] == "..--")
                {
                    Console.Write("Ю");
                }
                if (arr[i] == ".-.-")
                {
                    Console.Write("Я");
                }
                if (arr[i] == ".----")
                {
                    Console.Write("1");
                }
                if (arr[i] == "..---")
                {
                    Console.Write("2");
                }
                if (arr[i] == "...--")
                {
                    Console.Write("3");
                }
                if (arr[i] == "....-")
                {
                    Console.Write("4");
                }
                if (arr[i] == ".....")
                {
                    Console.Write("5");
                }
                if (arr[i] == "-....")
                {
                    Console.Write("6");
                }
                if (arr[i] == "--...")
                {
                    Console.Write("7");
                }
                if (arr[i] == "---..")
                {
                    Console.Write("8");
                }
                if (arr[i] == "----.")
                {
                    Console.Write("9");
                }
                if (arr[i] == "-----")
                {
                    Console.Write("0");
                }
                
            }
            Console.WriteLine("\n");
        }
    }
}
