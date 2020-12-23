using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossword2
{

    class Program
    {
        static void Main(string[] args)
        {

            string text = @"C:\Users\Dell\Downloads\оп\words.txt"; //кот волк авокадо //хомяк жираф антелопа колобок
            string s1 = FileRead(text);

            string[] textlist = s1.Split(' '); // делим на массив наш текстовый файл
            int N = textlist.Length;
            Console.WriteLine("\n  Количество слов: " + N);
            Console.WriteLine("  Слова использованные в кроссворде: ");
            IEnumerable<string> sort = textlist.OrderByDescending(s => s.Length); // сорт от длинного до короткого
            string[] numbers = sort.ToArray(); //переводим все в массив

            for (int i = 0; i < numbers.Length; i++) //вывод массива на консоль
            {
                Console.WriteLine(" → " + numbers[i]);
            }

            Console.SetCursorPosition(15, 10);
            Console.WriteLine(numbers[0]);

            SameLetter(numbers[0], numbers[1], numbers, 1);
            SameLetter(numbers[0], numbers[2], numbers, 2);
            SameLetter(numbers[0], numbers[3], numbers, 3);

            Console.ReadKey();
        }

        static string FileRead(string path)
        {
            StreamReader sr = new StreamReader(path);
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
        static string SameLetter(string word1, string word2, string[] array, int k)
        {
            string n = "0";
            //string[] checker = new string[2];

            for (int i = 0; i < word1.Length; i++) //1
            {
                for (int j = 0; j < word2.Length; j++) //2 слово
                {

                    if (word1[i] == word2[j]) // 1 со всеми буквами из 2
                    {
                        V_Vivod(array, i, j, k);
                                               
                    }
                }
            }

            return n;
        }

        static string V_Vivod(string[] arr, int m, int n, int k) 
        {
            for (int a = 0; a < arr[k].Length; a++)
            {
                Console.SetCursorPosition(15 + m, 10 - n + a);
                Console.WriteLine(arr[k][a]);

            }

            return null;
        }
    }
}
