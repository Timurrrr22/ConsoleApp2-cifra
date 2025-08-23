//1,2,3
using System.Text.Encodings.Web;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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
Product[] prr = JsonSerializer.Deserialize<Product[]>(json);
foreach(var product in prr)
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
 



