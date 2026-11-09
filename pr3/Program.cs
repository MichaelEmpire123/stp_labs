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
            Task4();
            Task5();
        }

        static void Task1()
        {
            Console.WriteLine("----------------1 задание--------------------");
            int x, y, z;

            // 1. Выражение: x += y - x++ * z;
            x = 10; y = 12; z = 3;
            x += y - x++ * z;
            Console.WriteLine($"1) x += y - x++ * z   -> Результат: x = {x}, y = {y}, z = {z}");

            // 2. Выражение: z = --x - y * 5;
            x = 10; y = 12; z = 3;
            z = --x - y * 5;
            Console.WriteLine($"2) z = --x - y * 5     -> Результат: x = {x}, y = {y}, z = {z}");

            // 3. Выражение: y /= x + 5 % z;
            x = 10; y = 12; z = 3;
            y /= x + 5 % z;
            Console.WriteLine($"3) y /= x + 5 % z     -> Результат: x = {x}, y = {y}, z = {z}");

            // 4. Выражение: z = x++ + y * 5;
            x = 10; y = 12; z = 3;
            z = x++ + y * 5;
            Console.WriteLine($"4) z = x++ + y * 5     -> Результат: x = {x}, y = {y}, z = {z}");

            // 5. Выражение: x = y - x++ * z;
            x = 10; y = 12; z = 3;
            x = y - x++ * z;
            Console.WriteLine($"5) x = y - x++ * z     -> Результат: x = {x}, y = {y}, z = {z}");

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("----------------2 задание--------------------");

            int a = 10;
            int b = 15;
            int c = 12;

            // Вычисляем среднее с приведением к double (делением на 3.0)
            double average = (a + b + c) / 3.0;

            Console.WriteLine($"Числа: {a}, {b}, {c}");
            Console.WriteLine($"Среднее арифметическое: {average}");
        }

        static void Task3()
        {
            Console.WriteLine("----------------3 задание--------------------");

            const double pi = 3.141592653589793;
            double r = 5.5; // Пример радиуса

            // Формула: pi * R^2
            double area = pi * r * r;

            Console.WriteLine($"Радиус круга: {r}");
            Console.WriteLine($"Площадь круга: {area}");
        }

        static void Task4()
        {
            Console.WriteLine("----------------4 задание--------------------");

            const double pi = 3.141592653589793;
            double R = 4.0; // Радиус
            double h = 10.0; // Высота

            // Расчет объема V = pi * R^2 * h
            double V = pi * R * R * h;

            // Расчет площади поверхности S = 2 * pi * R * (R + h)
            double S = 2 * pi * R * (R + h);

            Console.WriteLine($"Цилиндр с радиусом {R} и высотой {h}:");
            Console.WriteLine($"Объем V = {V}");
            Console.WriteLine($"Площадь поверхности S = {S}");
        }

        static void Task5()
        {
            Console.WriteLine("----------------5 задание--------------------");

            // ОШИБКА: Компилятор выдаст "Invalid expression term '?'"
            // int uberflu?; 

            // КОРРЕКТНО: Имя может начинаться с подчеркивания
            int _Identifier = 100;

            // КОРРЕКТНО: \u006f — это код латинской буквы 'o'. 
            // Переменная создается с именем oIdentifier
            int \u006fIdentifier = 200;

            // ОШИБКА: Компилятор выдаст "Unexpected character '&'"
            // int &myVar; 

            // КОРРЕКТНО: Буквы и цифры внутри названия разрешены
            int myVariab1le = 300;

            // Выводим корректные переменные на экран
            Console.WriteLine("Разрешенные имена переменных в C#:");
            Console.WriteLine($"_Identifier = {_Identifier}");
            Console.WriteLine($"\\u006fIdentifier (воспринимается как oIdentifier) = {oIdentifier}");
            Console.WriteLine($"myVariab1le = {myVariab1le}");

            Console.WriteLine("\nИмена 'uberflu?' и '&myVar' использовать НЕЛЬЗЯ — код с ними не скомпилируется.");

            Console.ReadKey();
        }



    }
}
