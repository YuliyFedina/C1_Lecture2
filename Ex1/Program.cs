using System;

namespace Ex1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                //Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел
                Console.WriteLine(
                    "Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел");
                Console.WriteLine("Введите N (количество чисел, с которыми будем работать):");
                var n = Input();
                int i;
                int current_value;
                var sum = 0;
                var max = 0;
                var even = 0;
                var mult = 1;

                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите " + (i + 1) + " число из " + n);
                    current_value = Convert.ToInt32(Console.ReadLine());

                    sum = sum + current_value;
                    if (max < current_value) max = current_value;

                    if (current_value % 2 == 0)
                        even++;

                    if (current_value % 2 == 1) mult = mult * current_value;
                }

                Console.WriteLine("Сумма всех введенных чисел = " + sum);
                Console.WriteLine("Максимальное из введеных чисел = " + max);
                Console.WriteLine("Количество четных чисел = " + even);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static int Input()
        {
            while (true)
            {
                int j;
                if (int.TryParse(Console.ReadLine(), out j))
                    return j;
                Console.WriteLine("Введено некорректное значение! Попробуйте еще раз: ");
            }
        }
    }
}