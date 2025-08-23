
////1
//public class Person
//{
//    public string Name; 
//    public int Age;  

//    // Конструктор, принимающий имя и возраст
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    // Метод Greet() для вывода приветствия
//    public void Greet()
//    {
//        Console.WriteLine($"Привет, меня зовут {Name} и мне {Age} лет.");
//    }

//    // Переопределение метода ToString() для строкового представления объекта
//    public string ToString()
//    {
//        return $"Имя: {Name}, Возраст: {Age}";
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Создание объектов класса Person
//        Person person1 = new Person("Иван", 30);
//        Person person2 = new Person("Мария", 25);
//        Person person3 = new Person("Петр", 40);


//        // Вызов методов Greet() и ToString() для каждого объекта
//        person1.Greet();
//        Console.WriteLine(person1.ToString());

//        person2.Greet();
//        Console.WriteLine(person2.ToString());


//        person3.Greet();
//        Console.WriteLine(person3.ToString());
//    }
//}


////2
//class Car
//{
//    public string Model;
//    public int Year;
//    public int Mileage;

//    // Конструктор
//    public Car(string model, int year)
//    {
//        Model = model;
//        Year = year;
//        Mileage = 0;
//    }

//    // Метод Drive
//    public void Drive(int km)
//    {
//        if (km <= 0) // Проверка на корректность входных данных
//        {
//            throw new ArgumentException("Пробег не может быть отрицательным.");
//        }
//    }

//    // Переопределение ToString()
//    public override string ToString()
//    {
//        return $"Модель: {Model}, Год выпуска: {Year}, Пробег: {Mileage} км";
//    }

//    public static void Main(string[] args)
//    {
//        // Пример использования
//        Car myCar = new Car("Toyota Camry", 2022);
//        Console.WriteLine(myCar.ToString()); // Вывод начального состояния

//        myCar.Drive(100);
//        Console.WriteLine(myCar.ToString()); // Вывод после первой поездки

//        myCar.Drive(50);
//        Console.WriteLine(myCar.ToString()); // Вывод после второй поездки

//        myCar.Drive(-20); // Попытка установить отрицательный пробег
//        Console.WriteLine(myCar.ToString());

//        Car anotherCar = new Car("Ford Mustang", 1967);
//        Console.WriteLine(anotherCar.ToString());
//        anotherCar.Drive(5000);
//        Console.WriteLine(anotherCar);
//    }
//}


////3
//Student student1 = new Student("Ivan", 2, 3, 5);
//student1.GetAverage(2, 3, 5);
//Console.WriteLine(student1.ToString());

//class Student
//{
//    public string Name;
//    public int Grade1;
//    public int Grade2;
//    public int Grade3;
//    public float AverageGrade;

//    //Конструктор
//    public Student(string name, int grade1, int grade2, int grade3)
//    {
//        Name = name;
//        Grade1 = grade1;
//        Grade2 = grade2;
//        Grade3 = grade3;
//        AverageGrade = 0;
//    }

//    public float GetAverage(int grade1, int grade2, int grade3)
//    {
//        int sum = grade1 + grade2 + grade3;
//        float res = sum / 3;
//        Console.WriteLine($"{res}");
//        return AverageGrade = res;
//    }
//    public override string ToString()
//    {
//        return $"Имя: {Name}, первая оценка: {Grade1}, вторая оценка: {Grade2}, третья оценка: {Grade3}, средняя оценка: {AverageGrade}";
//    }
//}


////7
//public class Animal
//{
//    public string Name;
//    public string Species;

//    // Конструктор
//    public Animal(string name, string species)
//    {
//        Name = name;
//        Species = species;
//    }

//    public void Speak()
//    {
//        switch (Species.ToLower()) // Приводим к нижнему регистру для сравнения
//        {
//            case "собака":
//                Console.WriteLine("Гав!");
//                break;
//            case "кошка":
//                Console.WriteLine("Мяу!");
//                break;
//            case "корова":
//                Console.WriteLine("Муу!");
//                break;
//            case "свинья":
//                Console.WriteLine("Хрю!");
//                break;
//            default:
//                Console.WriteLine("Звук животного");
//                break;
//        }
//    }

//    public override string ToString()
//    {
//        return $"Имя: {Name}, Вид: {Species}";
//    }

//    public static void Main(string[] args)
//    {
//        Animal dog = new Animal("Шарик", "собака");
//        Console.WriteLine(dog.ToString());
//        dog.Speak();

//        Animal cat = new Animal("Мурка", "кошка");
//        Console.WriteLine(cat.ToString());
//        cat.Speak();

//        Animal cow = new Animal("Буренка", "корова");
//        Console.WriteLine(cow.ToString());
//        cow.Speak();
//    }
//}

//9

//Clock clock = new Clock(23, 59, 50);
//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine(clock.ToString());
//    clock.Tick();
//    Thread.Sleep(1000);
//}

//public class Clock
//{
//    public int Hours;
//    public int Minutes;
//    public int Seconds;

