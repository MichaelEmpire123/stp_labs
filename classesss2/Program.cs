using System;

namespace ConsoleAppTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        // Задание 2: Конвертер валют (Converter)
        static void Task1()
        {
            Console.WriteLine("=== Задание 2: Конвертер валют ===");

            // Задаем курсы валют по отношению к гривне (UAH)
            // Пример: 1 USD = 41.5 UAH, 1 EUR = 44.2 UAH, 1 RUB = 0.42 UAH
            Converter converter = new Converter(41.5, 44.2, 0.42);

            Console.WriteLine("1. Конвертация из UAH в валюту");
            Console.WriteLine("2. Конвертация из валюты в UAH");
            Console.Write("Выберите направление (1 или 2): ");
            int direction = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сумму: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите валюту (usd, eur, rub): ");
            string currency = Console.ReadLine().ToLower();

            if (direction == 1)
            {
                converter.ConvertFromUah(amount, currency);
            }
            else if (direction == 2)
            {
                converter.ConvertToUah(amount, currency);
            }
            else
            {
                Console.WriteLine("Ошибка: Неверное направление конвертации.");
            }

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 3: Сотрудник (Employee)
        static void Task2()
        {
            Console.WriteLine("\n=== Задание 3: Расчет оклада сотрудника ===");

            // Создаем сотрудника с фамилией и именем
            Employee emp = new Employee("Иванов", "Иван");

            // Для расчета передаем должность ("developer", "manager", "tester") и стаж работы в годах
            Console.Write("Введите должность (manager / developer / tester): ");
            string position = Console.ReadLine().ToLower();

            Console.Write("Введите стаж работы (в годах): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            // Выводим всю информацию на экран
            emp.ShowSalaryInfo(position, experience);

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 4: Счет на оплату (Invoice)
        static void Task3()
        {
            Console.WriteLine("\n=== Задание 4: Счет на оплату ===");

            // Создаем счет (номер счета, покупатель, поставщик)
            // Эти поля readonly, их нельзя будет изменить после создания
            Invoice invoice = new Invoice(10245, "ООО Вектор", "ЧП Петров", "Ноутбук ASUS", 3);

            // Выводим расчет стоимости (цена за 1 единицу товара — 25000)
            invoice.CalculateAndShowCost(25000.0);

            Console.WriteLine("\nРабота программы полностью завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 2 (Converter)
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        // Пользовательский конструктор
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        // Конвертация из гривны в иностранную валюту
        public void ConvertFromUah(double uahAmount, string currency)
        {
            switch (currency)
            {
                case "usd":
                    Console.WriteLine($"{uahAmount} UAH = {uahAmount / usd:F2} USD");
                    break;
                case "eur":
                    Console.WriteLine($"{uahAmount} UAH = {uahAmount / eur:F2} EUR");
                    break;
                case "rub":
                    Console.WriteLine($"{uahAmount} UAH = {uahAmount / rub:F2} RUB");
                    break;
                default:
                    Console.WriteLine("Ошибка: Неизвестная валюта.");
                    break;
            }
        }

        // Конвертация из иностранной валюты в гривну
        public void ConvertToUah(double foreignAmount, string currency)
        {
            switch (currency)
            {
                case "usd":
                    Console.WriteLine($"{foreignAmount} USD = {foreignAmount * usd:F2} UAH");
                    break;
                case "eur":
                    Console.WriteLine($"{foreignAmount} EUR = {foreignAmount * eur:F2} UAH");
                    break;
                case "rub":
                    Console.WriteLine($"{foreignAmount} RUB = {foreignAmount * rub:F2} UAH");
                    break;
                default:
                    Console.WriteLine("Ошибка: Неизвестная валюта.");
                    break;
            }
        }
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 3 (Employee)
    class Employee
    {
        private string lastName;
        private string firstName;

        // Пользовательский конструктор
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Метод расчета оклада и налогов, совмещенный с выводом информации
        public void ShowSalaryInfo(string position, int experience)
        {
            double baseSalary = 0;

            // Определяем базовый оклад по должности
            switch (position)
            {
                case "manager":
                    baseSalary = 30000;
                    break;
                case "developer":
                    baseSalary = 50000;
                    break;
                case "tester":
                    baseSalary = 35000;
                    break;
                default:
                    baseSalary = 20000; // Базовая ставка для остальных должностей
                    position = "Сотрудник";
                    break;
            }

            // Добавка к окладу за стаж (например, +5% за каждый год стажа)
            double experienceBonus = baseSalary * (experience * 0.05);
            double finalSalary = baseSalary + experienceBonus;

            // Расчет налогового сбора (например, подоходный налог 13% + пенсионный/соцвзносы = итого 18%)
            double taxRate = 0.18;
            double taxAmount = finalSalary * taxRate;

            // Вывод информации на экран
            Console.WriteLine("\n--- Информация о сотруднике ---");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Стаж работы: {experience} лет");
            Console.WriteLine($"Рассчитанный оклад (с учетом стажа): {finalSalary:F2} руб.");
            Console.WriteLine($"Налоговый сбор (18%): {taxAmount:F2} руб.");
            Console.WriteLine($"Сумма на руки (чистыми): {finalSalary - taxAmount:F2} руб.");
        }
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 4 (Invoice)
    class Invoice
    {
        // Ключевое слово readonly запрещает изменение полей после инициализации в конструкторе
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        // Закрытые (private) поля по условию
        private string article;
        private int quantity;

        // Конструктор инициализирует все поля
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        // Метод расчета стоимости заказа с НДС (20%) и без НДС
        public void CalculateAndShowCost(double pricePerUnit)
        {
            double costWithoutNds = pricePerUnit * quantity;
            double ndsAmount = costWithoutNds * 0.20; // НДС составляет 20%
            double costWithNds = costWithoutNds + ndsAmount;

            // Выводим всю информацию по счету
            Console.WriteLine("\n--- Детали счета на оплату ---");
            Console.WriteLine($"Счет №: {account}");
            Console.WriteLine($"Покупатель: {customer}");
            Console.WriteLine($"Поставщик: {provider}");
            Console.WriteLine($"Товар: {article}");
            Console.WriteLine($"Количество: {quantity} шт.");
            Console.WriteLine($"Цена за единицу: {pricePerUnit:F2}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Сумма к оплате БЕЗ НДС: {costWithoutNds:F2}");
            Console.WriteLine($"В том числе НДС (20%):  {ndsAmount:F2}");
            Console.WriteLine($"ИТОГО К ОПЛАТЕ С НДС:   {costWithNds:F2}");
        }
    }
    #endregion
}
