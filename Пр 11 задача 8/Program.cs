using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'q', 'w', 'e', 'e', 'q', 'w' });
            Letter(new char[] { 'q', 'w', 'e', 'r', 'q', 'w', 'e', 'r', 'q', 'w', 'e' });
            Letter(new char[] { 'e', 'w', 'w', 'w', 'w', 'w' });
            Letter(new char[] { 'r', 'r', 'r', 'r', 'r', 'r', });
        }
        static void Letter(char[] arr)
        {
            char a = 'q';
            char b = 'w';
            char c = 'e';
            char d = 'r';

            int i = 0;
            int y = 0;
            int counta = 0;
            int countb = 0;
            int countc = 0;
            int countd = 0;

            char[] arr3 = new char[arr.Length];

            while (i < arr.Length)
            {

                if (a == arr[i])
                {
                    counta++;

                    arr[i] = Convert.ToChar(counta);

                    //arr3[y] = arr[i];
                    //y++;
                    Console.WriteLine(arr[i]);
                }
                //    if (b == arr[i])
                //    {
                //        countb++;
                //        arr[i] = Convert.ToChar(countb);
                //        arr3[y] = arr[i];
                //        y++;
                //    }
                //    if (c == arr[i])
                //    {
                //        countc++;
                //        arr[i] = Convert.ToChar(countc);
                //        arr3[y] = arr[i];
                //        y++;
                //    }
                //    if (d == arr[i])
                //    {
                //        arr[i] = Convert.ToChar(countd);
                //        arr3[y] = arr[i];
                //        y++;
                //    }

                //    i++;
            }


            //    Console.WriteLine(arr3);
        }
    }
    
}

