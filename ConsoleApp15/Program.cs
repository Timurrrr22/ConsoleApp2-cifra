using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

//using Testr = SpaceTest.Test;

//Testr.Hello();

//abstract class Animal
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Animal(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public abstract double CalculateFood();
//}

//class Carnivore : Animal //хищные
//{
//    public Carnivore(int id, string name) : base(id, name) { }

//    public override double CalculateFood()
//    {
//        return 5.0; 
//    }
//}

//class Herbivore : Animal //травоядные
//{
//    public Herbivore(int id, string name) : base(id, name) { }

//    public override double CalculateFood()
//    {
//        return 10.0; 
//    }
//}

//class Omnivore : Animal //всеядные
//{
//    public Omnivore(int id, string name) : base(id, name) { }

//    public override double CalculateFood()
//    {
//        return 7.5;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Animal> animals = new List<Animal>
//        {
//            new Carnivore(1, "Lion"),
//            new Herbivore(2, "Elephant"),
//            new Omnivore(3, "Bear"),
//            new Carnivore(4, "Tiger"),
//            new Herbivore(5, "Giraffe"),
//            new Omnivore(6, "Pig")
//        };

//        //Упорядочивание по количеству еды
//        var sortedAnimals = animals
//            .OrderByDescending(a => a.CalculateFood())
//            .ThenBy(a => a.Name)
//            .ToList();

//        foreach (var animal in sortedAnimals)
//        {
//            Console.WriteLine($"{animal.Id}: {animal.Name}, {animal.GetType().Name}, {animal.CalculateFood()} kg");
//        }
//    }
//}


//using Microsoft.VisualBasic;
//using System.Linq;

//var tuple = (12, 234);

//var str = "hcgyuilsuifviufvjheb4u3okekjddnchxgfs";
//string example = "george russell, carlos sainz, lewis hamilton, max verstappen, oscar piastri, lando norris, charles leclerc" +
//    "bearman oliver";
//Console.WriteLine("Введите символ, количество которого вам необходимо узнать в строке: ");
//char symbol = (char)Console.Read();
//int vCount = example.FindQuantityOf(symbol);

//Console.WriteLine($"Количество символов {symbol} в строке: {vCount}");

//public class BankAccount
//{
//    public string AccountNumber { get; set; }
//    public decimal Balance { get; set; }

//    public BankAccount(string accountNumber,decimal balance)
//    {
//        AccountNumber = accountNumber;
//        Balance = balance;
//    }

//    public void Deposit(decimal amount)
//    {
//        Balance += amount;
//        Console.WriteLine($"Deposited {amount} to account {AccountNumber}. New balance: {Balance}");
//    }

//    public bool Withdraw(decimal amount)
//    {
//        if (amount > Balance)
//        {
//            Console.WriteLine($"Недостаточно средств {AccountNumber}.");
//            return false;
//        }
//        Balance -= amount;
//        Console.WriteLine($"Withdrew {amount} from account {AccountNumber}. New balance: {Balance}");
//        return true;
//    }
//}

//public class CreditCard
//{
//    public string CardNumber { get; set; }
//    public bool IsBlocked { get; set; }

//    public CreditCard(string cardNumber)
//    {
//        CardNumber = cardNumber;
//        IsBlocked = false;
//    }

//    public void Block()
//    {
//        IsBlocked = true;
//        Console.WriteLine($"Credit card {CardNumber} has been blocked.");
//    }
//}

//public class Order
//{
//    public string OrderId { get; set; }
//    public decimal Amount { get; set; }

//    public Order(string orderId, decimal amount)
//    {
//        OrderId = orderId;
//        Amount = amount;
//    }
//}

//public class Client
//{
//    public string Name { get; set; }
//    public BankAccount Account { get; set; }
//    public CreditCard Card { get; set; }

//    public Client(string name, BankAccount account, CreditCard card)
//    {
//        Name = name;
//        Account = account;
//        Card = card;
//    }

//    public void PayForOrder(Order order)
//    {
//        if (Card.IsBlocked)
//        {
//            Console.WriteLine($"Cannot pay for order {order.OrderId}. Card is blocked.");
//            return;
//        }

//        if (Account.Withdraw(order.Amount))
//        {
//            Console.WriteLine($"Payment of {order.Amount} for order {order.OrderId} was successful.");
//        }
//    }

//    public void TransferToAccount(BankAccount targetAccount, decimal amount)
//    {
//        if (Account.Withdraw(amount))
//        {
//            targetAccount.Deposit(amount);
//            Console.WriteLine($"Transferred {amount} to account {targetAccount.AccountNumber}.");
//        }
//    }

//    public void CancelAccount()
//    {
//        Console.WriteLine($"Account {Account.AccountNumber} has been cancelled.");
//        Account = null; 
//    }
//}

//public class Administrator
//{
//    public void BlockCreditCard(CreditCard card)
//    {
//        card.Block();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var clientAccount = new BankAccount("123456789", 1000);
//        var clientCard = new CreditCard("987654321");
//        var client = new Client("John Doe", clientAccount, clientCard);

//        var order1 = new Order("Order1", 200);
//        client.PayForOrder(order1);

//        var admin = new Administrator();
//        admin.BlockCreditCard(clientCard);

//        var order2 = new Order("Order2", 300);
//        client.PayForOrder(order2);

//        client.TransferToAccount(new BankAccount("987654321", 500), 150);

//        client.CancelAccount();
//    }
//}

//public class Test
//{
//    public static void Main()
//    {
//        DateTime currentTime = DateTime.Now;
//        currentTime.Print("loh");
//    }
//}

//public static class MyExtension
//{
//    public static void Print(this DateTime dateTime, string str) { Console.WriteLine(dateTime.ToString(), str); }
//}



//public static class StringExtensions
//{
//    public static int FindQuantityOf(this string str, char symbol)
//    {
//        int count = 0;

//        foreach (char c in str)
//        {
//            if (c == symbol)
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}






