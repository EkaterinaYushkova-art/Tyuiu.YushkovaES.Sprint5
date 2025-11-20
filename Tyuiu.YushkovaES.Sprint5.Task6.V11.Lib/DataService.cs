using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        private static readonly char[] Separators = new[]
        {
            ' ', '\t', '\r', '\n', '.', ',', ';', ':', '!', '?', '-', '_', '"', '\'',
            '(', ')', '[', ']', '{', '}', '/', '\\', '|', '<', '>', '«', '»', '…'
        };

        public int LoadFromDataFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не задан.", nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл с входными данными не найден.", path);
            }

            string fileContent = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(fileContent))
            {
                return 0;
            }

            string[] words = fileContent.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            int sixLetterWords = 0;

            foreach (string word in words)
            {
                if (word.Length == 6)
                {
                    sixLetterWords++;
                }
            }

            return sixLetterWords;
        }
    }
}