//    //конструктор
//    public Clock(int hours, int minutes, int seconds)
//    {
//        Hours = hours; 
//        Minutes = minutes;
//        Seconds = seconds;
//    }

//    public void Tick()
//    {
//        Seconds++;
//        if (Seconds == 60)
//        {
//            Seconds = 0;
//            Minutes++;
//            if (Minutes == 60)
//            {
//                Minutes = 0;
//                Hours++;
//                if (Hours == 24)
//                {
//                    Hours = 0;
//                }
//            }
//        }
//    }

//    public override string ToString()
//    {
//        return $"{Hours}:{Minutes}:{Seconds}";
//    }

//    //public static void Main(string[] args)
//    //{
//    //    Clock clock = new Clock(23, 59, 50);
//    //    for (int i = 0; i < 20; i++)
//    //    {
//    //        Console.WriteLine(clock);
//    //        clock.Tick();
//    //        Thread.Sleep(1000); 
//    //    }
//    //}
//}


//4
//Rectangle rect = new Rectangle(5, 10);
//Console.WriteLine(rect.ToString()); 

//Rectangle rect2 = new Rectangle(7, 3);
//Console.WriteLine(rect2.ToString()); 

//public class Rectangle
//{
//    public int Width;
//    public int Height;

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public int GetArea()
//    {
//        return Width * Height;
//    }

//    public int GetPerimeter()
//    {
//        return 2 * (Width + Height);
//    }

//    public override string ToString()
//    {
//        return $"Ширина: {Width}, Высота: {Height}, Площадь: {GetArea()}, Периметр: {GetPerimeter()}";
//    }
//}

//7
//public class Engine
//{
//    private int Power;
//    private bool IsWorking;

//    public Engine(int power)
//    {
//        if (power <= 0)
//        {
//            Console.WriteLine("Мощность не может быть ≤ 0. Установлено значение 100.");
//            Power = 100;
//        }
//        else
//        {
//            Power = power;
//        }
//        IsWorking = false;
//    }

//    public void Start()
//    {
//        if (!IsWorking)
//        {
//            IsWorking = true;
//        }
//    }

//    public void Stop()
//    {
//        IsWorking = false;
//    }

//    public string GetStatus()
//    {
//        return $"Двигатель: {Power} л.с. ({(IsWorking ? "работает" : "не работает")})";
//    }
//}

//public class Car
//{
//    private Engine engine;
//    public string Model { get; set; }

//    public Car(string model, int power)
//    {
//        Model = model;
//        engine = new Engine(power);
//    }

//    public void StartCar()
//    {
//        engine.Start();

//        Console.WriteLine($"Автомобиль {Model} запущен.");
//    }

//    public void StopCar()
//    {
//        engine.Stop();
//    }

//    public string GetCarInfo()
//    {
//        return $"Модель: {Model}. {engine.GetStatus()}";
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Car bmw = new Car("BMW", 150);
//        Console.WriteLine(bmw.GetCarInfo()); // (не работает)
//        bmw.StartCar(); //запущен.
//        Console.WriteLine(bmw.GetCarInfo()); // (работает)
//        bmw.StopCar();
//        Console.WriteLine(bmw.GetCarInfo()); // (не работает)


//        Car audi = new Car("Audi", -50);
//        Console.WriteLine(audi.GetCarInfo()); // (не работает)
//    }
//}

























//public class Student
//{
//    public string Name;
//    private int age;

//    public Student(string name, int age)
//    {
//        Name = name;
//        this.age = age;
//    }

//    public int GetAge()
//    {
//        return age;
//    }
//}

//public class Course
//{
//    private List<Student> students;
//    public int MaxStudents;

//    public Course(int maxStudents = 10)
//    {
//        MaxStudents = maxStudents;
//        students = new List<Student>();
//    }

//    public void EnrollStudent(Student student)
//    {
//        if (students.Count >= MaxStudents)
//        {
//            Console.WriteLine($"Студент не добавлен: превышен лимит студентов.");
//            return;
//        }
//        if (student.GetAge() < 16)
//        {
//            Console.WriteLine($"Студент {student.Name} слишком молод.");
//            return;
//        }
//        // Использование Any() для проверки наличия студента (можно заменить циклом foreach)
//        if (students.Any(s => s.Name == student.Name))
//        {
//            Console.WriteLine($"Студент {student.Name} уже на курсе.");
//            return;
//        }

//        students.Add(student);
//        Console.WriteLine($"Студент {student.Name} успешно добавлен на курс.");

//    }

//    public void UnenrollStudent(string name)
//    {

//        // Можно использовать RemoveAll для удаления всех совпадений
//        int removedCount = students.RemoveAll(s => s.Name == name);

//        if (removedCount > 0)
//        {
//            Console.WriteLine($"Студент {name} удален с курса.");
//        }
//        else
//        {
//            Console.WriteLine($"Студент {name} не найден на курсе.");
//        }
//    }



//    public void PrintStudents()
//    {
//        if (students.Count == 0)
//        {
//            Console.WriteLine("На курсе нет студентов.");
//            return;
//        }

