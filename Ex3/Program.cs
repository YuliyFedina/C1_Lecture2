using System;

namespace Ex3
{
    class Program
    {
        //Заполните 2 матрицы размерности NxN случайными числами.
        //Вывести на консоль.Сложить 2 матрицы. Вывести результат.
        //Использовать Класс Random для генерации случаных чисел.

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите N - размерность матриц, которые будем заполнять случайными числами и потом складывать: ");

                int n = Input();
                Random rand = new Random();
                int[,] matrix1 = new int[n, n];
                int[,] matrix2 = new int[n,n];
                int[,] matrixsum = new int[n,n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix1[i, j] = rand.Next(100);
                        matrix2[i, j] = rand.Next(100);
                        matrixsum[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Первая рандомная матрица:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix1[i,j] + "  ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Вторая рандомная матрица:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix2[i,j]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Их сумма:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrixsum[i,j]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static int Input()
        {
            while (true)
            {
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Некорректное значение! Попробуйте ещё раз:");
            }
        }

    }
}
