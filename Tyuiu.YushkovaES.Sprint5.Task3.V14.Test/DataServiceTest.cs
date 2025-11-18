using Tyuiu.YushkovaES.Sprint5.Task3.V14.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task3.V14.Test
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
            double result = ds.LoadFromFileBinaryData(path);
            double expected = (4 * Math.Pow(3, 3)) / (Math.Pow(3, 3) - 1); // (4*27)/(27-1) = 108/26 ≈ 4.154
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFileSize()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            // Проверка размера файла (double занимает 8 байт)
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(8, fileInfo.Length);
        }
    }
    
}
