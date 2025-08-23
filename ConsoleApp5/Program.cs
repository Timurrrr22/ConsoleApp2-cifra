//задания нормального уровня 
// 1
//Console.WriteLine("Введите количество товаров: ");
//int numberOfItems = int.Parse(Console.ReadLine());

//string[] itemNames = new string[numberOfItems];
//int[] itemPrices = new int[numberOfItems];
//for (int i = 0; i < numberOfItems; i++)
//{
//    Console.WriteLine($"Введите название товара: {i + 1} ");
//    itemNames[i] = Console.ReadLine();

//    Console.WriteLine($"Введите стоимость товара: {i + 1}");
//    itemPrices[i] = int.Parse(Console.ReadLine());

//}
//int totalPrice = 0;
//string mostExpensiveItem = "";
//int mostExpensivePrice = 0;
//Console.WriteLine("\nСписок покупок:");
//for (int i = 0; i < numberOfItems; i++)
//{
//    Console.WriteLine($"{itemNames[i]} : {itemPrices[i]:C}");
//    totalPrice += itemPrices[i];
//    if (itemPrices[i] > mostExpensivePrice)
//    {
//        mostExpensivePrice = itemPrices[i];
//        mostExpensiveItem = itemNames[i];
//    }
//}
//Console.WriteLine($"\nОбщая сумма покупки: {totalPrice:C}");
//Console.WriteLine($"Самый дорогой товар: {mostExpensiveItem} - {mostExpensivePrice:C}");
//Console.ReadKey();

////2
//double[] temperatures = new double[7];
//// Ввод температур
//for (int i = 0; i < 7; i++)
//{
//    Console.WriteLine($"Введите температуру за день {i + 1}:");
//    while (!double.TryParse(Console.ReadLine(), out temperatures[i]))
//    {
//        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
//    }
//}
//// Анализ температур
//double highestTemperature = temperatures[0];
//double lowestTemperature = temperatures[0];
//double totalTemperature = 0;
//int daysAboveAverage = 0;
//for (int i = 0; i < 7; i++)
//{
//    if (temperatures[i] > highestTemperature)
//    {
//        highestTemperature = temperatures[i];
//    }
//    if (temperatures[i] < lowestTemperature)
//    {
//        lowestTemperature = temperatures[i];
//    }
//    totalTemperature += temperatures[i];
//}
//double averageTemperature = totalTemperature / 7;
//for (int i = 0; i < 7; i++)
//{
//    if (temperatures[i] > averageTemperature)
//    {
//        daysAboveAverage++;
//    }
//}
//// Вывод результатов
//Console.WriteLine("\nРезультаты анализа:");
//Console.WriteLine($"Самая высокая температура: {highestTemperature}°C");
//Console.WriteLine($"Самая низкая температура: {lowestTemperature}°C");
//Console.WriteLine($"Средняя температура: {averageTemperature:F2}°C"); 
//Console.WriteLine($"Количество дней с температурой выше средней: {daysAboveAverage}");
//Console.ReadKey();

////3
//// Ввод данных
//Console.WriteLine("Введите количество студентов:");
//int numStudents;
//while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
//{
//    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число больше 0:");
//}

//Console.WriteLine("Введите количество занятий:");
//int numClasses;
//while (!int.TryParse(Console.ReadLine(), out numClasses) || numClasses <= 0)
//{
//    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число больше 0:");
//}

//string[] studentNames = new string[numStudents];
//int[] absences = new int[numClasses];
//int allowedAbsences = (int)Math.Round(numClasses * 0.1); // 10% от общего количества занятий


//for (int i = 0; i < numStudents; i++)
//{
//    Console.WriteLine($"\nВведите имя студента {i + 1}:");
//    studentNames[i] = Console.ReadLine();

//    Console.WriteLine($"Введите количество пропусков для {studentNames[i]}:");
//    while (!int.TryParse(Console.ReadLine(), out absences[i]) || absences[i] < 0)
//    {
//        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое неотрицательное число:");
//    }
//}

