using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter("q a z".Split(' '), "q w e".Split(' '));
            Letter("qw fg hj ty kl".Split(' '), "qw er ty ui op".Split(' '));
            Letter("oiuy hjkl vbmn".Split(' '), "asdf ghjk".Split(' '));

            //решена полностью!
        }
        static void Letter(string[] arr1, string[] arr2)
        {
            int counta = 0;

            for (int i=0; i<arr1.Length;i++)
            { 
                for (int j=0;j<arr2.Length;j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        counta++;

                    }
                }
                    
            }
            Console.WriteLine("Повторений:{0}", counta);

        }
    }
}
