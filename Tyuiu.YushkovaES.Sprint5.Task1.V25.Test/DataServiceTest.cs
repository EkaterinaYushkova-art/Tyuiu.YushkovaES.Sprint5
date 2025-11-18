using Tyuiu.YushkovaES.Sprint5.Task1.V25.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Проверка что файл создан
            Assert.IsTrue(File.Exists(path));

            // Проверка количества строк (11 строк: от -5 до 5 включительно)
            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(11, lines.Length);

            // Проверка правильности последовательности x
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                int expectedX = -5 + i;
                int actualX = int.Parse(parts[0]);
                Assert.AreEqual(expectedX, actualX, $"Ошибка в строке {i}: ожидался x={expectedX}, получен x={actualX}");
            }
        }

        [TestMethod]
        public void CheckAllValuesExist()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);
            string[] lines = File.ReadAllLines(path);

            // Проверяем что все значения от -5 до 5 присутствуют
            for (int i = 0; i <= 10; i++)
            {
                int expectedX = -5 + i;
                string[] parts = lines[i].Split(';');
                int actualX = int.Parse(parts[0]);
                Assert.AreEqual(expectedX, actualX);
            }

        }
    }
}
