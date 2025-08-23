//NewMethod();

//static void NewMethod()
//{
//    Random random5 = new Random();
//    int cTo = random5.Next(0, 101);
//    while (true)
//    {
//        Console.WriteLine("Попробуйте отгадать число от 0 до 100: ");
//        string vdf = Console.ReadLine();
//        bool uf = int.TryParse(vdf, out int ufgad);

//        if (ufgad == cTo)
//        {
//            Console.WriteLine("Угадал, шайтан");
//            break;
//        }
//        else if (cTo > ufgad)
//        {
//            Console.WriteLine("Загаданное число больше");
//        }
//        else
//        {
//            Console.WriteLine("Загаданное число меньше");
//        }
//    }
//}



////MaxOfTwo();

//static void MaxOfTwo()
//{
//        Console.Write("Enter the first number: ");
//        if (double.TryParse(Console.ReadLine(), out double num1))
//        {
//            Console.Write("Enter the second number: ");
//            if (double.TryParse(Console.ReadLine(), out double num2))
//            {
//                double max = Math.Max(num1, num2);
//                Console.WriteLine($"The maximum of {num1} and {num2} is: {max}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid input for the second number.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input for the first number.");
//        }
//}




////2.Finding the Absolute Value of a Number:


////AbsoluteValue();

//     static void AbsoluteValue()
//    {
//        Console.Write("Enter a number: ");
//        if (double.TryParse(Console.ReadLine(), out double num))
//        {
//            double abs = Math.Abs(num);
//            Console.WriteLine($"The absolute value of {num} is: {abs}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input.");
//        }
//    }



////4.Finding the Integer Square Root of a Number:


//// IntegerSquareRoot();

// static void IntegerSquareRoot()
//    {
//        Console.Write("Enter a non-negative number: ");
//        if (double.TryParse(Console.ReadLine(), out double num))
//        {
//            if (num < 0)
//            {
//                Console.WriteLine("Cannot calculate square root of a negative number.");
//            }
//            else
//            {
//                int sqrt = (int)Math.Floor(Math.Sqrt(num));
//                Console.WriteLine($"The integer square root of {num} is: {sqrt}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input.");
//        }
//    }



////5.Raising a Number to a Power:



//// PowerOfNumber();

// static void PowerOfNumber()
//    {
//        Console.Write("Enter the base number: ");
//        if (double.TryParse(Console.ReadLine(), out double baseNum))
//        {
//            Console.Write("Enter the exponent: ");
//            if (double.TryParse(Console.ReadLine(), out double exponent))
//            {
//                double result = Math.Pow(baseNum, exponent);
//                Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid input for the exponent.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input for the base number.");
//        }
//    }


////6.
//// PowerOfNumber1();

//     static void PowerOfNumber1()
//    {
//        Console.WriteLine("Введите число для округления: ");
//        string sh = Console.ReadLine();
//        double sh1 = double.Parse(sh);
//        double val = Math.Round(sh1);
//        Console.WriteLine(val);
//    }


////7
//// PowerOfNumber2();

//    static void PowerOfNumber2()
//    {
//        Console.WriteLine("Введите число для округления: ");
//        string sh = Console.ReadLine();
//        double sh1 = double.Parse(sh);
//        double val = Math.Ceiling(sh1);
//        Console.WriteLine(val);
//    }


////8
////int dividend = 10;
////int divisor = 3;
////int quotient, remainder;
////quotient = Math.DivRem(dividend, divisor, out remainder);
////Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");

////9
//// CircleArea();

// static void CircleArea()
//    {
//        Console.Write("Введите радиус круга: ");
//        if (double.TryParse(Console.ReadLine(), out double radius))
//        {
//            if (radius < 0)
//            {
//                Console.WriteLine("Радиус не может быть отрицательным.");
//            }
//            else
//            {
//                double area = Math.PI * Math.Pow(radius, 2);
//                Console.WriteLine($"Площадь круга равна: {area:F2}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод радиуса.");
//        }
//    }


////10
//// FallingTime();

// static void FallingTime()
//    {
//        Console.Write("Введите высоту (H) в метрах: ");
//        if (double.TryParse(Console.ReadLine(), out double height))
//        {
//            if (height < 0)
//            {
//                Console.WriteLine("Высота не может быть отрицательной.");
//            }
//            else
//            {
//                const double g = 9.81;
//                double time = Math.Sqrt(2 * height / g);
//                Console.WriteLine($"Время падения: {time:F2} секунд");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Вводи числа, умник.");
//        }
//    }

