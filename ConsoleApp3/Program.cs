//1
//Console.Write("Введите целое число: ");
//string input = Console.ReadLine();

//if (int.TryParse(input, out int number))
//{
//    if (number >= 1)
//    {
//        int i = 1;
//        while (i <= number)
//        {
//            Console.Write(i + " ");
//            i++;
//        }
//        Console.WriteLine();
//    }
//    else
//    {
//        Console.WriteLine("Число должно быть больше или равно 1.");
//    }
//}
//else
//{
//    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
//}

//2
//Console.WriteLine("Введите два целых числа: ");
//string input1 = Console.ReadLine();
//string input2 = Console.ReadLine();
//int inp1 =  int.Parse(input1);
//int inp2 = int.Parse(input2);
//while  (inp1 <= inp2)
//{
//    Console.Write(inp1 + " ");
//    inp1++;
//}

//3
//Console.WriteLine("\nВведите целое число, и мы проверим сколько в нем четных чисел: ");
//string input3 = Console.ReadLine();
//int inp3 = int.Parse(input3);
//int i1 = 1;
//while (i1 <= inp3)
//{
//    i1++;
//    if (i1 % 2 == 0)
//    {
//        Console.Write(i1 + " ");
//    }
//}

//4
//Console.WriteLine("\nВведите число, для которого выведется таблица умножения: ");
//string inpput = Console.ReadLine();
//int innput =  int.Parse(inpput);
//int i2 = 0;
//while (i2 <= 9)
//{
//    i2++;
//    Console.WriteLine($"{i2} * {innput} = {i2 * innput}");
//}

//5
//Console.WriteLine("Введите число, для которого выведется сумма всех чисел до него включительно: ");
//string chislo =  Console.ReadLine();
//int ch =  int.Parse(chislo);
//int a = 0;
//int sum = 0;
//while (a < ch)
//{
//    a++;
//    sum += a;
//}
//Console.WriteLine(sum);

//6
//string[] array2 = new string[]
//{
//    "Low: modename",
//    "Medium: modeName",
//    "Low: modeName",
//    "High: modeName"
//};

//string[] lowPriorities = new string[2];
//string[] mediumPriorities = new string[1];
//string[] highPriorities = new string[1];

//int lowIndex = 0;
//foreach (var item in array2)
//{
//    if (item.Split(':')[0] == "Low")
//    {
//        lowPriorities[lowIndex] = item;
//        lowIndex++;
//    }
//}
//int mediumIndex = 0;
//foreach (var item in array2)
//{
//    if (item.Split(':')[0] == "Medium")
//    {
//        mediumPriorities[mediumIndex] = item; 
//        mediumIndex++;
//    }
//}
//int highIndex = 0;
//foreach (var item in array2)
//{
//    if (item.Split(':')[0] == "High")
//    {
//        highPriorities[highIndex] = item;
//        highIndex++;
//    }
//}
//Console.WriteLine(string.Join(",", array2));

//string a = Console.ReadLine();
//int a1 =  int.Parse(a);

//int factorial(int a1)
//{
//    if (a1 == 0) return 1;

//    return a1 * factorial(a1 - 1);
//}
//int factorial4 = factorial(4);
//Console.WriteLine(factorial4);

// Создать приложение, бесконечно считывающее ввод пользователя, пока
// он не напишет "Выход". Пользователь должен вводить только числа (всё,
// что числами не является - в консоль не выводится, а пользователь 
// получает предупреждение). После окончания ввода вывести максимальное
// и минимальное числа из тех, которые вводил пользователь.

//using static System.Runtime.InteropServices.JavaScript.JSType;

//List<int> numbers = new List<int>();
//while (true)
//{
//    Console.WriteLine("Вводите числа. Когда захотите выйти ввeдите: Выход");
//    string a = Console.ReadLine();
//    bool b = int.TryParse(a, out int number);
//    if (b) numbers.Add(number);
//    if (a == "Выход")
//    {
//        int min = numbers.Min();
//        Console.WriteLine(numbers.Min());
//        Console.WriteLine(numbers.Max());
//        break;
//    }
//}

