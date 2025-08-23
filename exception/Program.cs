//1
Console.WriteLine("Введите делиоме");
string a = Console.ReadLine();
int dividend = 0;
var isNumber = int.TryParse(a, out dividend);
if (isNumber)
{
    Console.WriteLine("Успешно");
}
else
{
    Console.WriteLine("Возникла ошибка!");
}
Console.WriteLine("Введите делитель: ");
string b = Console.ReadLine();
int divisor = 0;
var isNumber2 = int.TryParse(a, out dividend);
if (isNumber2)
{
    Console.WriteLine("Успешно");
}
else
{
    Console.WriteLine("Возникла ошибка!");
}

try
{
    double result = dividend / divisor;
    Console.WriteLine($"Результат деления: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ошибка: Деление на ноль!");
}
catch (Exception ex) // Обработка других возможных исключений
{
    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена."); 
}


//2
Console.WriteLine("Введите путь к файлу:");
string filePath = Console.ReadLine();

try
{
    ReadFileAndPrint(filePath);
}
catch (FileNotFoundException)
{
    Console.WriteLine($"Ошибка: Файл по пути '{filePath}' не найден.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена.");
}


// Метод для чтения файла и вывода его содержимого
static void ReadFileAndPrint(string filePath)
{
    string[] lines = File.ReadAllLines(filePath);
    for (int i = 0; i < lines.Length; i++)
    {
        Console.WriteLine(lines[i]);
    }
}


//3
Console.WriteLine("Введите число:");
string numberInput = Console.ReadLine();
double number = 0;
while (true)
{
    numberInput = Console.ReadLine();
    if (double.TryParse(numberInput, out number)) break;
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
}

try
{
    if (number < 0)
    {
        throw new ArgumentException("Нельзя вычислить квадратный корень из отрицательного числа.");
    }
    double squareRoot = Math.Sqrt(number);
    Console.WriteLine($"Квадратный корень из {number}: {squareRoot}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла непредвиденная ошибка: {ex}");
}
finally
{
    Console.WriteLine("Программа завершена.");
}


//4
Console.WriteLine("Введите строку, которую нужно преобразовать в число:");
string inputString = Console.ReadLine();

try
{
    int number3 = int.Parse(inputString); 
    Console.WriteLine($"Преобразованное число: {number3}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена.");
}



//5