//        Console.Write("Студенты курса: ");
//        for (int i = 0; i < students.Count; i++)
//        {
//            Console.Write($"{students[i].Name} ({students[i].GetAge()} лет)");
//            if (i < students.Count - 1)
//            {
//                Console.Write(", ");
//            }
//        }
//        Console.WriteLine();
//    }

//    public static void Main(string[] args)
//    {
//        Course course = new Course(4);
//        course.EnrollStudent(new Student("Иван", 20));
//        course.EnrollStudent(new Student("Мария", 22));
//        course.EnrollStudent(new Student("Петр", 15)); // Слишком молод
//        course.EnrollStudent(new Student("Иван", 20)); // Уже существует
//        course.EnrollStudent(new Student("Анна", 18));
//        course.EnrollStudent(new Student("Елена", 19));
//        course.EnrollStudent(new Student("Сергей", 21)); // Превышен лимит

//        course.PrintStudents();

//        course.UnenrollStudent("Мария");
//        course.PrintStudents();


//        Console.ReadKey();
//    }
//}


















//10
//public class Room
//{
//    public int Number { get; set; }
//    public bool IsBooked { get; set; }
//    public DateTime? BookingDate { get; set; }

//    public Room(int number)
//    {
//        Number = number;
//        IsBooked = false;
//        BookingDate = null;
//    }

//    public bool Book(DateTime date)
//    {
//        if (IsBooked && BookingDate == date)
//        {
//            Console.WriteLine("Комната уже забронирована на эту дату.");
//            return false;
//        }
//        IsBooked = true;
//        BookingDate = date;
//        return true;
//    }

//    public void Free()
//    {
//        IsBooked = false;
//        BookingDate = null;
//    }
//}

//public class Hotel
//{
//    private Room[] rooms;

//    public Hotel()
//    {
//        rooms = new Room[10];
//        for (int i = 0; i < 10; i++)
//        {
//            rooms[i] = new Room(i + 1);
//        }
//    }

//    public void BookRoom(int roomNumber, DateTime date)
//    {
//        if (roomNumber < 1 || roomNumber > 10)
//        {
//            Console.WriteLine("Комната не найдена.");
//            return;
//        }

//        Room room = rooms[roomNumber - 1];

//        if (room.IsBooked && room.BookingDate == date)
//        {
//            Console.WriteLine("Комната уже забронирована на эту дату.");
//        }
//        else if (room.Book(date))
//        {
//            Console.WriteLine($"Комната {roomNumber} успешно забронирована на {date.ToShortDateString()}.");
//        }
//    }

//    public void FreeRoom(int roomNumber)
//    {
//        if (roomNumber < 1 || roomNumber > 10)
//        {
//            Console.WriteLine("Комната не найдена.");
//            return;
//        }
//        Room room = rooms[roomNumber - 1];
//        room.Free();
//        Console.WriteLine($"Бронь с комнаты {roomNumber} снята.");
//    }

//    public int[] FindAvailableRooms(DateTime date)
//    {
//        List<int> availableRooms = new List<int>();
//        for (int i = 0; i < rooms.Length; i++)
//        {
//            if (!rooms[i].IsBooked || (rooms[i].BookingDate != null && rooms[i].BookingDate != date))
//            {
//                availableRooms.Add(rooms[i].Number);
//            }
//        }
//        return availableRooms.ToArray();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var hotel = new Hotel();
//        hotel.BookRoom(3, new DateTime(2024, 05, 01)); // Комната 3 успешно забронирована на 01.05.2024.
//        hotel.BookRoom(3, new DateTime(2024, 05, 01)); // Комната уже забронирована на эту дату.
//        hotel.BookRoom(3, new DateTime(2024, 05, 02)); // Комната 3 успешно забронирована на 02.05.2024.
//        hotel.FreeRoom(3); // Бронь с комнаты 3 снята.
//        hotel.BookRoom(11, new DateTime(2024, 05, 01)); // Комната не найдена.

//        Console.WriteLine("Свободные комнаты на 01.05.2024:");
//        foreach (var roomNumber in hotel.FindAvailableRooms(new DateTime(2024, 05, 01)))
//        {
//            Console.Write(roomNumber + " ");
//        }
//        Console.WriteLine();
//    }
//}










// 1.
//using System.Globalization;

//public class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Рисуем некоторую фигуру...");
//    }
//}

//// 2.
//public class Circle : Shape
//{
//    public double Radius {get; set;}

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    // Переопределяем метод Draw() для рисования круга
//    public override void Draw()
//    {
//        Console.WriteLine($"Рисуем круг радиусом {Radius}");
//    }
//}

//// 3. 
//public class Rectangle : Shape
//{
//    public double Width {get; set;}
//    public double Height {get; set;}

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    // Переопределяем метод Draw() для рисования прямоугольника
//    public override void Draw()
//    {
//        Console.WriteLine($"Рисуем прямоугольник размером {Width}x{Height}");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // 4. Создаем список Shape
//        List<Shape> shapes = new List<Shape>();

