using System.Globalization;
using Tyuiu.YushkovaES.Sprint5.Task4.V7.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\Users\user\source\repos\DataSprint5\InPutDataFileTask4V7.txt";
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("Функция: y = 1/cos(x) + x³");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine("Значение функции: y = " + result.ToString("F3", CultureInfo.InvariantCulture));

                // Вывод значения x из файла
                string xValue = File.ReadAllText(path);
                Console.WriteLine("Значение x из файла: " + xValue);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден! Убедитесь что файл существует по пути: " + path);
                Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте в неё файл из архива");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата числа в файле! Убедитесь что файл содержит корректное число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }


            Console.ReadKey();
        }
    }
}