//Operation operation = Calc.Summ;
//operation += Calc.Subtraction;
//operation += Calc.Multiplication;
//operation += Calc.Division;
//bool startProgeram = true;
//while (startProgeram)
//{
//    Console.Write(" Введите значение 1: ");
//    double.TryParse(Console.ReadLine(), out double userInputNumberOne);
//    Console.Write("  Введите значение 2: ");
//    double.TryParse(Console.ReadLine(), out double userInputNumberTwo);






//    operation(4, 7);
//    Console.WriteLine(" Хотите выйти из программы? Если да, то пиши да, если нет, то ничего");
//}


//internal static class Calc
//{
//    internal static void Summ(double NumberOne, double NumberTwo)
//    {
//        Console.WriteLine($" Сумма значений {NumberOne} и {NumberTwo} = {NumberOne + NumberTwo}");
//    }

//    internal static void Subtraction(double NumberOne, double NumberTwo)
//    {
//        Console.WriteLine($" Разность значений {NumberOne} и {NumberTwo} = {NumberOne - NumberTwo}");
//    }

//    internal static void Multiplication(double NumberOne, double NumberTwo)
//    {
//        Console.WriteLine($" Умножение значений {NumberOne} и {NumberTwo} = {NumberOne * NumberTwo}");
//    }

//    internal static void Division(double NumberOne, double NumberTwo)
//    {
//        Console.WriteLine($" Деление значений {NumberOne} и {NumberTwo} = {NumberOne / NumberTwo}");
//    }

//}

//internal delegate void Operation(double one, double two);



//class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> tasks = new List<string>();
//        string userInput;

//        do
//        {
//            Console.Clear();
//            Console.WriteLine("Управление задачами");
//            Console.WriteLine("1. Добавить задачу");
//            Console.WriteLine("2. Удалить задачу");
//            Console.WriteLine("3. Просмотреть задачи");
//            Console.WriteLine("4. Выход");
//            Console.Write("Выберите действие (1-4): ");
//            userInput = Console.ReadLine();