//// Вывод отчета и определение студентов с превышением допустимого предела
//Console.WriteLine("\nОтчет о посещаемости:");
//Console.WriteLine($"Допустимое количество пропусков: {allowedAbsences}");
//Console.WriteLine("-------------------------");

//for (int i = 0; i < numStudents; i++)
//{
//    Console.WriteLine($"{studentNames[i]}: {absences[i]} пропусков");
//    if (absences[i] > allowedAbsences)
//    {
//        Console.WriteLine($" *Превышен допустимый предел пропусков!*");
//    }
//}
//Console.ReadKey();

//4
//public class InventoryManagement
//{
//    static string[] productNames = new string[0];
//    static int[] quantities = new int[0];
//    static double[] prices = new double[0];

//    public static void Main(string[] args)
//    {
//        int choice;
//        do
//        {
//            Console.WriteLine("\nМеню:");
//            Console.WriteLine("1. Добавить товар");
//            Console.WriteLine("2. Показать товары");
//            Console.WriteLine("3. Найти товар");
//            Console.WriteLine("4. Продать товар");
//            Console.WriteLine("5. Общая стоимость");
//            Console.WriteLine("0. Выход");
//            Console.Write("Выбор: ");

//            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5)
//            {
//                Console.WriteLine("Неверный ввод. Попробуйте ещё раз.");
//            }

//            switch (choice)
//            {
//                case 1: AddItem(); break;
//                case 2: ShowItems(); break;
//                case 3: FindItem(); break;
//                case 4: SellItem(); break;
//                case 5: TotalValue(); break;
//                case 0: Console.WriteLine("До свидания!"); break;
//            }
//        } while (choice != 0);

//        Console.ReadKey();
//    }

//    static void AddItem()
//    {
//        Array.Resize(ref productNames, productNames.Length + 1);
//        Array.Resize(ref quantities, quantities.Length + 1);
//        Array.Resize(ref prices, prices.Length + 1);

//        Console.Write("Название товара: ");
//        productNames[productNames.Length - 1] = Console.ReadLine();
//        Console.Write("Количество: ");
//        quantities[quantities.Length - 1] = int.Parse(Console.ReadLine());
//        Console.Write("Цена: ");
//        prices[prices.Length - 1] = double.Parse(Console.ReadLine());
//    }

//    static void ShowItems()
//    {
//        if (productNames.Length == 0)
//        {
//            Console.WriteLine("Товаров нет.");
//            return;
//        }
//        for (int i = 0; i < productNames.Length; i++)
//        {
//            Console.WriteLine($"{productNames[i]}: {quantities[i]} шт., {prices[i]:C}");
//        }
//    }

//    static void FindItem()
//    {
//        Console.Write("Название товара для поиска: ");
//        string name = Console.ReadLine();
//        int index = Array.IndexOf(productNames, name);
//        if (index != -1)
//        {
//            Console.WriteLine($"{productNames[index]}: {quantities[index]} шт., {prices[index]:C}");
//        }
//        else
//        {
//            Console.WriteLine("Товар не найден.");
//        }
//    }

//    static void SellItem()
//    {
//        Console.Write("Название товара: ");
//        string name = Console.ReadLine();
//        int index = Array.IndexOf(productNames, name);
//        if (index == -1)
//        {
//            Console.WriteLine("Товар не найден.");
//            return;
//        }
//        Console.Write("Количество: ");
//        int amount = int.Parse(Console.ReadLine());
//        if (amount > quantities[index])
//        {
//            Console.WriteLine("Недостаточно товара на складе.");
//            return;
//        }
//        quantities[index] -= amount;
//        Console.WriteLine($"Остаток {name}: {quantities[index]}");
//    }

