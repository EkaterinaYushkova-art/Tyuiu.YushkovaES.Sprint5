using System.Globalization;
using System.IO;
using Tyuiu.YushkovaES.Sprint5.Task5.V21.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #21                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string dataDirectory = @"C:\Users\user\source\repos\DataSprint5";
            string path = Path.Combine(dataDirectory, "InPutDataFileTask5V21.txt");
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("Задача: Найти факториал наибольшего целого числа, которое делится на 2");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine("Факториал наибольшего четного целого числа: " + result.ToString("F3"));

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден! Убедитесь что файл существует по пути: " + path);
                Console.WriteLine("Создайте папку " + dataDirectory + " и скопируйте в неё файл из архива");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}