//            switch (userInput)
//            {
//                case "1":
//                    AddTask(tasks);
//                    break;
//                case "2":
//                    RemoveTask(tasks);
//                    break;
//                case "3":
//                    ViewTasks(tasks);
//                    break;
//                case "4":
//                    Console.WriteLine("Выход из программы...");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1-4.");
//                    break;
//            }

//            if (userInput != "4")
//            {
//                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                Console.ReadKey();
//            }

//        } while (userInput != "4");
//    }

//    static void AddTask(List<string> tasks)
//    {
//        Console.Write("Введите описание задачи: ");
//        string taskDescription = Console.ReadLine();
//        tasks.Add(taskDescription);
//        Console.WriteLine("Задача добавлена.");
//    }

//    static void RemoveTask(List<string> tasks)
//    {
//        ViewTasks(tasks);

//        if (tasks.Count > 0)
//        {
//            Console.Write("Введите номер задачи для удаления: ");
//            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
//            {
//                tasks.RemoveAt(taskNumber - 1);
//                Console.WriteLine("Задача удалена.");
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер задачи.");
//            }
//        }
//    }

//    static void ViewTasks(List<string> tasks)
//    {
//        if (tasks.Count == 0)
//        {
//            Console.WriteLine("Список задач пуст.");
//        }
//        else
//        {
//            Console.WriteLine("Список задач:");
//            for (int i = 0; i < tasks.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {tasks[i]}");
//            }
//        }
//    }
//}


//3.Проверка на уникальность: 
//Напишите функцию, которая  принимает  массив  и  возвращает  true, если 
//все  элементы  в  массиве  уникальны, и  false  в  противном  случае. 
//Используйте HashSet для решения этой задачи.

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array1 = { 1, 2, 3, 4, 5 };
//        int[] array2 = { 1, 2, 3, 4, 5, 3 };

//        Console.WriteLine($"Массив 1 уникален: {AreElementsUnique(array1)}"); 
//        Console.WriteLine($"Массив 2 уникален: {AreElementsUnique(array2)}"); 
//    }

//    static bool AreElementsUnique(int[] array)
//    {
//        HashSet<int> uniqueElements = new HashSet<int>();

//        foreach (int element in array)
//        {

//            if (!uniqueElements.Add(element))
//            {
//                return false; 
//            }
//        }
//        return true; 
//    }
//}

//void SwapValues<T>(ref T firstValue, ref T secondValue)
//{
//    T terminalValie = firstValue; // Сохраняем первое значение
//    firstValue = secondValue; // Записываем в первое значение второе
//    secondValue = terminalValie; // Записываем во второе значение сохраненное первое
//}


//int firstNumber = 10;
//int secondNumber = 20;
//SwapValues(ref firstNumber, ref secondNumber);
//double firstFractionalNumber = 1.256;
//double secondFractionalNumber = 12.211;
//SwapValues(ref firstFractionalNumber, ref secondFractionalNumber);
//string firstStr = "Bogdan";
//string secondStr = "Teacher";
//SwapValues(ref firstStr, ref secondStr);


//class Program
//{
//    static async Task Main()
//    {
//        using var client = new HttpClient();
//        string url = "https://wttr.in/Nizhny+Novgorod?format=j1";

//        try
//        {
//            string response = await client.GetStringAsync(url);
//            Console.WriteLine(response);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка запроса: {ex.Message}");
//        }
//    }
//}

////1
//partial class Program
//{
//    delegate int MultiplyDelegate(int a, int b);

//    static void Main()
//    {
//        // Создаем анонимный метод для умножения
//        MultiplyDelegate multiply = delegate (int a, int b)
//        {
//            return a * b;
//        };

//        int result = multiply(5, 10);
//        Console.WriteLine($"Умножение: 5 * 10 = {result}");
//    }
//}

//2
//partial class Program
//{
//    delegate bool IsEvenDelegate(int number);

//    static void Main()
//    {
//        // Создаем анонимный метод для определения четности
//        IsEvenDelegate isEven = delegate (int number)
//        {
//            if (number % 2 == 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        };

//        int numberToCheck = 4;
//        bool isEvenResult = isEven(numberToCheck);
//        Console.WriteLine($"Число {numberToCheck} четное: {isEvenResult}");
//    }
//}

