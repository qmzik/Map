using System;
using System.IO;

namespace MapSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            string[] words;

            LoadWordsFromFile(out words);
            AddWords(words);

            string a = map["glossolabiolaryngeal"];

            Console.ReadKey();

            void LoadWordsFromFile(out string[] arrayOfWords)
            {
                string str = "";
                using (StreamReader stream = new StreamReader(@"C:\Users\acke2\source\repos\Map\Map\Words.txt"))
                {
                    str = stream.ReadToEnd();
                }
                str = str.Replace("\r", String.Empty);
                arrayOfWords = str.Split('\n');
            }

            void AddWords(string[] arrayOfWords)
            {
                for (int i = 0; i < arrayOfWords.Length - 1; i++)
                {
                    map[arrayOfWords[i]] = arrayOfWords[i + 1];
                }
            }
        }
    }
}
