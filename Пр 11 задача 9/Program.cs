using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_11_задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter(new char[] { 'q', 'a', 'z', 'w', 's', 'x' }, new char[] { 'q', 'w', 'e' });
            //Letter(new char[] { 'e','d','c'}, new char[] { 'a','s','d','f','g','h','j'});
            //Letter(new char[] { 'a', 'a', 'a', 'a' }, new char[] { 'a', 'a', 'a', 'a' });

        }
        static void Letter(char[] arr1, char[] arr2)
        {
            int i = 0;
            int y = 0;

            for (y = 0; y < arr1.Length; y++)
            {
                Console.Write("  " + arr1[y]);

            }
            Console.WriteLine("\n");

            for (i = 0; i < arr2.Length; i++)
            {
                //Console.WriteLine(arr2[i]+" ");
                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("{0} +", arr2[i]);
                }
                else
                {
                    Console.WriteLine("{0}", arr2[i] + " ");
                }
            }
            for (int a = 0; a < arr1.Length; a++)
            {
                Console.Write("  " + "-");
            }
            Console.Write("\n  ");
        }
    }
}





//Console.Write("Введите кол-во элементов в первом массиве:\n");
//string countMas1 = Console.ReadLine();

//Console.Write("Введите кол-во элементов во втором массиве:\n");
//string countMas2 = Console.ReadLine();

//int cM1 = Convert.ToInt32(countMas1);
//int cM2 = Convert.ToInt32(countMas2);

//string[] mas1 = new string[cM1];
//string[] mas2 = new string[cM2];

//Console.WriteLine("Первый массив");
//for (int i = 0; i < cM1; i++)
//{
//    //вводим элемент и нажимает Enter
//    mas1[i] = Console.ReadLine();
//}

//Console.WriteLine("Второй массив");
//for (int i = 0; i < cM2; i++)
//{
//    mas2[i] = Console.ReadLine();
//}

////mas3- массив, в который будет содержать строки для вывода на экран конечного решения
//string[] mas3 = new string[mas2.Length + 2];
////mas3[0]- самая первая строка с первым массивом. Необходимо впереди поставить два пробела и каждый элемент отделять пробелом
//string mH = " ";
//foreach (string m1 in mas1)
//{
//    mH += m1 + " ";
//}
//mas3[0] = mH;

////с-начинается с 1 так как индекс 0 уже занят первой строкой-с потом будет увеличиваться с++
//int c = 1;
////идем в цикле по второму массиву затем по первому-если элементы одинаковые то ставим + иначе пробелы
//foreach (string m1 in mas2)
//{
//    string mD = m1 + " ";
//    foreach (string m2 in mas1)
//    {
//        if (m1 == m2)
//        {
//            mD += "+ ";
//        }
//        else
//        {
//            mD += " ";
//        }
//    }
//    //в конце ставим |
//    mD += "|";
//    mas3[c] = mD;
//    //увелииваем индекс
//    c++;
//}

////формирование нижних подчеркиваний последней строки
//string mCh = " ";
//for (int i = 0; i < mas1.Length; i++)
//{
//    mCh += "--";
//}
//mas3[mas3.Length - 1] = mCh;

////Вывод конечного результата
//foreach (string m3 in mas3)
//{
//    Console.WriteLine(m3);
//}

//Console.ReadLine();











