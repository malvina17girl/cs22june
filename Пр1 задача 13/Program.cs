using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1_задача_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String user;
            String pass;
            String host;
            String port;
            String db;


            Console.Write("ввод user id");
            user= Console.ReadLine();
            Console.Write("ввод pass");
            pass = Console.ReadLine();
            Console.Write("ввод host");
            host= Console.ReadLine();
            Console.Write("ввод port");
            port= Console.ReadLine();
            Console.Write("ввод database");
            db = Console.ReadLine();


            Console.Write("User ID=");
            Console.Write(user);
            Console.Write(";");
            Console.Write("Password=");
            Console.Write(pass);
            Console.Write(";");
            Console.Write("Host=");
            Console.Write(host);
            Console.Write(";");
            Console.Write("Port=");
            Console.Write(port);
            Console.Write(";");
            Console.Write("Database=");
            Console.Write(db);
            Console.Write(";");
        }
    }
}