//        shapes.Add(new Circle(5.0));
//        shapes.Add(new Rectangle(4.0, 6.0));
//        shapes.Add(new Circle(2.5));
//        shapes.Add(new Shape()); 

//        // Вызываем Draw() для каждого объекта, используя полиморфизмa
//        Console.WriteLine("Демонстрация полиморфизма:");
//        foreach (Shape shape in shapes)
//        {
//            shape.Draw(); 
//        }
//    }
//}


//The chatterbox robot cafe
//public class Order
//{
//    public string ProductName;
//    public int Price;

//    public Order(string productName, int price)
//    {
//        ProductName = productName;
//        Price = price;
//    }

//    public override string ToString()
//    {
//        return $"{ProductName} ({Price})";
//    }
//}
//public abstract class WaiterRobot
//{
//    public string Name;
//    public WaiterRobot(string name)
//    {
//        Name = name;
//    }

//    public abstract void Greet(Order order);
//    public override string ToString()
//    {
//        return Name;
//    }
//}

//public class BoorRobot1 : WaiterRobot
//{
//    public BoorRobot1() : base(nameof(BoorRobot1))
//    {

//    }

//    public override void Greet(Order order)
//    {
//        Console.ForegroundColor = ConsoleColor.Magenta;
//        Console.WriteLine($"Получай худший заказ, который только можно было придумать" +
//            $": {order.ProductName} - {order.Price}Р.");
//    }
//}

//public class FriendlyRobot1 : WaiterRobot
//{
//    public FriendlyRobot1() : base("FriendlyRobot")
//    {

//    }
//    public override void Greet(Order order)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine($"Пожалуйста, вот ваш заказ: {order.ProductName} - {order.Price}Р.");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Order> menuItems = new List<Order>
//        { 
//          new Order("Espresso", 180),
//          new Order("Latte", 250),
//          new Order("Чизкейк", 300),
//          new Order("Макарун", 150),
//          new Order("Чай матча", 200)
//        };
//        List<WaiterRobot> robots = new List<WaiterRobot>
//        { 
//          new BoorRobot1(),
//          new FriendlyRobot1()
//        };

//        Console.WriteLine("Добро пожаловать в Кафе-робот-болтун!");


//        while (true)
//        {
//            Console.WriteLine("\n----------------------------------------");

//            Console.WriteLine("Выберите робота (введите номер):");
//            for (int i = 0; i < robots.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {robots[i].Name}");
//            }
//            Console.WriteLine("0. Выйти из программы");

//            Console.Write("Ваш выбор робота: ");
//            string robotInput = Console.ReadLine();

//            if (robotInput == "0")
//            {
//                break;
//            }

//            if (!int.TryParse(robotInput, out int robotChoice) || robotChoice < 1 || robotChoice > robots.Count)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Неверный номер робота. Пожалуйста, попробуйте снова.");
//                Console.ResetColor();
//                continue; 
//            }

//            WaiterRobot selectedRobot = robots[robotChoice - 1];

//            Console.WriteLine("\nВыберите заказ из меню (введите номер):");
//            for (int i = 0; i < menuItems.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {menuItems[i].ProductName} ({menuItems[i].Price})");
//            }

//            Console.Write("Ваш выбор заказа: ");
//            string orderInput = Console.ReadLine();

//            if (!int.TryParse(orderInput, out int orderChoice) || orderChoice < 1 || orderChoice > menuItems.Count)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Неверный номер заказа. Пожалуйста, попробуйте снова.");
//                Console.ResetColor();                
//                continue;
//            }

//            Order selectedOrder = menuItems[orderChoice - 1];

//            selectedRobot.Greet(selectedOrder);
//            Console.WriteLine("------------------------------");
//        }

//        Console.WriteLine("\nПрограмма завершена. До свидания!");
//    }
//}



//8

// 1. Класс для представления планеты
//public class Planet
//{
//    public string Name { get; }
//    public double TaxRate { get; } // Коэффициент налога (доля от базовой цены)

//    public Planet(string name, double taxRate)
//    {
//        Name = name;
//        TaxRate = taxRate;
//    }

//    public override string ToString()
//    {
//        return $"{Name} (налог: {TaxRate:P})"; 
//    }
//}

//// 2. Базовый класс для грузов
//public abstract class Cargo
//{
//    public string Name { get; }
//    public double BasePrice { get; } = 1000;

//    protected Cargo(string name)
//    {
//        Name = name;
//    }

//    // Абстрактный метод, который ОБЯЗАН переопределяться в производных классах
//    // для вычисления надбавки к цене
//    public abstract double GetSurcharge();

//    public override string ToString()
//    {
//        return Name;
//    }
//}


//// 3. Производные классы для разных типов грузов
//public class Food : Cargo
//{
//    public Food() : base("Еда") { }
//    public override double GetSurcharge() => BasePrice * 0.1; 
//}

//public class Weapon : Cargo
//{
//    public Weapon() : base("Оружие") { }
//    public override double GetSurcharge() => BasePrice * 0.3; 
//}

