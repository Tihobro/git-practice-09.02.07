using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой консольный калькулятор");

            while (true)
            {
                // Запрашиваем первое число
                Console.Write("\nВведите первое число (или 'exit' для выхода): ");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "exit") break;

                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Ошибка: введено не число!");
                    continue;
                }

                // Запрашиваем операцию
                Console.Write("Введите операцию (+, -, *, /): ");
                string op = Console.ReadLine();

                // Запрашиваем второе число
                Console.Write("Введите второе число: ");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Ошибка: введено не число!");
                    continue;
                }

                // Переменная для хранения результата
                double result = 0;
                bool validOperation = true;

                // Выполняем вычисления
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;
                    /*
                    case "-":
                        result = num1 - num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль невозможно!");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;*/
                    default:
                        Console.WriteLine("Ошибка: неизвестная операция!");
                        validOperation = false;
                        break;
                }

                // Выводим результат
                if (validOperation)
                {
                    Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
                }
            }

            Console.WriteLine("Программа завершена. До свидания!");
        }
    }
}