////3
//partial class Program
//{
//    delegate long FactorialDelegate(int number);

//    static void Main()
//    {
//        // Создаем анонимный метод для вычисления факториала
//        FactorialDelegate factorial = delegate (int number)
//        {
//            long result = 1;
//            for (int i = 1; i <= number; i++)
//            {
//                result *= i;
//            }
//            return result;
//        };

//        int numberToFactorial = 5;
//        long factorialResult = factorial(numberToFactorial);
//        Console.WriteLine($"Факториал числа {numberToFactorial} = {factorialResult}");
//    }
//}

//4
//partial class Program
//{
//    delegate int Max(int[] numbers);

//    static void Main()
//    {
//        Max max = delegate (int[] numbers)
//        {
//            int max = numbers[0];
//            foreach (int number in numbers)
//            {
//                if (number > max)
//                {
//                    max = number;
//                }
//            }
//            return max;
//        };

//        int[] arrayToFindMax = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3567 };
//        int result = max(arrayToFindMax);
//        Console.WriteLine($"Мaксимальное число из массива: {result}");

//    }
//}

//2.Отфильтровать даты.
//Создайте список  дат  и  отфильтруйте  его  с  использованием 
//лямбда-выражения.  Отфильтруйте  даты  так, чтобы  получить  только  те,
//которые находятся в будущем. 
//var listOfDates =  new List<DateTime>()
//{ new DateTime(2025, 9, 22),
// new DateTime(2023, 8, 11),
// new DateTime(2027, 2, 22),
// new DateTime(2010, 12, 2)
//};
//var now =  DateTime.Now;
//var result = listOfDates.Where(x => x > now).ToList();
//foreach (var date in result)
//{
//    Console.WriteLine(date.ToString("yyyy-mm-dd"));
//}

////3.Отфильтровать слова по длине. 
////Создайте  массив  строк  и  отфильтруйте  его  с  использованием 
////лямбда-выражения.  Отфильтруйте  строки  так, чтобы  получить  только  те,
////которые содержат не менее 5 символов.
//var arrayOfDrivers = new string[]
//{
//    "Russell",
//    "Verstappen",
//    "Hamilton",
//    "Ocon",
//    "Alonso",
//    "Kimi",
//};
//var result2 = arrayOfDrivers.Where(x => x.Length >= 5);
//foreach (var driver in result2)
//{ 
//    Console.WriteLine(driver);
//}

////5.Отфильтровать товары по цене. 
////Создайте  список  товаров, где  каждый  товар  содержит  название  и  цену. 
////Отфильтруйте  список  с  использованием  лямбда-выражения, чтобы 
////получить только те товары, цена которых не превышает 1000 рублей.
//var cucumber = new { Name = "Cucumber", Price = 30 };
//var listOfProducts = new List<(string name, int price)>()
//{
//    ("Cucumber", 300),
//    ("Carrot", 1500),
//    ("Lemon", 150 ),
//    ("Apple", 999 ),
//    ("Banana", 1100 ),
//    ("Tomato", 800 )
//};
//var result3 = listOfProducts.Where(x => x.price < 1000 );
//foreach (var product in result3)
//{ 
//    Console.WriteLine(product); 
//}

////4.Отфильтровать объекты по условию. 
////Создайте  список  объектов, где  каждый  объект  содержит  имя  и  возраст. 
////Отфильтруйте  список  с  использованием  лямбда-выражения, чтобы 
////получить только те объекты, у которых возраст больше 30.
//public class Person
//{
//    public string Name;
//    public int Age;
//}


////2.Фильтрация данных с выбором критерия. 
////Создайте массив делегатов, представляющих различные критерии 
////фильтрации данных (например, фильтр по цене, фильтр по дате и т. д.). 
////Запросите у пользователя данные и критерий фильтрации. Затем 
////используйте массив делегатов, чтобы применить выбранный критерий 
////фильтрации к введенным данным.
//class Program
//{
//    // Определяем класс для товара
//    public class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//        public DateTime DateAdded { get; set; }