// * Вывести самую большую сумму пар последовательно идущих чисел.
// Т.е. если пользователь ввёл 2 4 1, то здесь будет две пары: 2 + 4,
// 4 + 1. Пользователь получит результат суммирования первых
// двух чисел (6)


//string n = Console.ReadLine();
//bool b1 = int.TryParse(n, out int n1);
//string m = Console.ReadLine();
//bool b2 = int.TryParse(m, out int m1);
//string l = Console.ReadLine();
//bool b3 = int.TryParse(l, out int l1);
//    {
//        int makaka = n1 + m1;
//        int makaka1 = m1 + l1;

//        if (makaka > makaka1)
//        {
//            Console.WriteLine(makaka);
//        }
//        else
//        {
//            Console.WriteLine(makaka1);
//        }      
//    }

//Random random = new Random();

//int car1x = random.Next(0, 11);
//int car1y = random.Next(0, 11);
//int car2x = random.Next(0, 11);
//int car2y = random.Next(0, 11);
//int car3x = random.Next(0, 11);
//int car3y = random.Next(0, 11);
//Console.WriteLine("Введите свои координаты(x;y - каждая координата от 0 до 10) и мы отправим вам ближайшее транспортное средство: ");
//string pls = Console.ReadLine();
//int clientx = int.Parse(pls); 
//string lakaka = Console.ReadLine();
//int clienty = int.Parse(lakaka);

//int d1x = Math.Abs(clientx - car1x);
//int d1y = Math.Abs(clienty - car1y);
//double dd1 = Math.Sqrt(d1x * d1x + d1y * d1y);

//int d2x = Math.Abs(clientx - car2x);
//int d2y = Math.Abs(clienty - car2y);
//double dd2 = Math.Sqrt(d2x * d2x + d2y * d2y);

//int d3x = Math.Abs(clientx - car3x);
//int d3y = Math.Abs(clienty - car3y);
//double dd3 = Math.Sqrt(d3x * d3x +  d3y * d3y);

//if (dd1 < dd2 && dd1 < dd3)
//{
//    Console.WriteLine("К вам выехала Honda");
//}
//else if (dd2 < dd1 && dd2 < dd3)
//{
//    Console.WriteLine("К вам выехал Mercedes");
//}
//else
//{
//    Console.WriteLine("К вам выехал Nissan");
//}

//Console.WriteLine("Введите слово для проверки на палиндром: ");
//string a =  Console.ReadLine();
//string b = "";
//for (int i = a.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(b += a[i]);
//}
//if (a == b)
//{
//    Console.WriteLine("Это палиндром");
//}
//else
//{
//    Console.WriteLine("Это не палиндром");
//}


//Console.WriteLine("Введите любую cтроку: ");
//string a = Console.ReadLine();
//string result = "";
//for  (int i = 1; i < a.Length; i+= 2)
//{
//    result += a[i];
//}
//Console.WriteLine(result);

//string vowelChars = "аоыэуюиеёяАОЫЭУЮИЕЁ";
//string input = Console.ReadLine();
//string star = "*";
//for (int i = 0; i < input.Length; i++)
//{
//    char symbol = input[i];
//    bool isVowel = vowelChars.IndexOf(symbol) >= 0;
//    if (isVowel)
//    {
//        input.Append(star);
//    }
//}

string str = Console.ReadLine();
string vowels = "аоыэуюиеёяАОЫЭУЮИЕЁ";
string result = new string(str.Select(c => vowels.Contains(c) ? '*' : c).ToArray());
Console.WriteLine(result); 

for (int i = 1; i <= 10; i++)
{

    for (int j = 1; j <= 10; j++)
    {
        int product = i * j;
        Console.Write($"{product,4}");
    }
    Console.WriteLine();
}

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


        int rows = 5; // Количество строк в верхней половине ромба (можно изменить)

        // Верхняя половина ромба
        for (int i = 1; i <= rows; i++)
        {
            // Пробелы перед звездочками
            for (int k = 1; k <= rows - i; k++)
            {
                Console.Write(" ");
            }
            // Звездочки
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Нижняя половина ромба
        for (int i = rows - 1; i >= 1; i--)
        {
            // Пробелы перед звездочками
            for (int k = 1; k <= rows - i; k++)
            {
                Console.Write(" ");
            }
            // Звездочки
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }