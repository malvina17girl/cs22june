using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String id;
            Console.Write("ввод id");
            id = Console.ReadLine();
            Console.Write("SELECT first_name, last_name, group FROM students WHERE student_id = '");
         
            Console.Write(id);
            Console.Write("' ");
            
        }
    }
}