////1
//Console.WriteLine("Введите длину первого катета: ");
//string str = Console.ReadLine();
//double s1 = Double.Parse(str);
//Console.WriteLine("Введите длину второго катета: ");
//string str2 = Console.ReadLine();
//double s2 = Double.Parse(str2);

//double hyport = Math.Sqrt(s1 * s1 + s2 * s2);
//Console.WriteLine($" Гипотенуза равна: {hyport}");
//Console.ReadLine();

////2
//Console.WriteLine("Введите значение угла в градусах: ");
//string gavgav = Console.ReadLine();
//double ugol = double.Parse(gavgav);
//Console.WriteLine($"sin:{Math.Sin(ugol / 57.3)}\n cos:{Math.Cos(ugol / 57.3)}\ntan:{Math.Tan(ugol / 57.3)}");

////3
//Console.Write("Сторона квадрата: ");
//double a = double.Parse(Console.ReadLine());
//double p = 4 * a;
//double square = Math.Pow(a, 2);
//Console.WriteLine($"Периметр квадрата:{p}\nПлощадь квадрата: {square}");

////4
//Console.WriteLine("Введите 1 угол: ");
//string ugol1 = Console.ReadLine();
//Console.WriteLine("Введите 2 угол: ");
//string ugol2 = Console.ReadLine();
//int ug1 = int.Parse(ugol1);
//int ug2 = int.Parse(ugol2);
//int ugol3 = 180 - (ug1 + ug2);
//Console.WriteLine($"3 угол в градусах: {ugol3}");


//using System;

//public class RandomNumberGenerator
//{
//    public static void Main(string[] args)
//    {
//        Random random = new Random();

//        // Меню выбора типа генерации
//        Console.WriteLine("Выберите тип генерации случайных чисел:");
//        Console.WriteLine("1. Целые числа");
//        Console.WriteLine("2. Числа с плавающей точкой");
//        Console.WriteLine("3. Числа в заданном диапазоне");
//        Console.Write("Введите номер варианта (1-3): ");

//        if (int.TryParse(Console.ReadLine(), out int choice))
//        {
//            switch (choice)
//            {
//                case 1: // Целые числа
//                    GenerateIntegers(random);
//                    break;
//                case 2: // Числа с плавающей точкой
//                    GenerateDoubles(random);
//                    break;
//                case 3: // Числа в заданном диапазоне
//                    GenerateRange(random);
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод.");
//        }
//    }

//    // Генерация целых чисел
//    static void GenerateIntegers(Random random)
//    {
//        Console.Write("Введите количество целых чисел для генерации: ");
//        if (int.TryParse(Console.ReadLine(), out int count))
//        {
//            if (count <= 0)
//            {
//                Console.WriteLine("Количество чисел должно быть больше 0");
//                return;
//            }
//            Console.WriteLine("Сгенерированные целые числа:");
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine(random.Next()); //Генерирует случайное положительное целое число
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод количества чисел.");
//        }
//    }

//    // Генерация чисел с плавающей точкой
//    static void GenerateDoubles(Random random)
//    {
//        Console.Write("Введите количество чисел с плавающей точкой для генерации: ");
//        if (int.TryParse(Console.ReadLine(), out int count))
//        {
//            if (count <= 0)
//            {
//                Console.WriteLine("Количество чисел должно быть больше 0");
//                return;
//            }
//            Console.WriteLine("Сгенерированные числа с плавающей точкой:");
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine(random.NextDouble()); //Генерирует случайное число от 0 до 1
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод количества чисел.");
//        }
//    }

//    // Генерация чисел в заданном диапазоне
//    static void GenerateRange(Random random)
//    {
//        Console.Write("Введите минимальное значение диапазона: ");
//        if (int.TryParse(Console.ReadLine(), out int min))
//        {
//            Console.Write("Введите максимальное значение диапазона: ");
//            if (int.TryParse(Console.ReadLine(), out int max))
//            {
//                if (min >= max)
//                {
//                    Console.WriteLine("Минимальное значение должно быть меньше максимального");
//                    return;
//                }
//                Console.Write("Введите количество чисел для генерации: ");
//                if (int.TryParse(Console.ReadLine(), out int count))
//                {
//                    if (count <= 0)
//                    {
//                        Console.WriteLine("Количество чисел должно быть больше 0");
//                        return;
//                    }
//                    Console.WriteLine($"Сгенерированные числа в диапазоне от {min} до {max}:");
//                    for (int i = 0; i < count; i++)
//                    {
//                        Console.WriteLine(random.Next(min, max + 1)); // +1, чтобы включить max
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Неверный ввод количества чисел.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный ввод максимального значения.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод минимального значения.");
//        }
//    }
//}

