using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YushkovaES.Sprint5.Task2.V6.Lib
{
    public class DataService : ISprint5Task2V6
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            StringBuilder sb = new StringBuilder();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Обрабатываем массив и заменяем элементы
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Заменяем положительные на 1, отрицательные на 0
                    int value = matrix[i, j] > 0 ? 1 : 0;
                    sb.Append(value);

                    if (j < cols - 1)
                    {
                        sb.Append(";");
                    }
                }
                if (i < rows - 1)
                {
                    sb.AppendLine();
                }
            }

            File.WriteAllText(path, sb.ToString());
            return path;

        }
    }
}
