using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES
{
    class IOHelper
    {
        static Random rnd = new Random(); // экземпляр класса.

        // Запрос int 
        public static int InputInt(string message)
        {
            Console.Write(message + ": ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // Запрос double 
        public static double InputDouble(string message)
        {
            Console.Write(message + ": ");
            return Convert.ToDouble(Console.ReadLine());
        }
        // Запрос string 
        public static string InputString(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
        }

        // ввод координат точки в двумерном пространстве. 
        public static (double, double) InputPoint(string message)
        {
            Console.WriteLine($"{message}: " );
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            return (a, b);
        }

        // Рисование горизонтальной линии
        public static void Line(int length)
        {
            Console.WriteLine(new String('-', length));
        }

        // Menu
        public static int TextMenu(string[] menu_items)
        {
            Console.Clear();
            for (int i = 0; i <= menu_items.Length - 1; i++)
            {
                Console.WriteLine($"{i+1}. {menu_items[i]}");
            }

            int res = InputInt("Введите выбранный пункт");
            return res;
        }

        // Одномерный double рандомный массив.
        public static double[] GenerateDoubleArray(int length, double minRnd, double maxRnd)
        // length - длинна массива. minRnd\maxRnd - минимально значение и максимальное в Random
        {
            double[] mas = new double[length];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.NextDouble() * rnd.Next((int)minRnd, (int)maxRnd);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            return mas;
        }

        // Одномерный Int рандомный массив.
        public static int[] GenerateIntArray(int length, int minRnd, int maxRnd)
        // length - длинна массива. minRnd\maxRnd - минимально значение и максимальное в Random
        {
            int[] mas = new int[length];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(minRnd, maxRnd);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            return mas;
        }

        // Двумерный Double рандомный массив.
        public static double[,] GenerateDoubleMatrix(int line, int сolumns, double rangeStart, double rangeEnd)
        {
            // line - строка. сolumns - столбец 
            // rangeStart - старт диапазона рандома. rangeEnd - конец

            double[,] mas = new double[line, сolumns];

            Console.WriteLine("Стартовый Двумерный массив: ");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.NextDouble() * rnd.Next((int)rangeStart, (int)rangeEnd);
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            return mas;
        }

        // Двумерный Int рандомный массив.
        public static int[,] GenerateIntMatrix(int line, int сolumns, int rangeStart, int rangeEnd)
        {
            // line - строка. сolumns - столбец 
            // rangeStart - старт диапазона рандома. rangeEnd - конец

            int[,] mas = new int[line, сolumns];

            Console.WriteLine("Стартовый Двумерный массив: ");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(rangeStart, rangeEnd);
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            return mas;
        }

        // Пустой Двумерный массив рандомной длинны.
        public static int[,] GenerateEmptyMatrix(int line, int сolumns)
        {
            // line - строка. сolumns - столбец 
            int[,] mas = new int[line, сolumns];
            return mas;
        }

        // Выводит в консоль int массив в одну строчку.
        public void PrintArray(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{massive[i]} ");
            }
        }

        // Выводит в консоль int двумерный массив.
        public void PrintArray(int[,] massive)
        {
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        // Выводит в консоль double массив в одну строчку.
        public void PrintArray(double[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{massive[i]} ");
            }
        }

        // Выводит в консоль double двумерный массив.
        public void PrintArray(double[,] massive)
        {
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        // вывод надписи в коносль цветом.
        // диапазон 0-14 (https://docs.microsoft.com/ru-ru/dotnet/api/system.consolecolor?view=net-5.0)
        public static void PrintConsoleColor(string message, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