//public class Equipment : Cargo
//{
//    public Equipment() : base("Техника") { }
//    public override double GetSurcharge() => BasePrice * 0.2; 
//}
//public class Clothes : Cargo
//{
//    public Clothes() : base("Одежда") { }
//    public override double GetSurcharge() => BasePrice * 0.4;
//}

//public class SphynxCat : Cargo
//{
//    public SphynxCat() : base("Коты-сфинксы") { }
//    public override double GetSurcharge() => BasePrice * 0.5;
//}

//// 4. Класс для расчета стоимости доставки
//public class DeliveryCalculator
//{
//    private List<Planet> _planets;
//    private List<Cargo> _cargoTypes;
//    private List<(Planet planet, Cargo cargo, double finalPrice)> _deliveryHistory = new List<(Planet, Cargo, double)>();

//    public DeliveryCalculator(List<Planet> planets, List<Cargo> cargoTypes)
//    {
//        _planets = planets;
//        _cargoTypes = cargoTypes;
//    }

//    public void CalculateDeliveryCost()
//    {
//        Console.WriteLine("\nВыберите планету: ");
//        for (int i = 0; i < _planets.Count; i++)
//        {
//            Console.WriteLine($"{i+1}. {_planets[i]}");
//        }

//        // Ввод номера планеты пользователем
//        int planetChoice;
//        if (!int.TryParse(Console.ReadLine(), out planetChoice) || planetChoice < 1 || planetChoice > _planets.Count)
//        {
//            Console.WriteLine("Неверный номер планеты!");
//            return;
//        }

//        Planet selectedPlanet = _planets[planetChoice - 1];

//        Console.WriteLine("\nВыберите тип груза:");
//        for (int i = 0; i < _cargoTypes.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {_cargoTypes[i]}");
//        }

//        // Ввод номера груза пользователем
//        int cargoChoice;
//        if (!int.TryParse(Console.ReadLine(), out cargoChoice) || cargoChoice < 1 || cargoChoice > _cargoTypes.Count)
//        {
//            Console.WriteLine("Неверный номер груза!");
//            return;
//        }

//        Cargo selectedCargo = _cargoTypes[cargoChoice - 1];


//        // Расчет итоговой стоимости
//        double finalPrice = selectedCargo.BasePrice * (1 + selectedPlanet.TaxRate) + selectedCargo.GetSurcharge();

//        // Запись в историю доставки
//        _deliveryHistory.Add((selectedPlanet, selectedCargo, finalPrice));

//        Console.WriteLine($"\nИтоговая стоимость доставки на планету {selectedPlanet.Name}:");
//        Console.WriteLine($"Формула: {selectedCargo.BasePrice} * (1 + {selectedPlanet.TaxRate}) + {selectedCargo.GetSurcharge()} = {finalPrice:F2} кредов");
//    }

//    public void ShowDeliveryHistory()
//    {
//        Console.WriteLine("\nИстория доставок:");
//        if (_deliveryHistory.Count == 0)
//        {
//            Console.WriteLine("История пуста.");
//        }
//        else
//        {
//        foreach (var delivery in _deliveryHistory)
//            {
//                Console.WriteLine($"Планета: {delivery.planet.Name}, Груз: {delivery.cargo.Name}, Стоимость: {delivery.finalPrice:F2} кредов");
//            }
//        }
//    }



//}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Planet> planets = new List<Planet>
//{
//new Planet("Альфа", 0.05),
//new Planet("Бета", 0.18),
//new Planet("Гамма", 0.12),
//new Planet("Дельта", 0.08)
//};


//        List<Cargo> cargoTypes = new List<Cargo>
//    {
//        new Food(),
//        new Weapon(),
//        new Equipment(),
//        new SphynxCat()
//    };

//        DeliveryCalculator calculator = new DeliveryCalculator(planets, cargoTypes);

//        while (true)
//        {
//            Console.WriteLine("\nГалактическая доставка S-42");
//            Console.WriteLine("1. Рассчитать стоимость доставки");
//            Console.WriteLine("2. Просмотреть историю доставок");
//            Console.WriteLine("0. Выйти");

//            Console.Write("Ваш выбор: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    calculator.CalculateDeliveryCost();
//                    break;
//                case "2":
//                    calculator.ShowDeliveryHistory();
//                    break;
//                case "0":
//                    Console.WriteLine("Программа завершена.");
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//    }
//}





//book
//using System.Net.Http.Headers;


//Dictionary<List<Books>, Authors> booksByAuthors = new();
//var tolstoy = new Authors("Лев Николачевич Толстой");
//var pushkin = new Authors("Александр Сергеевич Пушкин");
////List<string> pushka = new List<string>()
////{"Онегин", "Капитанская дочка" };
////List<string> bookByTolsto = new List<string>()
////{"Война и мир", "Анна Каренина"};
//var onegin = new Books("Онегин");
//List<Books> booksByPushkin = new List<Books>()
//{ onegin };
//var warAndPeace = new Books("Война и мир");
//List<Books> booksByTolstoy = new List<Books> { warAndPeace };
//booksByAuthors.Add(booksByPushkin, pushkin);
//booksByAuthors.Add(booksByTolstoy, tolstoy);

