using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив длиной N случайными числами. Ввести с консоли число A.
            //Вывести Yes, если число A есть в массиве, No - в противном случае.
            Console.Write("Введите N - длину массива: ");

            int n = Input();
            Random rand = new Random();
            int[] numbers = new int[n];
            int k;

            Console.WriteLine();
            Console.Write("Автоматически сгенерированный массив: ");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rand.Next(100);
                Console.Write(numbers[i] + "  ");
            }

            Console.WriteLine();
            Console.Write("Введите число А (от 0 до 100): ");
            int a = Input();

            for (k = 0; k < n; k++)
            {
                if (a == numbers[k])
                    break;
            }

            if (k < n)
            {
                Console.WriteLine("Введенное число есть в массиве? - Yes");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Введенное число есть в массиве? - No");
            }

        }

        private static int Input()
        {
            while (true)
            {
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.Write("Некорректное значение! Попробуйте ввести еще раз: ");
            }
        }
    }
}
