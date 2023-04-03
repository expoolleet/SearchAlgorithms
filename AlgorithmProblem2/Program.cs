using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SearchAlgorithms
{
    internal class Program
    {
        private static Stopwatch _sw = new Stopwatch();

        static void Main()
        {
            List<int> lengthList = new List<int> { 10000, 20000, 30000, 40000, 50000, 100000, 200000 };

            int valueToSearch;
            int index;
            double timeWork;

            Console.Write("Какой эллемент будем искать?\nn: ");
            valueToSearch = Convert.ToInt32(Console.ReadLine());

            foreach (var currentLength in lengthList)
            {
                Console.WriteLine($"----------     Количество элементов массива {currentLength}    ----------");

                int[] array = new int[currentLength];

                FillArray(array);

                Array.Sort(array);

                StartTest(SearchAlgorithm.LinearSearch, array, valueToSearch, out timeWork, out index);
                Console.WriteLine($"Время работы линейного алгоритма поиска: {timeWork}");

                StartTest(SearchAlgorithm.FastLinearSearch, array, valueToSearch, out timeWork, out index);
                Console.WriteLine($"Время работы быстрого линейного алгоритма поиска: {timeWork}");

                StartTest(SearchAlgorithm.BinarySearch, array, valueToSearch, out timeWork, out index);
                Console.WriteLine($"Время работы двоичного алгоритма поиска: {timeWork}");

                StartTest(SearchAlgorithm.JumpSearch, array, valueToSearch, out timeWork, out index);
                Console.WriteLine($"Время работы алгоритма поиска прыжками: {timeWork}");

                StartTest(SearchAlgorithm.InterpolationSearch, array, valueToSearch, out timeWork, out index);
                Console.WriteLine($"Время работы интерполяционного алгоритма поиска: {timeWork}");

                Console.WriteLine($"Индекс искомого элемента: {index}");

                Console.WriteLine("\n\n");
            }

            Console.Write("y/n to continue/close console... ");

            switch (Console.ReadLine())
            {
                case "y": Main(); break;
                case "n": Environment.Exit(0); break;
            }
        }

        private static void StartTest(Func<int[], int, int> func, int[] array, int valueToSearch, out double timeWork, out int index)
        {
            timeWork = 0;
            index = -1;

            for (int i = 1; i <= 10; i++)
            {
                _sw.Reset();

                _sw.Start();

                index = func(array, valueToSearch);

                _sw.Stop();

                timeWork += _sw.ElapsedTicks;
            }

            timeWork = timeWork / 10;
        }

        private static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-array.Length, array.Length);
        }
    }
}