using System;
using System.Text.Json;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }
}

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }
}

public static void Main(string[] args)
{
    Library library = new Library();

    library.AddBook(new Book("1984", "George Orwell", "Dystopian", 1949));
    library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960));
    library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925));

}

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void SerializeToFile(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(Books, options);
        File.WriteAllText(filePath, json);
    }

    public void DeserializeFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            Books = JsonSerializer.Deserialize<List<Book>>(json);
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}

public static void Main(string[] args)
{
    Library library = new Library();

    library.AddBook(new Book("1984", "George Orwell", "Dystopian", 1949));
    library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960));
    library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925));

    string filePath = "library.json";
    library.SerializeToFile(filePath);

    Library newLibrary = new Library();
    newLibrary.DeserializeFromFile(filePath);

    foreach (var book in newLibrary.Books)
    {
        Console.WriteLine($"{book.Title} by {book.Author}, Genre: {book.Genre}, Year: {book.Year}");
    }
}
