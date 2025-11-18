using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = CalculateFunction(x);
                sb.AppendLine($"{x};{Math.Round(result, 2).ToString().Replace(',', '.')}");
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }

        private double CalculateFunction(int x)
        {
            double denominator = 3 * x + 1.2;

            // Проверка деления на ноль (x = -0.4, но так как x целые, проверяем близкие значения)
            if (Math.Abs(denominator) < 0.0001)
            {
                return 0;
            }

            // F(x) = (2sin(x))/(3x+1.2) + cos(x) - 7x * 2
            // Упрощаем: 7x * 2 = 14x
            double part1 = (2 * Math.Sin(x)) / denominator;
            double part2 = Math.Cos(x);
            double part3 = 14 * x;

            return part1 + part2 - part3;
        }
    }
}
