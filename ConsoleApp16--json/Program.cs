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

//Объектно ориентированное 
//программирование на C# 
//Тема 25. Урок 3. Практическая работа. 
//Задание: Расширение приложения для ролей пользователей 
//Цель: Добавить функциональность для автора и читателя, разработав 
//соответствующие окна и функции для каждой роли. 
//Задачи. 
//Автор. 
//Создайте окно автора, которое позволит ему создавать и редактировать 
//статьи. 
//Автор должен иметь доступ только к своим собственным статьям. 
//Разрешите автору: 
//Создавать новые статьи с указанием темы, заголовка, возрастного 
//ограничения и текста статьи. 
//Редактировать свои собственные статьи, включая изменение их 
//содержания и свойств. 
//Читатель. 
//Создайте окно для читателя, которое позволит ему просматривать статьи. 
//Читатель должен иметь доступ только для чтения статей. 
//Разрешите читателю: 
//Просматривать список доступных статей. 
//Читать статьи, открывая их для просмотра. 
//Ограничения доступа. 
//Убедитесь, что доступ к функциям приложения ограничен в соответствии с 
//ролью пользователя. 
//Например, администратор должен иметь доступ ко всем функциям, в то 
//время как автор и читатель имеют доступ только к соответствующим 
//функциям. 
//Логаут и безопасность 
//Реализуйте функциональность выхода из системы (логаут) для всех ролей. 
//Убедитесь, что данные пользователя хранятся безопасно и пароли 
//хэшируются. 
//Это задание позволит вам полностью реализовать многопользовательский 
//функционал в приложении, включая аутентификацию, авторизацию и 
//управление пользователями и данными. 
//Обеспечьте безопасность данных и функций, чтобы предотвратить 
//несанкционированный доступ и изменение данных.



//Объектно ориентированное 
//программирование на C# 
//Тема 25. Урок 4. Практическая работа. 
//Задание: Реализация роли администратора. 
//Чтобы реализовать роль администратора в вашем приложении, выполните 
//следующие шаги: 
//Создайте класс Admin. 
//Создайте класс Admin, который будет представлять администратора 
//приложения. 
//Этот класс может содержать информацию о текущем администраторе, но,
//главным образом, он будет использоваться для выполнения действий 
//администратора. 
//Реализуйте аутентификацию администратора. 
//Реализуйте процесс аутентификации администратора при запуске 
//приложения. 
//Это может включать в себя проверку учетных данных администратора 
//(например, логин и пароль). 
//При успешной аутентификации создайте экземпляр класса Admin, чтобы 
//отличить администратора от других пользователей. 
//Создайте окно администратора. 
//Разработайте графический интерфейс для администратора, который 
//позволит выполнить различные задачи управления приложением. 
//Управление пользователями. 
//Позвольте администратору просматривать список всех пользователей,
//включая их данные (например, имя, фамилия, роль). 
//Разрешите администратору добавлять новых пользователей,
//редактировать существующих и удалять пользователей при 
//необходимости. 
//Добавьте функциональность изменения ролей пользователей. 
//Управление статьями. 
//Разрешите администратору просматривать список всех статей, включая их 
//данные (например, заголовок, автор, содержание). 
//Позвольте администратору добавлять новые статьи, редактировать и 
//удалять существующие статьи при необходимости. 
//Ограничения доступа. 
//Убедитесь, что доступ администратора ограничен паролем или другими 
//средствами аутентификации, чтобы предотвратить несанкционированный 
//доступ. 
//Логаут и безопасность. 
//Реализуйте функциональность выхода администратора из системы 
//(логаут). 
//Убедитесь, что данные администратора хранятся безопасно, и пароль 
//хэшируется. 
//Управление ролями. 
//Позвольте администратору назначать и снимать роли у других 
//пользователей в зависимости от их обязанностей и функций. 
//Тщательно протестируйте функциональность администратора, чтобы 
//убедиться, что все задачи управления пользователями и данными 
//работают корректно. 
//Реализация роли администратора позволит вам эффективно управлять 
//всеми аспектами вашего приложения и обеспечивать его безопасность и 
//целостность данных.