using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String accountBalance;
            String messageText;

            accountBalance = "0,37 ";
            Console.WriteLine("Задача 7365");

            messageText = "Пора пополнить счет!\n";
            messageText = messageText + "Баланс Вашего счета составляет ";
            messageText = messageText + accountBalance;
            messageText = messageText + "руб";

            Console.WriteLine(messageText);

        }
    }
}
