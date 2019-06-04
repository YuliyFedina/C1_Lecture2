using System;

namespace Utils
{
    public static class ConsoleHelper
    {
        public static int InputInt(int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var inputInt))
                {
                    if (inputInt <= max && inputInt >= min)
                        return inputInt;
                    Console.Write($"Введеное значение должно быть в диапазоне {min}-{max}: ");
                    continue;
                }
                Console.WriteLine("Введено некорректное значение! Попробуйте еще раз ввести число (int)");
            }
        }

        public static double InputDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out var value))
                    return value;
                Console.Write("Некорректное значение операнда! Попробуйте еще раз число (double):");
            }
        }

        public static void MatrixOutput(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayOutput(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element}  ");
            }
        }
    }
}
