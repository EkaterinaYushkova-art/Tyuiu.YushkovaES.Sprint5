using Tyuiu.YushkovaES.Sprint5.Task2.V6.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileData()
        {
            DataService ds = new DataService();

            // Тестовый массив из условия
            int[,] matrix = new int[3, 3]
            {
                { -2, 1, 8 },
                { -4, -7, 8 },
                { 6, 5, 5 }
            };

            string path = ds.SaveToFileTextData(matrix);

            // Проверка что файл создан
            Assert.IsTrue(File.Exists(path));

            // Проверка содержимого файла
            string fileContent = File.ReadAllText(path);
            string expectedContent = "0;1;1\r\n0;0;1\r\n1;1;1";

            Assert.AreEqual(expectedContent, fileContent);
        }

        [TestMethod]
        public void CheckMatrixTransformation()
        {
            DataService ds = new DataService();

            // Различные тестовые случаи
            int[,] testMatrix1 = new int[2, 2] { { 5, -3 }, { 0, -1 } };
            string path1 = ds.SaveToFileTextData(testMatrix1);
            string content1 = File.ReadAllText(path1);
            Assert.AreEqual("1;0\r\n0;0", content1);

            int[,] testMatrix2 = new int[1, 3] { { 10, 0, -5 } };
            string path2 = ds.SaveToFileTextData(testMatrix2);
            string content2 = File.ReadAllText(path2);
            Assert.AreEqual("1;0;0", content2);
        }
    }
}
