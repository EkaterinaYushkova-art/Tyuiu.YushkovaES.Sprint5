using System.IO;
using Tyuiu.YushkovaES.Sprint5.Task6.V11.Lib;

namespace Tyuiu.YushkovaES.Sprint5.Task6.V11
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
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнила: Юшкова Е.С. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            string dataDirectory = @"C:\Users\user\source\repos\DataSprint5";
            string path = Path.Combine(dataDirectory, "InPutDataFileTask6V11.txt");

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine("Задание: Найти количество слов длиной шесть символов в заданной строке.");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                             *");
            Console.WriteLine("**************************************************************************");

            try
            {
                int result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество слов длиной 6 символов: {result}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден! Убедитесь, что указали правильный путь.");
                Console.WriteLine($"Создайте папку {dataDirectory} и скопируйте в неё входной файл.");
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
