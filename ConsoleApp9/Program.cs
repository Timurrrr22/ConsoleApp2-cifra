//1
void Number1()
{
    Console.WriteLine("Введите строку:");
    string inputString = Console.ReadLine();

    Console.WriteLine("Введите слово для проверки:");
    string wordToCheck = Console.ReadLine();

    bool containsWord = inputString.Contains(wordToCheck);

    if (containsWord)
    {
        Console.WriteLine("Результат: Строка содержит указанное слово.");
    }
    else
    {
        Console.WriteLine("Результат: Строка не содержит указанное слово.");
    }
}

Number1();

//2
Console.WriteLine("Введите строку:");
string inputString1 = Console.ReadLine();

// Запрос символа для замены
Console.WriteLine("Введите символ для замены:");
char charToReplace = Console.ReadKey().KeyChar;
Console.WriteLine();

// Запрос символа, на который нужно заменить
Console.WriteLine("Введите символ, на который нужно заменить:");
char replacementChar = Console.ReadKey().KeyChar;
Console.WriteLine();

string updatedString = inputString1.Replace(charToReplace, replacementChar);

Console.WriteLine("Обновленная строка: " + updatedString);

//3
Console.WriteLine("Введите строку:");
string inputString3 = Console.ReadLine();

Console.WriteLine("Введите слово для подсчета:");
string wordToCount = Console.ReadLine();

int count = 0;
string tempString = inputString3; // Копия строки для модификации

// Цикл, пока строка содержит слово (регистронезависимо)
while (tempString.Contains(wordToCount, StringComparison.OrdinalIgnoreCase))
{
    count++;
    int index = tempString.IndexOf(wordToCount, StringComparison.OrdinalIgnoreCase); // Находим индекс
    tempString = tempString.Remove(index, wordToCount.Length); // "Удаляем" найденное слово 

}
Console.WriteLine("Количество вхождений: " + count);

//1
// Запрос полного имени у пользователя
Console.WriteLine("Введите полное имя (Имя Фамилия):");
string fullName = Console.ReadLine();

// Разделение имени с помощью Split
string[] nameParts = fullName.Split(' ');

if (nameParts.Length == 2)
{
    string firstName = nameParts[0];
    string lastName = nameParts[1];

    Console.WriteLine("Имя: " + firstName);
    Console.WriteLine("Фамилия: " + lastName);
}
else
{
    Console.WriteLine("Ошибка: Введите имя и фамилию через пробел.");
}

//2
Console.WriteLine("Введите список элементов, разделенных запятой:");
string inputList = Console.ReadLine();
string[] elements = inputList.Split(',');
Console.WriteLine("Элементы списка:");
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine(elements[i].Trim()); // Trim() удаляет пробелы
}            

