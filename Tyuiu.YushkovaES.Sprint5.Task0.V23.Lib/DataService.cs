using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисление значения функции
            double y = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);
            y = Math.Round(y, 3);

            // Создание пути к файлу
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Запись результата в файл
            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
