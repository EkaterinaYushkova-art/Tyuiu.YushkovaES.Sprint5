using Tyuiu.YushkovaES.Sprint5.Task1.V25.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task1.V25
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

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");
            Console.WriteLine($"Шаг: 1");
            Console.WriteLine($"Функция: F(x) = (2sin(x))/(3x+1.2) + cos(x) - 14x");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string resultPath = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл сохранен: " + resultPath);
            Console.WriteLine();

            string[] lines = File.ReadAllLines(resultPath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                int x = int.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                Console.WriteLine($"│ {x,3} │ {y,8:F2} │");
            }

            Console.ReadKey();
        }
    }
}
