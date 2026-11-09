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

        // Задание 2: Учебный класс (ClassRoom)
        static void Task1()
        {
            Console.WriteLine("=== Задание 2: Учебный класс ===");

            // Создаем учеников разной успеваемости
            Pupil p1 = new ExcellentPupil("Алексей");
            Pupil p2 = new GoodPupil("Мария");
            Pupil p3 = new BadPupil("Иван");

            // Инициализируем класс 3 учениками (4-й создастся автоматически как базовый Pupil)
            ClassRoom classRoom = new ClassRoom(p1, p2, p3);

            // Показываем их способности
            classRoom.ShowClassSkills();

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 3: Средства передвижения (Vehicle)
        static void Task2()
        {
            Console.WriteLine("\n=== Задание 3: Средства передвижения ===");

            // Создаем объекты разных видов транспорта
            Plane boeing = new Plane(100.5, 200.8, 85000000, 920, 2021, 10000, 180);
            Car tesla = new Car(10.2, 45.6, 65000, 250, 2023);
            Ship titanic = new Ship(0.0, 0.0, 150000000, 40, 1912, 2200, "Саутгемптон");

            // Выводим данные
            boeing.PrintInfo();
            tesla.PrintInfo();
            titanic.PrintInfo();

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 4: Редактор документов (DocumentWorker)
        static void Task3()
        {
            Console.WriteLine("\n=== Задание 4: Редактор документов ===");
            Console.Write("Введите ключ доступа (оставьте пустым для бесплатной версии): ");
            string licenseKey = Console.ReadLine();

            DocumentWorker worker;

            // Распределяем версии по ключам (Pro-ключ: "pro", Expert-ключ: "exp")
            if (licenseKey.ToLower() == "pro")
            {
                Console.WriteLine("\n[Система]: Активирована версия PRO.");
                worker = new ProDocumentWorker(); // Upcasting к DocumentWorker
            }
            else if (licenseKey.ToLower() == "exp")
            {
                Console.WriteLine("\n[Система]: Активирована версия EXPERT.");
                worker = new ExpertDocumentWorker(); // Upcasting к DocumentWorker
            }
            else
            {
                Console.WriteLine("\n[Система]: Ключ не введен или неверен. Активирована БЕСПЛАТНАЯ версия.");
                worker = new DocumentWorker();
            }

            // Выполнение операций с документом
            Console.WriteLine("\n--- Тестирование функций ---");
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.WriteLine("\nРабота программы полностью завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 2 (ClassRoom)
    class Pupil
    {
        public string Name { get; set; }
        public Pupil(string name) => Name = name;

        public virtual void Study() => Console.WriteLine($"{Name} учится средне.");
        public virtual void Read() => Console.WriteLine($"{Name} читает с обычной скоростью.");
        public virtual void Write() => Console.WriteLine($"{Name} пишет аккуратно.");
        public virtual void Relax() => Console.WriteLine($"{Name} отдыхает после уроков.");
    }

    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string name) : base(name) { }
        public override void Study() => Console.WriteLine($"{Name} учится великолепно, знает ответы на все вопросы!");
        public override void Read() => Console.WriteLine($"{Name} читает очень быстро и запоминает всё с первого раза.");
        public override void Write() => Console.WriteLine($"{Name} пишет каллиграфическим почерком без единой ошибки.");
        public override void Relax() => Console.WriteLine($"{Name} отдыхает мало, предпочитает читать научные статьи.");
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }
        public override void Study() => Console.WriteLine($"{Name} учится хорошо, старается на уроках.");
        public override void Read() => Console.WriteLine($"{Name} читает бегло и выразительно.");
        public override void Write() => Console.WriteLine($"{Name} пишет грамотно, изредка допуская помарки.");
        public override void Relax() => Console.WriteLine($"{Name} отдыхает сбалансированно, гуляет с друзьями.");
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override void Study() => Console.WriteLine($"{Name} учиться не хочет, постоянно отвлекается.");
        public override void Read() => Console.WriteLine($"{Name} читает по слогам и неохотно.");
        public override void Write() => Console.WriteLine($"{Name} пишет неразборчиво и с грубыми ошибками.");
        public override void Relax() => Console.WriteLine($"{Name} отдыхает постоянно, играет в телефон прямо на уроках.");
    }

    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils[0] = p1; pupils[1] = p2;
            pupils[2] = new Pupil("Ученик-Новичок 1"); pupils[3] = new Pupil("Ученик-Новичок 2");
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p1; pupils[1] = p2; pupils[2] = p3;
            pupils[3] = new Pupil("Ученик-Новичок");
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1; pupils[1] = p2; pupils[2] = p3; pupils[3] = p4;
        }

        public void ShowClassSkills()
        {
            foreach (var pupil in pupils)
            {
                Console.WriteLine($"\n--- Оцениваем ученика: {pupil.Name} ---");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 3 (Vehicle)
    class Vehicle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x; Y = y; Price = price; Speed = speed; Year = year;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Координаты: ({X}; {Y}), Цена: {Price:N0} $, Скорость: {Speed} км/ч, Год выпуска: {Year}");
        }
    }

    class Plane : Vehicle
    {
        public double Altitude { get; set; }
        public int Passengers { get; set; }

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            Altitude = altitude; Passengers = passengers;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\n--- САМОЛЕТ ---");
            base.PrintInfo();
            Console.WriteLine($"Высота полета: {Altitude} м, Количество пассажиров: {Passengers}");
        }
    }

    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year) : base(x, y, price, speed, year) { }
        public override void PrintInfo()
        {
            Console.WriteLine("\n--- МАШИНА ---");
            base.PrintInfo();
        }
    }

    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string PortOfRegistry { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers; PortOfRegistry = port;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\n--- КОРАБЛЬ ---");
            base.PrintInfo();
            Console.WriteLine($"Количество пассажиров: {Passengers}, Порт приписки: {PortOfRegistry}");
        }
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 4 (DocumentWorker)
    class DocumentWorker
    {
        public virtual void OpenDocument() => Console.WriteLine("Документ открыт");
        public virtual void EditDocument() => Console.WriteLine("Редактирование документа доступно в версии Про");
        public virtual void SaveDocument() => Console.WriteLine("Сохранение документа доступно в версии Про");
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() => Console.WriteLine("Документ отредактирован");
        public override void SaveDocument() =>
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() => Console.WriteLine("Документ сохранен в новом формате");
    }
    #endregion
}
