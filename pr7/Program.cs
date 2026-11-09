using System;

namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] sender)
        {
            Task1();
            Task2();
            Task3();
        }

        
        static void Task1()
        {
            Console.WriteLine("----------------Задание 2 (Калькулятор)--------------------");

            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите знак операции (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Add(num1, num2);
                    break;
                case '-':
                    Sub(num1, num2);
                    break;
                case '*':
                    Mul(num1, num2);
                    break;
                case '/':
                    Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ошибка: Неверный знак операции.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        static void Add(int a, int b) => Console.WriteLine($"Результат сложения: {a} + {b} = {a + b}");
        static void Sub(int a, int b) => Console.WriteLine($"Результат вычитания: {a} - {b} = {a - b}");
        static void Mul(int a, int b) => Console.WriteLine($"Результат умножения: {a} * {b} = {a * b}");
        static void Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            }
            else
            {
                double result = (double)a / b;
                Console.WriteLine($"Результат деления: {a} / {b} = {result}");
            }
        }

        
        static void Task2()
        {
            Console.WriteLine("\n----------------Задание 3 (Конвертер валют)--------------------");

            Console.Write("Введите сумму денег для конвертации: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите курс для конвертации: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            if (amount < 0 || rate <= 0)
            {
                Console.WriteLine("Ошибка: Некорректные входные данные.");
            }
            else
            {
                double convertedAmount = amount * rate;
                Console.WriteLine($"Результат конвертации: {convertedAmount:F2}");
            }

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        
        static void Task3()
        {
            Console.WriteLine("\n----------------Задание 4 (Анализ числа)--------------------");

            Console.Write("Введите целое число для анализа: ");
            int number = Convert.ToInt32(Console.ReadLine());

            AnalyzeNumber(number);

            Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void AnalyzeNumber(int n)
        {
            
            if (n > 0) Console.WriteLine("1) Число является положительным.");
            else if (n < 0) Console.WriteLine("1) Число является отрицательным.");
            else Console.WriteLine("1) Число равно нулю.");

            
            if (n <= 1)
            {
                Console.WriteLine("2) Число не является простым (простые числа больше 1).");
            }
            else
            {
                int divisorsCount = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) divisorsCount++;
                }

                if (divisorsCount == 2) Console.WriteLine("2) Число является ПРОСТЫМ.");
                else Console.WriteLine($"2) Число сложным (найдено делителей: {divisorsCount}).");
            }

            
            Console.WriteLine("3) Проверка делимости без остатка:");
            int[] checkNumbers = { 2, 5, 3, 6, 9 };

            foreach (int d in checkNumbers)
            {
                if (n % d == 0) Console.WriteLine($"   - Делится на {d}");
                else Console.WriteLine($"   - НЕ делится на {d}");
            }
        }
    }
}
