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
            //Letter(new char[] { 'r', 'r', 'r', 'r', 'r', 'r', });
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
            int n = 0;
            int k = 0;

            int[] arr3 = new int[arr.Length];

            while (i < arr.Length)
            {

                if (a == arr[i])
                {
                    counta++;
             
                }
                
                i++;
                y++;
            }
            
            while (n < arr.Length)
            {
                if (a == arr[n])
                {
                    arr3[k] = counta;
                    

                }
                n++;
                k++;
            }

            i = 0;y = 0;k = 0; n=0;
            while (i < arr.Length)
            {

                if (b == arr[i])
                {
                    countb++;

                }
               

                i++;
                y++;
            }
            
            while (n < arr.Length)
            {
                if (b == arr[n])
                {
                    arr3[k] = countb;
                   

                }
                n++;
                k++;

            }
            i = 0; y = 0; k = 0; n = 0;

            while (i < arr.Length)
            {
                if (c == arr[i])
                {
                    countc++;

                }


                i++;
                y++;
            }
            
            while (n < arr.Length)
            {
                if (c == arr[n])
                {
                    arr3[k] = countc;
                 

                }
                n++;
                k++;

            }
            i = 0; y = 0; k = 0; n = 0;

            while (i < arr.Length)
            {
                if (d == arr[i])
                {
                    countd++;

                }


                i++;
                y++;
            }

            while (n < arr.Length)
            {
                if (d == arr[n])
                {
                    arr3[k] = countd;
                    

                }
                n++;
                k++;

            }
            int q = 0;
            while (q<=arr.Length-1)
            {
                Console.Write(arr3[q]);
                q++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("______________________");
        }
    }
    
}

