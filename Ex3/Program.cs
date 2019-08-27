using System;
using Utils;

namespace Ex3
{
    class Program
    {
        //Заполните 2 матрицы размерности NxN случайными числами.
        //Вывести на консоль.Сложить 2 матрицы. Вывести результат.
        //Использовать Класс Random для генерации случаных чисел.

        static void Main()
        {
            do
            {
                Console.Write("Введите N - размерность матриц, которые будем заполнять случайными числами и потом складывать: ");

                var n = ConsoleHelper.InputInt();
                var rand = new Random();
                var matrix1 = new int[n,n];
                var matrix2 = new int[n,n];
                var sumOfMatrices = new int[n,n];

                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        matrix1[i, j] = rand.Next(100);
                        matrix2[i, j] = rand.Next(100);
                        sumOfMatrices[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Первая рандомная матрица:");
                ConsoleHelper.MatrixOutput(matrix1);

                Console.WriteLine();
                Console.WriteLine("Вторая рандомная матрица:");
                ConsoleHelper.MatrixOutput(matrix2);

                Console.WriteLine();
                Console.WriteLine("Их сумма:");
                ConsoleHelper.MatrixOutput(sumOfMatrices);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
