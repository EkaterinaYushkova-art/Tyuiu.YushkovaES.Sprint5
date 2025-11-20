using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        private const string OutputFileName = "OutPutDataFileTask7V23.txt";

        public string LoadDataAndSave(string path)
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
            string processedText = RemoveRussianWords(fileContent);

            string outputPath = Path.Combine(Path.GetTempPath(), OutputFileName);
            File.WriteAllText(outputPath, processedText);

            return outputPath;
        }

        private static string RemoveRussianWords(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            StringBuilder builder = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();

            foreach (char symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    currentWord.Append(symbol);
                }
                else
                {
                    AppendWord(builder, currentWord);
                    builder.Append(symbol);
                }
            }

            AppendWord(builder, currentWord);

            return NormalizeText(builder.ToString());
        }

        private static void AppendWord(StringBuilder builder, StringBuilder currentWord)
        {
            if (currentWord.Length == 0)
            {
                return;
            }

            string word = currentWord.ToString();
            if (!IsRussianWord(word))
            {
                builder.Append(word);
            }

            currentWord.Clear();
        }

        private static bool IsRussianWord(string word)
        {
            bool hasLetter = false;
            foreach (char symbol in word)
            {
                if (!char.IsLetter(symbol))
                {
                    continue;
                }

                hasLetter = true;
                if (!IsRussianLetter(symbol))
                {
                    return false;
                }
            }

            return hasLetter;
        }

        private static bool IsRussianLetter(char symbol)
        {
            return (symbol >= 'А' && symbol <= 'Я') ||
                   (symbol >= 'а' && symbol <= 'я') ||
                   symbol == 'Ё' || symbol == 'ё';
        }

        private static string NormalizeText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            string cleaned = Regex.Replace(text, @"\s{2,}", " ");
            cleaned = Regex.Replace(cleaned, @"\s+([,!.?;:])", "$1");
            cleaned = Regex.Replace(cleaned, @"([,;:])(?=[.!?])", string.Empty);
            cleaned = Regex.Replace(cleaned, @"([,!.?;:])([A-Za-z0-9])", "$1 $2");
            cleaned = Regex.Replace(cleaned, @"^[,!.?;:\s]+", string.Empty);

            return cleaned.Trim();
        }
    }
}
