using System;
using System.Threading.Tasks.Sources;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Заполнить с консоли массив из N элементов. Отсортировать.
                //Вывести результат. N - задается с консоли
                Console.Write("Введите N - количество элементов, с которыми будем работать: ");
                var n = Input();
                int[] elements = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите " + (i + 1) + " элемент из " + n + ":  ");
                    elements[i] = Input();
                }
                Array.Sort(elements);
                Console.Write("Отсортированный массив: ");
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" " + elements[i]);
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
                Console.WriteLine("Некорректное значение! Попробуйте еще раз:");
            }

        }
    }
}
