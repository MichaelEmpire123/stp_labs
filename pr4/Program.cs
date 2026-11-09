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

            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // --- Вариант 1: С помощью побитовой операции И (&) ---
            // У четных чисел младший бит равен 0, поэтому (number & 1) вернет 0.
            if ((number & 1) == 0)
            {
                Console.WriteLine($"[Вариант 1] Число {number} — ЧЕТНОЕ.");
            }
            else
            {
                Console.WriteLine($"[Вариант 1] Число {number} — НЕЧЕТНОЕ.");
            }

            // --- Вариант 2: С помощью оператора остатка от деления (%) ---
            // Если число делится на 2 без остатка, то оно четное.
            if (number % 2 == 0)
            {
                Console.WriteLine($"[Вариант 2] Число {number} — ЧЕТНОЕ.");
            }
            else
            {
                Console.WriteLine($"[Вариант 2] Число {number} — НЕЧЕТНОЕ.");
            }

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("----------------3 задание--------------------");

            int x, y, z;

            // 1. x += y >> x++ * z;
            x = 5; y = 10; z = 15;
            x += y >> x++ * z;
            Console.WriteLine($"1) x += y >> x++ * z  -> Результат: x = {x}, y = {y}, z = {z}");

            // 2. z = ++x & y * 5;
            x = 5; y = 10; z = 15;
            z = ++x & y * 5;
            Console.WriteLine($"2) z = ++x & y * 5    -> Результат: x = {x}, y = {y}, z = {z}");

            // 3. y /= x + 5 | z;
            x = 5; y = 10; z = 15;
            y /= x + 5 | z;
            Console.WriteLine($"3) y /= x + 5 | z     -> Результат: x = {x}, y = {y}, z = {z}");

            // 4. z = x++ & y * 5;
            x = 5; y = 10; z = 15;
            z = x++ & y * 5;
            Console.WriteLine($"4) z = x++ & y * 5    -> Результат: x = {x}, y = {y}, z = {z}");

            // 5. x = y << x++ ^ z;
            x = 5; y = 10; z = 15;
            x = y << x++ ^ z;
            Console.WriteLine($"5) x = y << x++ ^ z   -> Результат: x = {x}, y = {y}, z = {z}");

            Console.ReadKey();
        }

        static void Task3()
        {
            Console.WriteLine("----------------4 задание--------------------");

            double salary = 50000.0;
            int experience = 12;

            double bonusPercentage = 0.0;

            // Расчет процента
            if (experience < 5)
            {
                bonusPercentage = 0.10;
            }
            else if (experience >= 5 && experience < 10)
            {
                bonusPercentage = 0.15;
            }
            else if (experience >= 10 && experience < 15)
            {
                bonusPercentage = 0.25;
            }
            else if (experience >= 15 && experience < 20)
            {
                bonusPercentage = 0.35;
            }
            else if (experience >= 20 && experience < 25)
            {
                bonusPercentage = 0.45;
            }
            else // если 25 лет и более
            {
                bonusPercentage = 0.50;
            }

            // Вычисление итоговой премии
            double bonusAmount = salary * bonusPercentage;

            // Вывод результатов
            Console.WriteLine($"Заработная плата: {salary:N2} руб.");
            Console.WriteLine($"Выслуга лет: {experience} лет");
            Console.WriteLine($"Размер премии ({bonusPercentage * 100}%): {bonusAmount:N2} руб.");

            Console.ReadKey();
        }

        



    }
}
