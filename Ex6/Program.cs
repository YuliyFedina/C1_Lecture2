using System;
using Utils;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Калькулятор. С консоли вводится левый операнд, операция, правый операнд. Выводится
            //результат операции над операндами. Реализовать как минимум 4 операции, обработку
            //ошибок(деление на 0 и др).

            /*Console.WriteLine("Калькулятор с 4 операциями: +, -, /, *");
            Console.Write("Введите левый операнд (число): ");
            var leftOperand = ConsoleHelper.InputDouble();
            Console.Write("Введите операцию (одну из: +, -, /, *): ");
            var operation = InputOperation();

            Console.Write("Введите правый операнд (число): ");

            var rightOperand = ConsoleHelper.InputDouble();*/
            var leftOperand = double.Parse(args[0]);
            var operation = args[1];
            var rightOperand = double.Parse(args[2]);
            try
            {
                double result = Result(leftOperand, operation, rightOperand);
                Console.WriteLine();
                Console.WriteLine($"Результат: {leftOperand} {operation} {rightOperand} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
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

       private static double Result(double opr1,string opr, double opr2)
        {
            double result;
                switch (opr)
                {
                    case "+" :
                        result = opr1 + opr2;
                        return result;
                    case "-":
                        result = opr1 - opr2;
                        return result;
                    case "*":
                        result = opr1 * opr2;
                        return result;
                    case "/":
                    {
                        if (opr2 != 0)
                        {
                            result = opr1 / opr2;
                            return result;
                        }

                        throw new DivideByZeroException();
                    }

                        default:
                            throw new NotSupportedException($" оператор {opr} не поддерживается");
                }
        }
    }
}
