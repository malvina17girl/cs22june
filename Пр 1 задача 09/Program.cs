using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_1_задача_09
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String lastName;

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

            Console.WriteLine("Меня зовут {0}, {1} {0}", lastName, firstName);
        }
    }
}
