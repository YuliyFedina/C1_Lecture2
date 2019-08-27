using System;
using System.Linq;
using Utils;

namespace Ex4
{
    class Program
    {
        static void Main()
        {
            //Заполнить массив длиной N случайными числами. Ввести с консоли число A.
            //Вывести Yes, если число A есть в массиве, No - в противном случае.
            Console.Write("Введите N - длину массива: ");

            var n = ConsoleHelper.InputInt();
            var rand = new Random();
            var numbers = new int[n];
            Console.WriteLine();
            Console.Write("Автоматически сгенерированный массив: ");
            for (var i = 0; i < n; i++)
            {
                numbers[i] = rand.Next(100);
                Console.Write($"{numbers[i]}  ");
            }

            Console.WriteLine();
            Console.Write("Введите число А (от 0 до 100): ");
            var a = ConsoleHelper.InputInt();
            Console.WriteLine(numbers.Contains(a)
                ? "Введенное число есть в массиве? - Yes"
                : "Введенное число есть в массиве? - No");
        }
    }
}
