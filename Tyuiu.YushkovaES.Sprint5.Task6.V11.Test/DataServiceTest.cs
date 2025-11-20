using System.IO;
using Tyuiu.YushkovaES.Sprint5.Task6.V11.Lib;

namespace Tyuiu.YushkovaES.Sprint5.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CountsSixLetterWords()
        {
            DataService ds = new DataService();

            string dataDirectory = @"C:\Users\user\source\repos\DataSprint5";
            string path = Path.Combine(dataDirectory, "InPutDataFileTask6V11.txt");

            int expected = 3;
            int actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
