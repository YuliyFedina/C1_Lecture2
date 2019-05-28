using System;
using System.ComponentModel.Design;
using System.IO;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Калькулятор. С консоли вводится левый операнд, операция, правый операнд. Выводится
            //результат операции над операндами. Реализовать как минимум 4 операции, обработку
            //ошибок(деление на 0 и др).

            Console.WriteLine("Калькулятор с 4 операциями: +, -, /, *");
            Console.Write("Введите левый операнд (число): ");
            double leftopr = InputOperand();
            Console.Write("Введите операцию (одну из: +, -, /, *): ");
            string operation = InputOperation();

            Console.Write("Введите правый операнд (число): ");

            double rightopr = InputOperand();
            string result = Result(leftopr, operation, rightopr);
            Console.WriteLine();
            Console.WriteLine("Результат: " + leftopr + " " + operation + " " + rightopr + " = " + result);
        }

        private static double InputOperand()
        {
            while (true)
            {
                double value;
                if (double.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.Write("Некорректное значение операнда! Попробуйте еще раз:   ");
            }
        }

        private static string InputOperation()
        {
            while (true)
            {
                string operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
                    return operation;
                Console.Write("Некорректное значение! Попробуйте еще раз ввести одну из операций: +, -, /, *:   ");
            }
        }

       private static string Result(double opr1,string opr, double opr2)
        {
            while (true)
            {
                double result;
                if (opr == "+")
                {
                    result = opr1 + opr2;
                    return result.ToString();
                }
                if (opr == "-")
                {
                    result = opr1 - opr2;
                    return result.ToString();
                }

                if (opr == "*")
                {
                    result = opr1 * opr2;
                    return result.ToString();
                }

                if (opr == "/")
                {
                    if (opr2 != 0)
                    {
                        result = opr1 / opr2;
                        return result.ToString();
                    }

                    if (opr2 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("На ноль делить нельзя! Начните заново");
                        return "Error";
                    }
                }
            }
        }

      

    }
}
