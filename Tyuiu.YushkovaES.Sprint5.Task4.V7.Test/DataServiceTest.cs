using Tyuiu.YushkovaES.Sprint5.Task4.V7.Lib;
using System.IO;
namespace Tyuiu.YushkovaES.Sprint5.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными (с запятой как разделитель)
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "-1,39"); // Используем запятую

            try
            {
                double result = ds.LoadFromDataFile(tempPath);

                // Проверяем вычисление для x = -1.39
                double expected = (1 / Math.Cos(-1.39)) + Math.Pow(-1.39, 3);
                expected = Math.Round(expected, 3);

                Assert.AreEqual(expected, result);
            }
            finally
            {
                // Удаляем временный файл
                if (File.Exists(tempPath))
                    File.Delete(tempPath);
            }
        }

        [TestMethod]
        public void CheckWithPointSeparator()
        {
            DataService ds = new DataService();

            // Тестируем с точкой как разделителем
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "1.5"); // Используем точку

            try
            {
                double result = ds.LoadFromDataFile(tempPath);
                double expected = (1 / Math.Cos(1.5)) + Math.Pow(1.5, 3);
                expected = Math.Round(expected, 3);

                Assert.AreEqual(expected, result);
            }
            finally
            {
                if (File.Exists(tempPath))
                    File.Delete(tempPath);
            }
        }
    }
}
