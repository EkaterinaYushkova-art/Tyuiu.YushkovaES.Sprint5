using System.Globalization;
using Tyuiu.YushkovaES.Sprint5.Task3.V14.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task3.V14
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
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #14                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("Функция: y(x) = (4x³) / (x³ - 1)");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string resultPath = ds.SaveToFileTextData(x);
            Console.WriteLine("Бинарный файл сохранен: " + resultPath);

            // Чтение и вывод результата из файла
            double result = ds.LoadFromFileBinaryData(resultPath);
            Console.WriteLine("Значение функции при x = " + x + ": y = " + result.ToString("F3"));


            Console.ReadKey();
        }
    }
}

