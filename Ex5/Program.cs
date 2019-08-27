using System;
using System.Linq;
using Utils;

namespace Ex5
{
    class Program
    {
        static void Main()
        {
            //Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный
            //элемент, занести его в массив. Отсортировать полученный массив и вывести его
            //значения в обратном порядке.
            Console.Write("Введите N (количество строк в будущей рандомной матрице): ");
            var n = ConsoleHelper.InputInt();
            Console.Write("Введите M (количество столбцов в будущей рандомной матрице): ");
            var m = ConsoleHelper.InputInt();
            var matrix = RandomMatrix(n,m);
            var minValues = new int[n];

            var maxLenght = matrix[1,1].ToString().Length;

            for (var i = 0; i < n; i++)
            {
                var minValue = matrix[i, 1];
                for (var j = 0; j < m; j++)
                {
                    if (maxLenght < matrix[i, j].ToString().Length)
                    {
                        maxLenght = matrix[i, j].ToString().Length;
                    }

                    if (minValue > matrix[i, j])
                    {
                        minValue = matrix[i, j];
                    }
                    minValues[i] = minValue;
                }
            }

            Console.WriteLine("Матрица NxM, заполненная рандомными значениями (int):");
            ConsoleHelper.MatrixOutput(matrix);

            Console.WriteLine();
            Console.WriteLine("Минимальные ээлементы в строках матрицы: ");
            ConsoleHelper.ArrayOutput(minValues);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Минимальные ээлементы в строках матрицы, отсортированные в обратном порядке: ");
            var sortedMinValues = minValues.OrderByDescending(x => x).ToArray();
            ConsoleHelper.ArrayOutput(sortedMinValues);

            Console.WriteLine();
        }

        private static int[,] RandomMatrix(int n, int m)
        {
            var rand = new Random();
            var matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1000);
                }
            }

            return matrix;
        }
    }
}
