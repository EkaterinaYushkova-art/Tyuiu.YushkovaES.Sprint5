using System.Globalization;
using Tyuiu.YushkovaES.Sprint5.Task2.V6.Lib;
namespace Tyuiu.YushkovaES.Sprint5.Task2.V6
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
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы массива 3x3:");

            // Ввод данных с клавиатуры
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Вывод исходного массива
            Console.WriteLine("\nИсходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string resultPath = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл сохранен: " + resultPath);
            Console.WriteLine();

            // Вывод преобразованного массива
            Console.WriteLine("Преобразованный массив (положительные -> 1, отрицательные -> 0):");
            string[] lines = File.ReadAllLines(resultPath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
