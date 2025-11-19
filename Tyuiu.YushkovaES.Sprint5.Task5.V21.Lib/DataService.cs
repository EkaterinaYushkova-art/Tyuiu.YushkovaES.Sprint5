using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
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
            string[] tokens = fileContent
                .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int? maxEvenInteger = null;

            foreach (string token in tokens)
            {
                if (!TryParseNumber(token, out double number))
                {
                    continue;
                }

                if (!IsInteger(number))
                {
                    continue;
                }

                int intValue = (int)Math.Round(number);
                if (intValue % 2 != 0)
                {
                    continue;
                }

                if (maxEvenInteger == null || intValue > maxEvenInteger.Value)
                {
                    maxEvenInteger = intValue;
                }
            }

            if (maxEvenInteger == null)
            {
                throw new InvalidOperationException("В файле нет целых чисел, кратных двум.");
            }

            double factorial = CalculateFactorial(maxEvenInteger.Value);
            return Math.Round(factorial, 3, MidpointRounding.AwayFromZero);
        }

        private static bool TryParseNumber(string value, out double result)
        {
            return double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out result) ||
                   double.TryParse(value, NumberStyles.Float, CultureInfo.GetCultureInfo("ru-RU"), out result);
        }

        private static bool IsInteger(double value)
        {
            return Math.Abs(value - Math.Round(value)) < 1e-9;
        }

        private double CalculateFactorial(int n)
        {
            if (n < 0) return 0;
            if (n == 0 || n == 1) return 1;

            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
