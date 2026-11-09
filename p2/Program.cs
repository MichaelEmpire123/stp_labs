using System;

namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] sender)
        {
            Task2();
            Task3();
        }

        static void Task2()
        {
            Console.WriteLine("--------Задание 2-----------");
            double pi = 3.141592653589793;
            double e = 2.7182818284590452;

            
            Console.WriteLine("Число PI: " + pi.ToString("R"));
            Console.WriteLine("Число e:  " + e.ToString("R"));

            Console.ReadKey();
        }
        static void Task3()
        {
            Console.WriteLine("--------Задание 3-----------");
            string str1 = "\nмоя строка 1";
            string str2 = "\tмоя строка 2";
            string str3 = "\aмоя строка 3";

            // Выводим их на экран
            Console.WriteLine("Строка 1: " + str1);
            Console.WriteLine("Строка 2: " + str2);
            Console.WriteLine("Строка 3: " + str3);

            Console.ReadKey();
        }

    }
}