//foreach (var book in booksByAuthors)
//{
//    Console.WriteLine(book);
//}

//public class Books
//{
//    public string Book;
//    public Books(string book)
//    {
//        Book = book;
//    }   
//}

//public class Authors
//{
//    public string Author;
//    public Authors(string author)
//    {
//        Author = author;
//    }
//}




//1 oop3

//namespace AliveFigures
//{
//    public abstract class Figure
//    {
//        private int _areaCallCount; // Приватное поле для хранения количества запросов площади
//        public string Name { get; private set; }

//        // Публичное свойство для доступа к счетчику запросов площади (только для чтения)
//        public int AreaQueryCount => _areaCallCount;

//        protected Figure(string typeName, string customName = null)
//        {
//            if (string.IsNullOrWhiteSpace(typeName))
//                throw new ArgumentException("Имя типа фигуры не может быть пустым.", nameof(typeName));

//            Name = string.IsNullOrWhiteSpace(customName) ? typeName : customName;
//            _areaCallCount = 0; // Инициализируем счетчик при создании фигуры
//        }

//        protected abstract double CalculateSpecificArea();

//        public double GetArea()
//        {
//            _areaCallCount++;
//            return CalculateSpecificArea();
//        }

//        public abstract string GetDescription();

//        public void ReportAreaQueryCount()
//        {
//            Console.WriteLine($"Фигура '{Name}' была запрошена о площади {AreaQueryCount} раз(а).");
//        }
//    }

//    public class Circle : Figure
//    {
//        public double Radius { get; private set; }

//        public Circle(double radius, string customName = null)
//            : base("Круг", customName)
//        {
//            if (radius <= 0)
//                throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть положительным.");
//            Radius = radius;
//        }

//        protected override double CalculateSpecificArea()
//        {
//            return Math.PI * Radius * Radius;
//        }


//        public override string GetDescription()
//        {
//            return $"Я - Круг '{Name}' с радиусом {Radius}.";
//        }
//    }

//    public class Square : Figure
//    {
//        public double SideLength { get; private set; }

//        public Square(double sideLength, string customName = null)
//            : base("Квадрат", customName)
//        {
//            if (sideLength <= 0)
//                throw new ArgumentOutOfRangeException(nameof(sideLength), "Длина стороны должна быть положительной.");
//            SideLength = sideLength;
//        }

//        protected override double CalculateSpecificArea()
//        {
//            return SideLength * SideLength;
//        }

//        public override string GetDescription()
//        {
//            return $"Я - Квадрат '{Name}' со стороной {SideLength}.";
//        }
//    }

//    public class Triangle : Figure
//    {
//        public double BaseLength { get; private set; }
//        public double Height { get; private set; }

//        public Triangle(double baseLength, double height, string customName = null)
//            : base("Треугольник", customName)
//        {
//            if (baseLength <= 0 || height <= 0)
//                throw new ArgumentOutOfRangeException("Основание и высота должны быть положительными.");
//            BaseLength = baseLength;
//            Height = height;
//        }

//        protected override double CalculateSpecificArea()
//        {
//            return 0.5 * BaseLength * Height;
//        }

