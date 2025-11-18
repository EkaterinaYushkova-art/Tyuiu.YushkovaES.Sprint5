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

            // Проверка формата данных
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                Assert.AreEqual(2, parts.Length);
                Assert.IsTrue(int.TryParse(parts[0], out int x));
                Assert.IsTrue(double.TryParse(parts[1], out double y));
            }
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем точку, где знаменатель близок к нулю: 3x + 1.2 = 0 => x = -0.4
            // Так как x целые, проверяем соседние значения
            string path = ds.SaveToFileTextData(-1, 0);
            string[] lines = File.ReadAllLines(path);

            // Проверяем что нет исключений и все значения вычислены
            Assert.AreEqual(2, lines.Length);
        }
    
    }
}
