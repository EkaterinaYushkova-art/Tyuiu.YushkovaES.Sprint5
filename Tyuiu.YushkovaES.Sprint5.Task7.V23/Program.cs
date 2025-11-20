using System.IO;
using Tyuiu.YushkovaES.Sprint5.Task7.V23.Lib;

namespace Tyuiu.YushkovaES.Sprint5.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Юшкова Е.С. | ИСПб-25-1";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнила: Юшкова Е.С. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            string dataDirectory = @"C:\Users\user\source\repos\DataSprint5";
            string inputPath = Path.Combine(dataDirectory, "InPutDataFileTask7V23.txt");
            Console.WriteLine($"Путь к входному файлу: {inputPath}");
            Console.WriteLine("Задача: удалить все русские слова и сохранить результат в новый файл.");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
            Console.WriteLine("**************************************************************************");

            try
            {
                string outputPath = ds.LoadDataAndSave(inputPath);

                Console.WriteLine($"Результат сохранён в: {outputPath}");
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(File.ReadAllText(outputPath));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл с исходными данными не найден.");
                Console.WriteLine($"Создайте папку {dataDirectory} и поместите туда нужный файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Для выхода нажмите любую клавишу...                                    *");
            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}