//    static void TotalValue()
//    {
//        double total = 0;
//        for (int i = 0; i < productNames.Length; i++)
//        {
//            total += quantities[i] * prices[i];
//        }
//        Console.WriteLine($"Общая стоимость: {total:C}");
//    }
//}

//5
// Ввод данных о количестве дней и товаров
//Console.Write("Введите количество дней в месяце: ");
//int daysInMonth = int.Parse(Console.ReadLine());
//Console.Write("Введите количество товаров: ");
//int numberOfProducts = int.Parse(Console.ReadLine());

//// Создание массивов для хранения данных
//string[] productNames = new string[numberOfProducts];
//int[] totalSales = new int[numberOfProducts];
//int[,] dailySales = new int[daysInMonth, numberOfProducts];

//// Ввод данных о продажах
//for (int i = 0; i < numberOfProducts; i++)
//{
//    Console.Write($"Введите название товара {i + 1}: ");
//    productNames[i] = Console.ReadLine();
//    for (int j = 0; j < daysInMonth; j++)
//    {
//        Console.Write($"Введите количество проданных {productNames[i]} в день {j + 1}: ");
//        dailySales[j, i] = int.Parse(Console.ReadLine());
//        totalSales[i] += dailySales[j, i];
//    }
//    Console.WriteLine();
//}

//// Поиск самого продаваемого товара и дня с наибольшими продажами
//int bestSellingProductIndex = 0;
//int maxSales = totalSales[0];
//for (int i = 1; i < numberOfProducts; i++)
//{
//    if (totalSales[i] > maxSales)
//    {
//        maxSales = totalSales[i];
//        bestSellingProductIndex = i;
//    }
//}

//int bestSellingDay = 0;
//int maxDailySales = 0;
//for (int i = 0; i < daysInMonth; i++)
//{
//    int dailyTotal = 0;
//    for (int j = 0; j < numberOfProducts; j++)
//    {
//        dailyTotal += dailySales[i, j];
//    }
//    if (dailyTotal > maxDailySales)
//    {
//        maxDailySales = dailyTotal;
//        bestSellingDay = i;
//    }
//}


//// Вывод отчета
//Console.WriteLine("\nОтчет о продажах:");
//for (int i = 0; i < numberOfProducts; i++)
//{
//    double averageDailySales = (double)totalSales[i] / daysInMonth;
//    Console.WriteLine($"- {productNames[i]}: Общие продажи - {totalSales[i]}, Средние дневные продажи - {averageDailySales:F1}");
//}
//Console.WriteLine($"\nСамый продаваемый товар: {productNames[bestSellingProductIndex]} ({maxSales} единиц)");
//Console.WriteLine($"День с наибольшими продажами: {bestSellingDay + 1} ({maxDailySales} единиц)");

////7
//// Максимальное количество предметов на день (можно изменить)
//const int MaxSubjectsPerDay = 5;

//// Массивы для хранения данных
//string[] subjectNames = new string[MaxSubjectsPerDay * 7]; // 7 дней * MaxSubjectsPerDay
//string[] subjectTimes = new string[MaxSubjectsPerDay * 7]; // 7 дней * MaxSubjectsPerDay
//int[] subjectDay = new int[MaxSubjectsPerDay * 7]; // 7 дней * MaxSubjectsPerDay

//int subjectCount = 0;

//// Ввод данных о занятиях
//Console.WriteLine("Введите информацию о занятиях (название предмета, время, день недели (1-7, 1-Понедельник, 7-Воскресенье)):");
//for (int i = 0; i < MaxSubjectsPerDay * 7; i++)
//{
//    Console.WriteLine($"\nЗанятие {i + 1} (или введите пустое название для завершения):");
//    Console.Write("Название предмета: ");
//    string subjectName = Console.ReadLine();

//    if (string.IsNullOrEmpty(subjectName)) break;

//    Console.Write("Время: ");
//    string subjectTime = Console.ReadLine();
//    Console.Write("День недели (1-7): ");
//    int day;
//    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
//    {
//        Console.WriteLine("Неверный номер дня. Повторите ввод.");
//    }

