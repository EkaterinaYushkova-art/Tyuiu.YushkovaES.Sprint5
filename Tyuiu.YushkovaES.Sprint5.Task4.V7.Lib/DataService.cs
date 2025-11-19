using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {


            string data = File.ReadAllText(path);

            // Исправленный парсинг с учетом культуры
            double x = double.Parse(data, CultureInfo.InvariantCulture);

            // Вычисление значения функции y = 1/cos(x) + x³
            double y = (1 / Math.Cos(x)) + Math.Pow(x, 3);
            y = Math.Round(y, 3);

            return y;
        }
    }
}
