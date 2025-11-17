using Tyuiu.YushkovaES.Sprint5.Task0.V23.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            // Проверка что файл создан
            Assert.IsTrue(File.Exists(path));

            // Проверка содержимого файла
            string fileContent = File.ReadAllText(path);
            double expected = (1 + Math.Pow(3, 3)) / Math.Pow(3, 2); // (1 + 27) / 9 = 28/9 ≈ 3.111
            string expectedString = Math.Round(expected, 3).ToString();

            Assert.AreEqual(expectedString, fileContent);
        }
    }
}
