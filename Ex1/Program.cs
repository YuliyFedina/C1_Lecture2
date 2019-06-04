using System;
using Utils;

namespace Ex1
{
    internal class Program
    {
        private static void Main()
        {
            do
            {
                //Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел
                Console.Write("Введите N (количество чисел, с которыми будем работать):  ");
                var n = ConsoleHelper.InputInt(1,10);
                var sum = 0;
                var max = int.MinValue;
                var min = int.MaxValue;
                var numbersEven = 0;
                var numbersOdd = 0;
                var multiplicationOdd = 1;
                if (n <= 0) continue;
                for (var i = 0; i < n; i++)
                {
                    Console.Write($"Введите {i + 1} число из {n}:  ");
                    var currentValue = ConsoleHelper.InputInt();
                    sum += currentValue;
                        if (max < currentValue) max = currentValue;
                        if (min > currentValue) min = currentValue;
                        if (currentValue % 2 == 0)
                        {
                            numbersEven++;
                        }
                        else
                        {
                            numbersOdd++;
                            multiplicationOdd *= currentValue;
                        }
                    
                }

                Console.WriteLine($"Сумма всех введенных чисел = {sum}");
                Console.WriteLine($"Максимальное из введеных чисел = {max}");
                Console.WriteLine($"Минимальное из введеных чисел = {min}");
                Console.WriteLine($"Количество четных чисел = {numbersEven}");
                //is this condition true ? yes : no
                Console.WriteLine($"Произведение нечетных чисел = {(numbersOdd != 0 ? multiplicationOdd.ToString() : "Нечетных чисел нет")} ");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}