//        public Product(string name, decimal price, DateTime dateAdded)
//        {
//            Name = name;
//            Price = price;
//            DateAdded = dateAdded;
//        }
//    }

//    // Делегат для фильтрации продуктов
//    public delegate bool FilterCriteria(Product product);

//    static void Main(string[] args)
//    {
//        // Создаем список товаров
//        List<Product> products = new List<Product>
//        {
//            new Product("Товар 1", 500, new DateTime(2023, 1, 15)),
//            new Product("Товар 2", 1500, new DateTime(2023, 2, 20)),
//            new Product("Товар 3", 750, new DateTime(2023, 3, 10)),
//            new Product("Товар 4", 2000, new DateTime(2023, 4, 5)),
//            new Product("Товар 5", 300, new DateTime(2023, 5, 1))
//        };

//        // Массив делегатов для фильтрации
//        FilterCriteria[] filters = new FilterCriteria[]
//        {
//            FilterByPrice,
//            FilterByDate
//        };

//        // Запрашиваем у пользователя критерий фильтрации
//        Console.WriteLine("Выберите критерий фильтрации:");
//        Console.WriteLine("1 - Фильтр по цене");
//        Console.WriteLine("2 - Фильтр по дате добавления");
//        int choice = int.Parse(Console.ReadLine());

//        // Выполняем фильтрацию на основе выбора пользователя
//        List<Product> filteredProducts = new List<Product>();

//        if (choice == 1)
//        {
//            Console.Write("Введите максимальную цену: ");
//            decimal maxPrice = decimal.Parse(Console.ReadLine());
//            filteredProducts = products.Where(p => filters[0](p)).ToList();
//        }
//        else if (choice == 2)
//        {
//            Console.Write("Введите дату (в формате ГГГГ-ММ-ДД): ");
//            DateTime date = DateTime.Parse(Console.ReadLine());
//            filteredProducts = products.Where(p => filters[1](p)).ToList();
//        }
//        else
//        {
//            Console.WriteLine("Неверный выбор.");
//            return;
//        }

//        // Выводим отфильтрованные товары
//        Console.WriteLine("Отфильтрованные товары:");
//        foreach (var product in filteredProducts)
//        {
//            Console.WriteLine($"Название: {product.Name}, Цена: {product.Price} рублей, " +
//                $"Дата добавления: {product.DateAdded.ToShortDateString()}");
//        }
//    }

//    // Метод для фильтрации по цене
//    static bool FilterByPrice(Product product)
//    {
//        decimal maxPrice = 1000; // Задаем максимальную цену для фильтрации
//        return product.Price <= maxPrice;
//    }

//    // Метод для фильтрации по дате добавления
//    static bool FilterByDate(Product product)
//    {
//        DateTime filterDate = new DateTime(2023, 3, 1); // Задаем дату для фильтрации
//        return product.DateAdded >= filterDate;
//    }
//}



public delegate string IsDataExists(string data);

public interface IUser
{
    int Id { get; set; }
    string Name { get; set; }
    string Login { get; set; }
    string Password { get; set; }
}

