using System;

namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        // Задание 2: Прямоугольник (Rectangle)
        static void Task1()
        {
            Console.WriteLine("=== Задание 2: Расчет прямоугольника ===");

            Console.Write("Введите длину первой стороны: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второй стороны: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            // Создаем экземпляр прямоугольника
            Rectangle rect = new Rectangle(s1, s2);

            // Выводим результаты через свойства get
            Console.WriteLine($"Площадь прямоугольника: {rect.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rect.Perimeter}");

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 3: Книга (Book) с разноцветным выводом
        static void Task2()
        {
            Console.WriteLine("\n=== Задание 3: Разноцветная книга ===");

            // Создаем элементы книги
            Title title = new Title("Преступление и наказание");
            Author author = new Author("Федор Достоевский");
            Content content = new Content("Роман о душевных терзаниях и моральном выборе Родиона Раскольникова.");

            // Собираем книгу
            Book myBook = new Book(title, author, content);

            // Выводим информацию (каждый компонент окрасится в свой цвет)
            myBook.Show();

            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему заданию...");
            Console.ReadKey();
        }

        // Задание 4: Точки и Многоугольники (Point & Figure)
        static void Task3()
        {
            Console.WriteLine("\n=== Задание 4: Многоугольники ===");

            // Создаем точки для треугольника
            Point p1 = new Point(0, 0, "Точка A");
            Point p2 = new Point(0, 3, "Точка B");
            Point p3 = new Point(4, 0, "Точка C");

            // Инициализируем фигуру (вызов конструктора для 3-х аргументов)
            Figure triangle = new Figure(p1, p2, p3, "Прямоугольный треугольник");

            // Выводим имя фигуры и считаем её периметр
            triangle.PerimeterCalculator();

            Console.WriteLine("\nРабота программы полностью завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 2 (Rectangle)
    class Rectangle
    {
        private double side1;
        private double side2;

        // Пользовательский конструктор
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Методы расчета
        public double AreaCalculator() => side1 * side2;
        public double PerimeterCalculator() => 2 * (side1 + side2);

        // Свойства со встроенным get
        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 3 (Book)
    class Title
    {
        private string text;
        public Title(string text) => this.text = text;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Голубой цвет для названия
            Console.WriteLine($"Название книги: {text}");
            Console.ResetColor();
        }
    }

    class Author
    {
        private string name;
        public Author(string name) => this.name = name;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для автора
            Console.WriteLine($"Автор: {name}");
            Console.ResetColor();
        }
    }

    class Content
    {
        private string body;
        public Content(string body) => this.body = body;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Желтый цвет для содержания
            Console.WriteLine($"Содержание:\n{body}");
            Console.ResetColor();
        }
    }

    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    #endregion

    #region КЛАССЫ ДЛЯ ЗАДАНИЯ 4 (Point & Figure)
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Свойства get
        public int X => x;
        public int Y => y;
        public string Name => name;
    }

    class Figure
    {
        private Point[] points;
        public string Name { get; set; }

        // Конструктор для 3-х точек (Треугольник)
        public Figure(Point p1, Point p2, Point p3, string name)
        {
            points = new Point[] { p1, p2, p3 };
            Name = name;
        }

        // Конструктор для 4-х точек (Четырехугольник)
        public Figure(Point p1, Point p2, Point p3, Point p4, string name)
        {
            points = new Point[] { p1, p2, p3, p4 };
            Name = name;
        }

        // Конструктор для 5-ти точек (Пятиугольник)
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
            Name = name;
        }

        // Расчет длины стороны между двумя точками по формуле Евклида
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Расчет и вывод общего периметра фигуры
        public void PerimeterCalculator()
        {
            double perimeter = 0;

            // Считаем расстояния между всеми последовательными точками
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            // Не забываем замкнуть фигуру: прибавить сторону от последней точки к самой первой
            perimeter += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine($"Фигура: {Name}");
            Console.WriteLine($"Периметр многоугольника: {perimeter:F2}");
        }
    }
    #endregion
}
