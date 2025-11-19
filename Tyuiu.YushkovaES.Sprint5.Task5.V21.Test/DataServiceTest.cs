using System;
using System.IO;
using Tyuiu.YushkovaES.Sprint5.Task5.V21.Lib;

namespace Tyuiu.YushkovaES.Sprint5.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ReturnsFactorialOfMaxEvenInteger()
        {
            DataService dataService = new DataService();
            string tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(tempDirectory);

            string filePath = Path.Combine(tempDirectory, "input.txt");
            File.WriteAllLines(filePath, new[]
            {
                "8.1 13 7.18 19",
                "-1 0 9.05 0.56 6",
                "-5.48 10.2 -0.7 -4 8.28 -7.48 -8",
                "-7 -4.65 -9.41 -0.63"
            });

            double actual = dataService.LoadFromDataFile(filePath);

            Directory.Delete(tempDirectory, true);

            Assert.AreEqual(720.0, actual, 0.001, "Факториал максимального четного числа должен равняться 720.");
        }
    }
}