public class User : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public static List<string> existingLogins = new List<string>();
    public static List<string> existingNames = new List<string>();
    public static List<string> existingPasswords = new List<string>();
    public static List<int> existingId = new List<int>();
    public static List<User> existingUsers = new List<User>();
    public static int Usercount = existingLogins.Count;

    public delegate string IsDataExists(string data);
    public User(string name, string login, string password)
    {
        string path2 = "Z:\\Gaziev\\userData.txt";
        string[] lines = File.ReadAllLines(path2);
        //if (lines.Contains(login))
        //{
        //    throw new Exception("Пользователь с таким логином уже существует.");
        //}
        if (existingLogins.Contains(login))
        {
            throw new Exception("Пользователь с таким логином уже существует.");
        }
        else
        {
            Name = new IsDataExists((name) => { if (name == null) { throw new Exception("Передано пустое имя"); } return name; })(name);
            Id = Usercount;
            Password = new IsDataExists((data) => { if (data == null) { throw new Exception("Передано пустое имя"); } return data; })(password);
            Login = new IsDataExists((data) => { if (data == null) { throw new Exception("Передано пустое имя"); } return data; })(login);
            existingLogins.Add(login);
            existingNames.Add(name);
            existingPasswords.Add(password);   
            existingId.Add(Id);
            SaveData(path2);
        }
    }

    public void SaveData(string path)
    {
        File.AppendAllText(path, $"{Id+1}. {Name} - {Login} - {Password}" + Environment.NewLine);
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите опцию: " +
                "1.Добавить пользователя" +
                "2.Просмотреть всех пользователей" +
                "3.Найти пользователя по логину " +
                "4.Удалить пользователя" +
                "0.Выйти из программы");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    string path = "Z:\\Gaziev\\userData.txt";
                    string[] lines = File.ReadAllLines(path);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите логин пользователя, которогo хотите найти: ");
                    string input = Console.ReadLine();
                    if (existingLogins.Contains(input))
                    {
                        int index = existingLogins.IndexOf(input);
                        Console.WriteLine($"Имя: {existingNames[index]}, логин: {input}, Id: {existingId[index]}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите логин пользователя, которогo хотите удалить: ");
                    string loginForRemove = Console.ReadLine();
                    if (existingLogins.Contains(loginForRemove))
                    {
                        int indexForRemove = existingPasswords.IndexOf(loginForRemove);
                        Console.WriteLine("Введите пароль для удаления: ");
                        string inputPassword = Console.ReadLine();
                        if (existingPasswords[indexForRemove] == inputPassword)
                        {
                            existingLogins.RemoveAt(indexForRemove);
                            existingPasswords.RemoveAt(indexForRemove);
                            existingNames.RemoveAt(indexForRemove);
                            existingId.RemoveAt(indexForRemove);
                            Console.WriteLine($"Пользователь {loginForRemove} успешно удален");
                        }
                        else
                        {
                            Console.WriteLine("Неверный пароль");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Пользователя с таким логином не существует");
                    }
                    break;
                case 0:
                    Console.WriteLine("Выход из программы");
                    return;
            }

        }
        void AddUser()
        {
            Console.WriteLine("Введите имя пользователя(: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Введите логин пользователя: ");
            string userLogin = Console.ReadLine();
            Console.WriteLine($"Введите пароль пользователя: ");
            string userPassword = Console.ReadLine();

            User user1 = new User(userName, userLogin, userPassword);
            existingUsers.Add(user1);
        }
    }
}









//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Text.Json;


//public class AreaName
//{
//    public string value { get; set; }
//}

//public class Astronomy
//{
//    public string moon_illumination { get; set; }
//    public string moon_phase { get; set; }
//    public string moonrise { get; set; }
//    public string moonset { get; set; }
//    public string sunrise { get; set; }
//    public string sunset { get; set; }
//}

//public class Country
//{
//    public string value { get; set; }
//}

//public class CurrentCondition
//{
//    public string FeelsLikeC { get; set; }
//    public string FeelsLikeF { get; set; }
//    public string cloudcover { get; set; }
//    public string humidity { get; set; }
//    public string localObsDateTime { get; set; }
//    public string observation_time { get; set; }
//    public string precipInches { get; set; }
//    public string precipMM { get; set; }
//    public string pressure { get; set; }
//    public string pressureInches { get; set; }
//    public string temp_C { get; set; }
//    public string temp_F { get; set; }
//    public string uvIndex { get; set; }
//    public string visibility { get; set; }
//    public string visibilityMiles { get; set; }
//    public string weatherCode { get; set; }
//    public List<WeatherDesc> weatherDesc { get; set; }
//    public List<WeatherIconUrl> weatherIconUrl { get; set; }
//    public string winddir16Point { get; set; }
//    public string winddirDegree { get; set; }
//    public string windspeedKmph { get; set; }
//    public string windspeedMiles { get; set; }
//}

