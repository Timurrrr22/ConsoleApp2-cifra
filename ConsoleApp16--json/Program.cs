//1,2,3
using System.Text.Encodings.Web;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

JsonSerializerOptions options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    NumberHandling = JsonNumberHandling.AllowReadingFromString,
    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};

Person person = new Person(
            "Иван",
            "Иванов",
            30,
            "г. Москва, ул. Ленина, д. 1",
            "ivan.ivanov@example.com",
            new DateTime(1993, 5, 15)
        );

//string jsonString = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
//Console.WriteLine("Сериализованный JSON:");
//Console.WriteLine(jsonString);

string filePath = "Z:\\Gaziev\\gvgv.json";
//File.WriteAllText(filePath, jsonString);
//Console.WriteLine($"\nJSON-строка сохранена в файл: {filePath}");

List<Product> products = new List<Product>()
{
    new Product("Tomato", 55, "Вкусные, сладкие, сочные красные помидорки для салатов"),
    new Product("Apple", 55, "Зелёные, кислые"),
    new Product("Milk", 55, "Прокисшее со скидкой 50%")
};
//string jsonStr = JsonSerializer.Serialize(products, options);
//File.WriteAllText(filePath, jsonStr);

string json = File.ReadAllText("Z:\\Gaziev\\gvgv.json");
Product[] prr = JsonSerializer.Deserialize<Product[]>(json, options);
foreach (var product in prr)
{
    Console.WriteLine(
    $"Name: {product.Name}\n" +
    $"Price: {product.Price}\n" +
    $"Description: {product.Description}\n"
    );
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, int age, string address, string email, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
        Email = email;
        DateOfBirth = dateOfBirth;
    }
}
public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    public Product(string name, int price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
    }
}


public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime BirthDate { get; set; }

    public User(int id, string username, string firstName, string secondName, string email, string password, DateTime birthDate)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        SecondName = secondName;
        Email = email;
        Password = password;
        RegistrationDate = DateTime.Now;
        BirthDate = birthDate;
    }
}

public class UserRegistration
{
    private List<User> users;

    public UserRegistration()
    {
        users = new List<User>();
    }

    public bool RegisterUser(User newUser)
    {
        // Проверка на уникальность имени пользователя и адреса электронной почты
        foreach (var user in users)
        {
            if (user.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase) ||
                user.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }

        users.Add(newUser);
        return true;
    }

    public void SerializeUsersToJson(string fileName)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(users, options);
        File.WriteAllText(fileName, json);
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public void LoadUsersFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }
}

partial class Program
{
    static void Main(string[] args)
    {
        UserRegistration userRegistration = new UserRegistration();

        string filePath = "users.json";
        userRegistration.LoadUsersFromFile(filePath);

        while (true)
        {
            Console.WriteLine("1. Зарегистрироваться");
            Console.WriteLine("2. Просмотреть зарегистрированных пользователей");
            Console.WriteLine("3. Вход в систему");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterUser(userRegistration);
                    break;
                case "2":
                    ViewRegisteredUsers(userRegistration);
                    break;
                case "3":
                    Login(userRegistration);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void RegisterUser(UserRegistration userRegistration)
    {
        Console.Write("Введите ник пользователя: ");
        string username = Console.ReadLine();

        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string secondName = Console.ReadLine();

        Console.Write("Введите адрес электронной почты: ");
        string email = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        Console.Write("Введите дату рождения (yyyy-mm-dd): ");
        DateTime birthDate;
        while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            Console.Write("Неверный формат даты. Попробуйте снова: ");
        }

        int newId = userRegistration.GetUsers().Count > 0 ? userRegistration.GetUsers()[userRegistration.GetUsers().Count - 1].Id + 1 : 1;

        User newUser = new User(newId, username, firstName, secondName, email, password, birthDate);

        if (userRegistration.RegisterUser(newUser))
        {
            userRegistration.SerializeUsersToJson("users.json");
            Console.WriteLine("Пользователь успешно зарегистрирован.");
        }
        else
        {
            Console.WriteLine("Ошибка: ник пользователя или адрес электронной почты уже заняты.");
        }
    }

    static void ViewRegisteredUsers(UserRegistration userRegistration)
    {
        var users = userRegistration.GetUsers();

        if (users.Count == 0)
        {
            Console.WriteLine("Нет зарегистрированных пользователей.");
            return;
        }

        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Username: {user.Username}, Name: {user.FirstName} {user.SecondName}, Email: {user.Email}, Registration Date: {user.RegistrationDate}, Birth Date: {user.BirthDate}");
        }
    }

    static void Login(UserRegistration userRegistration)
    {
        Console.Write("Введите ник пользователя: ");
        string username = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        foreach (var user in userRegistration.GetUsers())
        {
            if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password)
            {
                Console.WriteLine("Вход выполнен успешно.");
                return;
            }
        }

        Console.WriteLine("Ошибка: неверное имя пользователя или пароль.");
    }
}

