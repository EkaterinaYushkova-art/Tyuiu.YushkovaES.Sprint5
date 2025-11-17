using Tyuiu.YushkovaES.Sprint5.Task0.V23.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task0.V23
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
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("Функция: y(x) = (1 + x³) / x²");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string resultPath = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл сохранен: " + resultPath);

            // Чтение и вывод результата из файла
            string result = File.ReadAllText(resultPath);
            Console.WriteLine("Значение функции при x = " + x + ": y = " + result);

            Console.ReadKey();
        }
    }
}