//public class Hourly
//{
//    public string DewPointC { get; set; }
//    public string DewPointF { get; set; }
//    public string FeelsLikeC { get; set; }
//    public string FeelsLikeF { get; set; }
//    public string HeatIndexC { get; set; }
//    public string HeatIndexF { get; set; }
//    public string WindChillC { get; set; }
//    public string WindChillF { get; set; }
//    public string WindGustKmph { get; set; }
//    public string WindGustMiles { get; set; }
//    public string chanceoffog { get; set; }
//    public string chanceoffrost { get; set; }
//    public string chanceofhightemp { get; set; }
//    public string chanceofovercast { get; set; }
//    public string chanceofrain { get; set; }
//    public string chanceofremdry { get; set; }
//    public string chanceofsnow { get; set; }
//    public string chanceofsunshine { get; set; }
//    public string chanceofthunder { get; set; }
//    public string chanceofwindy { get; set; }
//    public string cloudcover { get; set; }
//    public string diffRad { get; set; }
//    public string humidity { get; set; }
//    public string precipInches { get; set; }
//    public string precipMM { get; set; }
//    public string pressure { get; set; }
//    public string pressureInches { get; set; }
//    public string shortRad { get; set; }
//    public string tempC { get; set; }
//    public string tempF { get; set; }
//    public string time { get; set; }
//    public string uvIndex { get; set; }
//    public string visibility { get; set; }
//    public string visibilityMiles { get; set; }
//    public string weatherCode { get; set; }
//    public List<WeatherDesc> weatherDesc { get; set; }
//    public List<WeatherIconUrl> weatherIconUrl { get; set; }
//    public string winddir16Point { get; set; }
//    public string winddirDegree { get; set; }
//    public string windspeedKmph { get; set; }
//    public string windspeedMiles { get; set; }
//}

//public class NearestArea
//{
//    public List<AreaName> areaName { get; set; }
//    public List<Country> country { get; set; }
//    public string latitude { get; set; }
//    public string longitude { get; set; }
//    public string population { get; set; }
//    public List<Region> region { get; set; }
//    public List<WeatherUrl> weatherUrl { get; set; }
//}

//public class Region
//{
//    public string value { get; set; }
//}

//public class Request
//{
//    public string query { get; set; }
//    public string type { get; set; }
//}

//public class Root
//{
//    public List<CurrentCondition> current_condition { get; set; }
//    public List<NearestArea> nearest_area { get; set; }
//    public List<Request> request { get; set; }
//    public List<Weather> weather { get; set; }
//}

//public class Weather
//{
//    public List<Astronomy> astronomy { get; set; }
//    public string avgtempC { get; set; }
//    public string avgtempF { get; set; }
//    public string date { get; set; }
//    public List<Hourly> hourly { get; set; }
//    public string maxtempC { get; set; }
//    public string maxtempF { get; set; }
//    public string mintempC { get; set; }
//    public string mintempF { get; set; }
//    public string sunHour { get; set; }
//    public string totalSnow_cm { get; set; }
//    public string uvIndex { get; set; }
//}

//public class WeatherDesc
//{
//    public string value { get; set; }
//}

//public class WeatherIconUrl
//{
//    public string value { get; set; }
//}

//public class WeatherUrl
//{
//    public string value { get; set; }
//}


//partial class Program
//{
//    static async Task Main()
//    {
//        using var client = new HttpClient();
//        string url = "https://wttr.in/Nizhny+Novgorod?format=j2";
//        string response = await client.GetStringAsync(url);
//        Astronomy astronomy = JsonSerializer.Deserialize<Astronomy>(response);
//        Root root = JsonSerializer.Deserialize<Root>(response);
//        Region region = JsonSerializer.Deserialize<Region>(response);
//        //Console.WriteLine($"Region: {region.value}");
//        Console.WriteLine($"Weather: {root.weather[2]}");
//        Console.WriteLine($"MaxtempF: {root.weather[1].maxtempF}"); 
//        Console.WriteLine($"MaxtempC: {root.weather[1].maxtempC}"); 
//        Console.WriteLine($"MaxtempF: {root.weather[2].maxtempF}");
//        Console.WriteLine($"MaxtempC: {root.weather[2].maxtempC}");
//        Console.WriteLine($"moonset: {root.weather[0].astronomy[0].sunset}");
//        Console.WriteLine($"sunrise: {root.weather[0].astronomy[0].sunrise}");
//        try
//        {
//            //string response = await client.GetStringAsync(url);
//            //Console.WriteLine(response);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка запроса: {ex.Message}");
//        }
//    }
//}