//        public override string GetDescription()
//        {
//            return $"Я - Треугольник '{Name}' с основанием {BaseLength} и высотой {Height}.";
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {

//            Console.WriteLine("--- Ожившие Фигуры: Демонстрация ---");

//            Figure myCircle = new Circle(5.0, "МойЛюбимыйКруг");
//            Figure genericSquare = new Square(4.0);              
//            Figure bigTriangle = new Triangle(10.0, 6.0, "БольшойТреугольник");
//            Figure smallCircle = new Circle(2.5);

//            List<Figure> figures = new List<Figure> { myCircle, genericSquare, bigTriangle, smallCircle };

//            foreach (var figure in figures)
//            {
//                Console.WriteLine(figure.GetDescription());
//            }

//            Console.WriteLine("\n--- Запросы площади и счетчики ---");

//            Console.WriteLine($"Площадь {myCircle.Name}: {myCircle.GetArea():F2}"); // 1й запрос
//            Console.WriteLine($"Площадь {myCircle.Name}: {myCircle.GetArea():F2}"); // 2й запрос
//            Console.WriteLine($"Площадь {genericSquare.Name}: {genericSquare.GetArea():F2}"); // 1й запрос
//            Console.WriteLine($"Площадь {genericSquare.Name}: {genericSquare.GetArea():F2}"); // 2й запрос
//            Console.WriteLine($"Площадь {genericSquare.Name}: {genericSquare.GetArea():F2}"); // 3й запрос
//            Console.WriteLine($"Площадь {bigTriangle.Name}: {bigTriangle.GetArea():F2}"); // 1й запрос

//            Console.WriteLine("\n--- Отчеты о запросах площади ---");


//            foreach (var figure in figures)
//            {
//                figure.ReportAreaQueryCount();
//            }
//        }
//    }
//}



//1
//Shelter shelter = new Shelter();

//// Подписка на события
//shelter.AnimalAdded += animal =>
//    Console.WriteLine($"Добавлено животное: {animal.Type}, кличка: {animal.Name}, возраст: {animal.Age} лет. Осталось животных: {shelter.GetAnimalCount()}");

//shelter.AnimalRemoved += animal =>
//    Console.WriteLine($"Забрано животное: {animal.Type}, кличка: {animal.Name}, возраст: {animal.Age} лет. Осталось животных: {shelter.GetAnimalCount()}");

//shelter.AddAnimal(new Animal("Бобик", "Собака", 3));
//shelter.AddAnimal(new Animal("Мурка", "Кошка", 2));

//shelter.RemoveAnimal("Бобик");

//shelter.RemoveAnimal("Шарик");

//shelter.AddAnimal(new Animal("Рекс", "Собака", 4));


//public class Animal
//{
//    public string Name { get; set; }
//    public string Type { get; set; }
//    public int Age { get; set; }

//    public Animal(string name, string type, int age)
//    {
//        Name = name;
//        Type = type;
//        Age = age;
//    }
//}

//public class Shelter
//{
//    private Dictionary<string, Animal> animals = new Dictionary<string, Animal>();

//    // События для уведомления
//    public event Action<Animal> AnimalAdded;
//    public event Action<Animal> AnimalRemoved;

//    public void AddAnimal(Animal animal)
//    {
//        if (!animals.ContainsKey(animal.Name))
//        {
//            animals[animal.Name] = animal;
//            AnimalAdded?.Invoke(animal); 
//        }
//        else
//        {
//            Console.WriteLine($"Животное с кличкой '{animal.Name}' уже существует.");
//        }
//    }

//    public void RemoveAnimal(string name)
//    {
//        if (animals.TryGetValue(name, out Animal animalToRemove))
//        {
//            animals.Remove(name);
//            AnimalRemoved?.Invoke(animalToRemove);
//        }
//        else
//        {
//            Console.WriteLine("Животное с такой кличкой не найдено.");
//        }
//    }

//    public int GetAnimalCount()
//    {
//        return animals.Count;
//    }
//}



//using System;
//using System.Collections.Generic;

//public interface IDisplayable
//{
//    public void DisplayInfo();
//}

//public abstract class People<T> : IDisplayable
//{
//    public T Characteristics { get; set; }

//    public abstract void DisplayInfo();
//}


//2.Класс Person


//public class Person : People<PersonCharacteristics>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Gender { get; set; }
//    public string Address { get; set; }
//    public string PhoneNumber { get; set; }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Address: {Address}, Phone: {PhoneNumber}");
//        Console.WriteLine($"Characteristics: Height: {Characteristics.Height}, Weight: {Characteristics.Weight}, " +
//                          $"Race: {Characteristics.Race}, Eye Color: {Characteristics.EyeColor}");
//    }
//}

//public class PersonCharacteristics
//{
//    public double Height { get; set; }
//    public double Weight { get; set; }
//    public string Race { get; set; }
//    public string EyeColor { get; set; }
//}

//3.Классы Employee и его наследники

//public abstract class Employee : People<EmployeeCharacteristics>
//{
//    public int EmployeeId { get; set; }
//    public string Position { get; set; }
//    public decimal Salary { get; set; }
//    public DateTime HireDate { get; set; }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Employee ID: {EmployeeId}, Position: {Position}, Salary: {Salary}, Hire Date: {HireDate}");
//        Console.WriteLine($"Characteristics: Height: {Characteristics.Height}, Weight: {Characteristics.Weight}, " +
//                          $"Race: {Characteristics.Race}, Eye Color: {Characteristics.EyeColor}");
//    }
//}

//public class EmployeeCharacteristics
//{
//    public double Height { get; set; }
//    public double Weight { get; set; }
//    public string Race { get; set; }
//    public string EyeColor { get; set; }
//}

//public class Teacher : Employee
//{
//    public string Subject { get; set; }
//    public int TeachingExperience { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Subject: {Subject}, Teaching Experience: {TeachingExperience} years");
//    }
//}

//public class Student : Employee
//{
//    public int Course { get; set; }
//    public string Major { get; set; }
//    public double GPA { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Course: {Course}, Major: {Major}, GPA: {GPA}");
//    }
//}

//public class Manager : Employee
//{
//    public string ManagementArea { get; set; }
//    public int SubordinatesCount { get; set; }
//    public int ManagementExperience { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Management Area: {ManagementArea}, Subordinates Count: {SubordinatesCount}, Management Experience: {ManagementExperience} years");
//    }
//}

//public class Programmer : Employee
//{
//    public string ProgrammingLanguage { get; set; }
//    public List<string> ProjectsWorkedOn { get; set; } = new List<string>();
//    public string Specialization { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Programming Language: {ProgrammingLanguage}, Specialization: {Specialization}");
//        Console.WriteLine("Projects Worked On: " + string.Join(", ", ProjectsWorkedOn));
//    }
//}

////Пример использования


//class Program
//{
//    static void Main(string[] args)
//    {
//        var person = new Person
//        {
//            Name = "Майкл Джексон",
//            Age = 30,
//            Gender = "Male",
//            Address = "123 Main St",
//            PhoneNumber = "123-456-7890",
//            Characteristics = new PersonCharacteristics
//            {
//                Height = 180,
//                Weight = 75,
//                Race = "Caucasian",
//                EyeColor = "Blue"
//            }
//        };

//        person.DisplayInfo();

//        var teacher = new Teacher
//        {
//            EmployeeId = 1,
//            Position = "Math Teacher",
//            Salary = 50000,
//            HireDate = DateTime.Now,
//            Subject = "Mathematics",
//            TeachingExperience = 5,
//            Characteristics = new EmployeeCharacteristics
//            {
//                Height = 170,
//                Weight = 65,
//                Race = "Hispanic",
//                EyeColor = "Brown"
//            }
//        };

//        teacher.DisplayInfo();
//    }
//}

//2
Store store = new Store();
store.StartShopping();

public class Store
{
    private List<Product> products;
    private Cart cart;
    private bool _extraUIEnabled;

    public Store()
    {
        products = new List<Product>
        {
            new Product("Товар 1", 100),
            new Product("Товар 2", 200),
            new Product("Товар 3", 300)
        };
        cart = new Cart();
        cart.Added += OnCartAdded;
    }

    private void OnCartAdded(CartItem item)
    {
        _extraUIEnabled = true;
    }

    public void StartShopping()
    {
        while (true)
        {
            Console.WriteLine("\nДоступные товары:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - {products[i].Price} руб.");
            }

            Console.WriteLine("Введите номер товара для добавления в корзину (или '0' для завершения):");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            if (int.TryParse(input, out int productIndex) && productIndex > 0 && productIndex <= products.Count)
            {
                Console.WriteLine("Введите количество:");
                int quantity = int.Parse(Console.ReadLine());
                cart.AddToCart(products[productIndex - 1], quantity);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }

            if (_extraUIEnabled)
                ShowCartOptions();
        }
    }
        public void ShowCartOptions()
        {
            //if (cart.ItemCount > 0)
            //{
            //    Console.WriteLine("\nКорзина:");
            //    foreach (var item in cart.Items)
            //    {
            //        Console.WriteLine($"{item.Product.Name}: {item.Quantity}");
            //    }

            Console.WriteLine($"Общее количество товаров: {cart.ItemCount}");
            //Console.WriteLine($"Общее количество товаров: {cart.Quantity}");

            //if (cart.ItemCount >= 1)
                    Console.WriteLine("1. Показать список товаров в магазине");
                //if (cart.ItemCount >= 1)
                    Console.WriteLine("2. Очистить корзину");
                //if (cart.ItemCount >= 1)
                    Console.WriteLine("3. Купить товары в корзине");

                string actionInput = Console.ReadLine();
                PerformCartAction(actionInput);
            //}
        }

        private void PerformCartAction(string actionInput)
        {
            switch (actionInput)
            {
                case "1":
                    cart.ShowItems();
                    break;
                case "2":
                    cart.Clear();
                    Console.WriteLine("Корзина очищена.");
                    break;
                case "3":
                    cart.Purchase();
                    break;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
    
}


public class Product
{
    public string Name { get; }
    public int Price { get; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

public class Cart
{
    public List<CartItem> Items;
    public int ItemCount;
    public event Action<CartItem> Added;

    public Cart()
    {
        Items = new List<CartItem>();
    }

    public void AddToCart(Product product, int quantity)
    {
        if (ItemCount + quantity > 10)
        {
            Console.WriteLine("Корзина переполнена. Нельзя добавить новые товары.");
            return;
        }
        var kkk = new CartItem(product, quantity);
        var existingItem = Items.Find(item => item.Product == product);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
            ItemCount += quantity;
        }
        else
        {
            Items.Add(kkk);
            ItemCount += quantity;
        }

        Added?.Invoke(kkk);
        Console.WriteLine($"{quantity} {product.Name} добавлено в корзину.");
    }
     
    public void Clear()
    {
        Items.Clear();
    }

    public void ShowItems()
    {
        Console.WriteLine("\nСписок товаров в корзине:");
        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Product.Name}: {item.Quantity}");
        }
    }

    public void Purchase()
    {
        if (ItemCount == 0)
        {
            Console.WriteLine("Корзина пуста. Нельзя совершить покупку.");
            return;
        }

        decimal total = 0;
        foreach (var item in Items)
        {
            total += item.Product.Price * item.Quantity;
        }

        Console.WriteLine($"Вы купили {ItemCount} товаров на сумму {total} руб.");
        Clear(); // Очищаем корзину после покупки
    }
}

public class CartItem
{
    public Product Product;
    public int Quantity;

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public CartItem() { }

}
