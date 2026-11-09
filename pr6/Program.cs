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
            Console.WriteLine("----------------2 задание--------------------");

            int A = 5;
            int B = 15;

            Console.WriteLine($"Дано: A = {A}, B = {B} (A < B)");

            int sum = 0;
            Console.Write("Нечетные числа между A и B: ");

            
            for (int i = A + 1; i < B; i++)
            {
                sum += i;

                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма всех чисел между A и B: {sum}");

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("----------------3 задание--------------------");

            // 1. ПРЯМОУГОЛЬНИК
            Console.WriteLine("Прямоугольник:");
            int rectHeight = 5;
            int rectWidth = 10;
            for (int i = 0; i < rectHeight; i++)
            {
                for (int j = 0; j < rectWidth; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nПрямоугольный треугольник:");
            // 2. ПРЯМОУГОЛЬНЫЙ ТРЕУГОЛЬНИК
            int triHeight = 6;
            for (int i = 1; i <= triHeight; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nРавносторонний треугольник:");
            // 3. РАВНОСТОРОННИЙ ТРЕУГОЛЬНИК
            int eqTriHeight = 6;
            for (int i = 0; i < eqTriHeight; i++)
            {
                
                for (int j = 0; j < eqTriHeight - i - 1; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nРомб:");
            // 4. РОМБ
            int rhombHeight = 5;
            
            for (int i = 0; i < rhombHeight; i++)
            {
                for (int j = 0; j < rhombHeight - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            for (int i = rhombHeight - 2; i >= 0; i--)
            {
                for (int j = 0; j < rhombHeight - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }

        static void Task3()
        {
            Console.WriteLine("----------------4 задание--------------------");

            Console.Write("Введите количество клиентов N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            
            if (N < 0)
            {
                Console.WriteLine("Количество клиентов не может быть отрицательным.");
            }
            else
            {
                long routes = 1; 
                int counter = 1;

                
                if (N > 0)
                {
                    do
                    {
                        routes *= counter;
                        counter++;
                    } while (counter <= N);
                }

                Console.WriteLine($"Для {N} клиентов существует {routes} возможных маршрутов доставки.");
            }

            Console.ReadKey();
        }
    }
}