/*
public delegate void MyDelegate();
static class MyClass
{
    public static event MyDelegate? OnRun;
    public static void Subscribe(MyDelegate subscriber)
    {
        OnRun += subscriber;
    }
    public static void Unsubscribe(MyDelegate subscriber)
    {
        OnRun -= subscriber;
    }
    public static void DoEvent()
    {
        OnRun?.Invoke();
    }

}
partial class Program
{
    public static void Main(string[] args)
    {
        //MyClass.Subscribe(RunCheck);
        MyDelegate? anonMethod = null;
        anonMethod = () =>
        {
            Console.WriteLine("Анонимный метод (лямбда)");
            MyClass.OnRun -= anonMethod;
        };
        
        MyClass.OnRun += anonMethod;
        //MyClass.OnRun?.Invoke();
        MyClass.DoEvent();
        MyClass.DoEvent();
    }
    public static void RunCheck()
    {
        Console.WriteLine("Программа работает!");
    }
}
*/

//using System.Runtime.CompilerServices;

//class TSensor
//{
//    private float _currentT = 0f;
//    public event Action<float>? OnTChange;
//    //public MyDelegate? del;
//    public void ChangeT(float newT)
//    {
//        _currentT = newT;
//        OnTChange?.Invoke(newT);
//    }
//}

//class TDisplay
//{
//    public void DisplayT(float t) {
//        Console.WriteLine($"Температура: {t}");
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        TSensor sensor = new TSensor();
//        TDisplay display = new TDisplay();
//        //sensor.OnTChange += display.DisplayT;
//        Action<float>? checkDisplayMethod = null;
//        checkDisplayMethod = (float t) =>
//        {
//            if (t < 50f && t > -40f)
//                Console.WriteLine("Датчик заработал!");
//            else
//                Console.WriteLine("Датчик неисправен!");
//            sensor.OnTChange -= checkDisplayMethod;
//        };
//        sensor.OnTChange += checkDisplayMethod;
//        sensor.OnTChange -= display.DisplayT;
//        sensor.ChangeT(26.5f);
//        sensor.ChangeT(23.2f);
//    }
//}

//using System.Text.Json;
//using System;
//using System.Text.Encodings.Web;

//class Person
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Age { get; set; }
//    public DateTime Birthday { get; set; }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Person person = new Person()
//        {
//            Name = "Jack",
//            Surname = "Jones",
//            Age = 38,
//            Birthday = new DateTime(1983, 01, 16)
//        };
//        //Console.WriteLine(10 is int.GetType());
//        var students = new Dictionary<string, int[]>
//        {
//            ["Сергей"] = new int[] { 5, 2, 4, 3 },
//            ["Натали"] = new int[] { 5, 2, 4, 3 },
//            ["Тимур"] = new int[] { 5, 2, 4, 3 },
//            ["Иван"] = new int[] { 5, 2, 4, 3 }
//        };
//        var options = new JsonSerializerOptions
//        {
//            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
//            WriteIndented = true // Для читаемости, необязательно
//        };
//        string personJson = JsonSerializer.Serialize(person,
//        typeof(Person));
//        StreamWriter file = File.CreateText("person.json");
//        file.WriteLine(personJson);
//        file.Close();
//        string json = File.ReadAllText("person.json");
//        Person? persona = JsonSerializer.Deserialize<Person>(json);
//        Console.WriteLine(
//        $"  Name: {persona.Name}  \n  " +
//        $"Surname: {persona.Surname}  \n  " +
//        $"Age: {persona.Age}  \n  " +
//        $"BirthDay: {persona.Birthday}  \n  ");
//    }

//}