//    subjectNames[subjectCount] = subjectName;
//    subjectTimes[subjectCount] = subjectTime;
//    subjectDay[subjectCount] = day;
//    subjectCount++;
//}

//// Вывод полного расписания
//Console.WriteLine("\nПолное расписание:");
//for (int day = 1; day <= 7; day++)
//{
//    Console.WriteLine($"\n{GetDayOfWeek(day)}:");
//    for (int i = 0; i < subjectCount; i++)
//    {
//        if (subjectDay[i] == day)
//        {
//            Console.WriteLine($"- {subjectNames[i]}: {subjectTimes[i]}");
//        }
//    }
//}

//// Поиск предмета по названию
//Console.Write("\nВведите название предмета для поиска: ");
//string searchSubject = Console.ReadLine();
//Console.WriteLine("\nРасписание для " + searchSubject + ":");
//bool found = false;
//for (int i = 0; i < subjectCount; i++)
//{
//    if (subjectNames[i].ToLower().Contains(searchSubject.ToLower()))
//    {
//        Console.WriteLine($"- {subjectNames[i]}: {subjectTimes[i]}, {GetDayOfWeek(subjectDay[i])}");
//        found = true;
//    }
//}
//if (!found) Console.WriteLine("Предмет не найден.");

//Console.ReadKey();


//static string GetDayOfWeek(int day)
//{
//    string[] days = { "", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
//    return days[day];
//}

////6
//const int max = 10;
//string[] category = new string[3];
//float[] sum = new float[5];
//int a = 0;
////Цикл для ввода данных
//for (int i = 0; i < max; i++)
//{
//    Console.WriteLine("Введите категорию развлечения(или пустую строку, если больше не тратили деньги на развлечения: ");
//    string categoryName= Console.ReadLine();
//    if (string.IsNullOrEmpty(categoryName)) break; 
//    category[a] = categoryName;
//    Console.WriteLine("Сколько вы потратили на это развлечение: ");
//    float spentMoney = float.Parse(Console.ReadLine());
//    sum[a] = spentMoney;
//    a++;
//}
////Вывод всех трат
//for(int i = 0; i < a; i++)
//{
//    Console.WriteLine($"{category[i]} : {sum[i]}");
//}
//Console.WriteLine(sum.Sum());


//8
//public class LibraryManager
//{
//    static string[] titles;
//    static int[] counts;
//    static int count = 0;

//    public static void Main(string[] args)
//    {
//        titles = new string[100];
//        counts = new int[100];

//        int choice;
//        do
//        {
//            Console.WriteLine("\nМеню:\n1. Список\n2. Добавить\n3. Удалить\n4. Найти\n0. Выход\nВыбор:");
//            int.TryParse(Console.ReadLine(), out choice);

//            switch (choice)
//            {
//                case 1: ViewBooks(); break;
//                case 2: AddBook(); break;
//                case 3: RemoveBook(); break;
//                case 4: FindBook(); break;
//                case 0: Console.WriteLine("До свидания!"); break;
//                default: Console.WriteLine("Неверный ввод."); break;
//            }
//        } while (choice != 0);
//    }

//    static void ViewBooks()
//    {
//        Console.WriteLine("\nСписок книг:");
//        if (count == 0)
//        {
//            Console.WriteLine("Библиотека пуста.");
//            return;
//        }
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {titles[i]} - {counts[i]} копий");
//        }
//    }

//    static void AddBook()
//    {
//        Console.Write("Название: "); string title = Console.ReadLine();
//        Console.Write("Кол-во: "); int.TryParse(Console.ReadLine(), out int c);

//        if (c > 0 && count < titles.Length) 
//        {
//            titles[count] = title;
//            counts[count++] = c;
//            Console.WriteLine("Книга добавлена.");
//        }
//        else Console.WriteLine("Ошибка добавления.");
//    }


