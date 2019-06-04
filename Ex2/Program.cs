using System;
using System.Linq;
using Utils;

namespace Ex2
{
    class Program
    {
        static void Main()
        {
            do
            {
                //Заполнить с консоли массив из N элементов. Отсортировать.
                //Вывести результат. N - задается с консоли
                Console.Write("Введите N - количество элементов, с которыми будем работать: ");
                var n = ConsoleHelper.InputInt();
                var elements = new int[n];
                for (var i = 0; i < n; i++)
                {
                    Console.Write($"Введите {i + 1} элемент из {n}:  ");
                    elements[i] = ConsoleHelper.InputInt();
                }

                var sortedElements = elements.OrderBy(x => x);
                Console.Write("Отсортированный массив: ");

                foreach (var element in sortedElements)
                {
                    Console.Write($" {element} ");
                }
                Console.WriteLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
