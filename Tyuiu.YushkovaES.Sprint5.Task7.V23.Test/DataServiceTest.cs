using System.IO;
using System.Linq;
using Tyuiu.YushkovaES.Sprint5.Task7.V23.Lib;

namespace Tyuiu.YushkovaES.Sprint5.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_RemovesRussianWords()
        {
            DataService ds = new DataService();

            string dataDirectory = @"C:\Users\user\source\repos\DataSprint5";
            string inputPath = Path.Combine(dataDirectory, "InPutDataFileTask7V23.txt");

            string outputPath = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(outputPath), "Файл с результатом не создан.");

            string actual = File.ReadAllText(outputPath);
            string expected = "World! This.";

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(actual.Any(IsRussianLetter));
        }

        private static bool IsRussianLetter(char symbol)
        {
            return (symbol >= 'А' && symbol <= 'Я') ||
                   (symbol >= 'а' && symbol <= 'я') ||
                   symbol == 'Ё' || symbol == 'ё';
        }
    }
}