//    static void RemoveBook()
//    {
//        Console.Write("Название для удаления: "); string title = Console.ReadLine();
//        int index = Array.IndexOf(titles, title, 0, count);
//        if (index != -1)
//        {
//            Console.Write("Кол-во для удаления: ");
//            if (int.TryParse(Console.ReadLine(), out int c) && c > 0 && c <= counts[index])
//            {
//                counts[index] -= c;
//                if (counts[index] == 0) Array.Clear(titles, index, 1);
//                Console.WriteLine("Кол-во уменьшено.");
//            }
//            else Console.WriteLine("Ошибка удаления.");
//        }
//        else Console.WriteLine("Книга не найдена.");
//    }


//    static void FindBook()
//    {
//        Console.Write("Название для поиска: "); string title = Console.ReadLine();
//        int index = Array.IndexOf(titles, title, 0, count);
//        Console.WriteLine(index != -1 ? $"Книга найдена: {titles[index]} - {counts[index]}" : "Книга не найдена.");
//    }
//}

//12
using System.Reflection.Metadata;

public class PhoneBook
{
    static string[] names;
    static string[] numbers;
    static int count = 0;
    static int capacity = 100; // начальный размер
    const int numberOfDigits = 10;

    public static void Main(string[] args)
    {
        names = new string[capacity];
        numbers = new string[capacity];

        int choice;
        do
        {
            Console.WriteLine("\nМеню телефонной книги:");
            Console.WriteLine("1. Добавить контакт");
            Console.WriteLine("2. Просмотреть контакты");
            Console.WriteLine("3. Найти контакт");
            Console.WriteLine("4. Обновить контакт");
            Console.WriteLine("5. Удалить контакт");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1: AddContact(); break;
                case 2: ViewContacts(); break;
                case 3: FindContact(); break;
                case 4: UpdateContact(); break;
                case 5: RemoveContact(); break;
                case 0: Console.WriteLine("До свидания!"); break;
                default: Console.WriteLine("Неверный ввод."); break;
            }
        } while (choice != 0);
    }

    static void AddContact()
    {
        if (count >= capacity)
        {
            Console.WriteLine("Телефонная книга заполнена.");
            return;
        }
        Console.Write("Имя: ");
        names[count] = Console.ReadLine();
        string number;
        Console.Write("Номер (ровно 10 цифр): ");
        number = Console.ReadLine();
        if (number.Length == numberOfDigits)
        {
            numbers[count] = number;
            count++;
            Console.WriteLine("Контакт добавлен.");
        }
        else { Console.WriteLine("Неверный номер"); }
    }


    static void ViewContacts()
    {
        Console.WriteLine("\nКонтакты:");
        if (count == 0)
        {
            Console.WriteLine("Телефонная книга пуста.");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{names[i]}: {numbers[i]}");
        }
    }

    static void FindContact()
    {
        Console.Write("Имя для поиска: ");
        string name = Console.ReadLine();
        int index = Array.IndexOf(names, name, 0, count);
        if (index != -1)
        {
            Console.WriteLine($"Номер {name}: {numbers[index]}");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

    static void UpdateContact()
    {
        Console.Write("Имя для обновления: ");
        string name = Console.ReadLine();
        int index = Array.IndexOf(names, name, 0, count);
        if (index != -1)
        {
            Console.Write("Новый номер: ");
            numbers[index] = Console.ReadLine();
            Console.WriteLine("Контакт обновлен.");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

    static void RemoveContact()
    {
        Console.Write("Имя для удаления: ");
        string name = Console.ReadLine();
        int index = Array.IndexOf(names, name, 0, count);
        if (index != -1)
        {
            Array.Copy(names, index + 1, names, index, count - index - 1);
            Array.Copy(numbers, index + 1, numbers, index, count - index - 1);
            count--;
            Console.WriteLine("Контакт удален.");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

}