//2
//Console.WriteLine("Введите элементы перечня, разделенные запятыми (например, яблоко,банан,вишня):");
//string input = Console.ReadLine();
//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Перечень элементов пуст.");
//    return;
//}
//string[] elements = input.Split(',');
//if (elements.Length == 0)
//{
//    Console.WriteLine("Перечень элементов пуст.");
//    return;
//}
//Random random = new Random();
//int randomIndex = random.Next(elements.Length);
//Console.WriteLine($"Случайно выбранный элемент: {elements[randomIndex]}");

//доллары, евро, рубли юани и стерлинги
//3
//Console.WriteLine("Выберите валюту: ");
//Console.WriteLine("1.юани,\n2.доллары,\n3.рубли,\n4.стерлинги,\n5.евро ");
//string valuta = Console.ReadLine();
//Console.WriteLine("Введите количество этой валюты и курс по которома хотите конветировать");
//string av = Console.ReadLine();
//int money = int.Parse(av);
//string ab = Console.ReadLine();
//float kurs = float.Parse(ab);
//Console.WriteLine($"{money * kurs}");

//4
Random random = new Random();
int randomIndex = random.Next(0, 11);
while (true)
{
    Console.WriteLine("Попробуй угадать число от 0 до 10: ");
    string abs = Console.ReadLine();
    int ugad = int.Parse(abs);
    
    if (ugad < randomIndex)
    {
        Console.WriteLine("Загаданное число больше");
    }
    else if (ugad > randomIndex)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else if (ugad == randomIndex)
    {
        Console.WriteLine("Угадал, шайтан");
        break;
    }
}

//7
Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            { "Пицца Маргарита", 10.99 },
            { "Спагетти Карбонара", 12.50 },
            { "Салат Цезарь", 8.75 },
            { "Бургер с сыром", 9.99 },
            { "Куриные крылышки", 7.50 }
        };

// Меню напитков с ценами
Dictionary<string, double> drinksMenu = new Dictionary<string, double>()
        {
            { "Кола", 2.00 },
            { "Фанта", 2.00 },
            { "Спрайт", 2.00 },
            { "Сок (апельсиновый)", 2.50 },
            { "Вода", 1.50 }

        };

double totalPrice = 0;
string choice;

//Вывод меню блюд
Console.WriteLine("Меню блюд:");
foreach (var item in menu)
{
    Console.WriteLine($"{item.Key} - {item.Value:C}"); // :C для форматирования валюты
}

//Выбор блюд
do
{
    Console.Write("Выберите блюдо (или введите 'готово'): ");
    choice = Console.ReadLine();
    if (menu.ContainsKey(choice))
    {
        totalPrice += menu[choice];
        Console.WriteLine($"Добавлено: {choice}, текущая стоимость {totalPrice:C}");
    }
    else if (!choice.Equals("готово", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Такого блюда нет в меню.");
    }
} while (!choice.Equals("готово", StringComparison.OrdinalIgnoreCase));


//Вывод меню напитков
Console.WriteLine("\nМеню напитков:");
foreach (KeyValuePair<string, double> item in drinksMenu)
{
    Console.WriteLine($"{item.Key} - {item.Value:C}");
}

//Выбор напитков
do
{
    Console.Write("Выберите напиток (или введите 'готово'): ");
    choice = Console.ReadLine();
    if (drinksMenu.ContainsKey(choice))
    {
        totalPrice += drinksMenu[choice];
        Console.WriteLine($"Добавлено: {choice}, текущая стоимость {totalPrice:C}");
    }
    else if (!choice.Equals("готово", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Такого напитка нет в меню.");
    }
} while (!choice.Equals("готово", StringComparison.OrdinalIgnoreCase));


Console.WriteLine($"\nОбщая стоимость заказа: {totalPrice:C}");

