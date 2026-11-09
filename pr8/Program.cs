using System;

namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] sender)
        {
            Task1();
            Task2();
        }

        static void Task1()
        {
            Console.WriteLine("--- Задание 2: Банковская система учета кредита ---");

            double totalDebt = 700.0;
            double totalPaid = 0.0;

            Console.WriteLine($"Изначальная сумма долга: {totalDebt} грн.");

            while (totalPaid < totalDebt)
            {
                Console.Write("\nВведите сумму внесенного платежа (грн): ");
                double payment = Convert.ToDouble(Console.ReadLine());

                totalPaid += payment;
                double currentBalance = totalDebt - totalPaid;

                if (currentBalance > 0)
                {
                    Console.WriteLine("Статус: Кредит НЕ погашен.");
                    Console.WriteLine($"Остаток задолженности: {currentBalance} грн.");
                    Console.WriteLine("Сумма переплаты: 0 грн.");
                }
                else if (currentBalance == 0)
                {
                    Console.WriteLine("Статус: Кредит ПОЛНОСТЬЮ ПОГАШЕН!");
                    Console.WriteLine("Сумма задолженности: 0 грн.");
                    Console.WriteLine("Сумма переплаты: 0 грн.");
                }
                else
                {
                    Console.WriteLine("Статус: Кредит ПОЛНОСТЬЮ ПОГАШЕН!");
                    Console.WriteLine("Сумма задолженности: 0 грн.");
                    Console.WriteLine($"Сумма переплаты: {Math.Abs(currentBalance)} грн.");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        
        static void Task2()
        {
            Console.WriteLine("\n--- Задание 3: Маршруты доставки товара ---");
            Console.Write("Введите количество клиентов (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("Количество клиентов не может быть отрицательным.");
            }
            else
            {
                long routesCount = CalculateFactorial(N);
                Console.WriteLine($"Количество возможных вариантов маршрутов для {N} клиентов: {routesCount}");
            }

            Console.WriteLine("\n[Объяснение слабых мест рекурсии]:");
            Console.WriteLine("1. Переполнение стека (StackOverflowException) при больших N из-за накопления слоев вызовов.");
            Console.WriteLine("2. Высокие накладные расходы процессора и памяти на вызовы функций по сравнению с обычным циклом.");
            Console.WriteLine("3. Быстрое математическое переполнение типа данных (long выйдет за пределы уже при N = 21).");

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        
        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }
    }
}
