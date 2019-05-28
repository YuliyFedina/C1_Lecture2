using System;
using System.Text;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный
            //элемент, занести его в массив. Отсортировать полученный массив и вывести его
            //значения в обратном порядке.
            Console.Write("Введите N (количество строк в будущей рандомной матрице): ");
            int n = Input();
            Console.Write("Введите M (количество столбцов в будущей рандомной матрице): ");
            int m = Input();
            Random rand = new Random();
            int[,] matrix = new int[n,m];
            int[] minvaluesstr = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1000);
                }
            }
            int maxlenght = matrix[1,1].ToString().Length;
            int minvalue = matrix[1,1];

            for (int i = 0; i < n; i++)
            {
                minvalue = matrix[i, 1];
                for (int j = 0; j < m; j++)
                {
                    if (maxlenght < matrix[i, j].ToString().Length)
                    {
                        maxlenght = matrix[i, j].ToString().Length;
                    }

                    if (minvalue > matrix[i, j])
                    {
                        minvalue = matrix[i, j];
                    }

                    minvaluesstr[i] = minvalue;
                }

            }

            Console.WriteLine("Матрица NxM, заполненная рандомными значениями (int):");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Value(matrix[i,j].ToString(), maxlenght) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Минимальные ээлементы в строках матрицы: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(minvaluesstr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Минимальные ээлементы в строках матрицы, отсортированные в обратном порядке: ");
            Array.Sort(minvaluesstr);
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(minvaluesstr[i] + " ");
            }

            Console.WriteLine();
        }

        private static int Input()
        {
            while (true)
            {
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.Write("Некорректное значение! Попробуйте еще раз: ");
            }
        }

        private static string Value(string str, int lenght)
        {
            StringBuilder valuewithspaces = new StringBuilder(str);
            for (int i = 0; i < (lenght - str.Length); i++)
            {
                valuewithspaces.Append(' ');
            }
            return valuewithspaces.ToString();
        }
    }
}
