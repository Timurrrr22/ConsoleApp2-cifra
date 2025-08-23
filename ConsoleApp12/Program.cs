//public class SimpleCalculator
//{
//    public static double Calculate(double num1, double num2, char operation)
//    {
//        double result = 0;

//        switch (operation)
//        {
//            case '+':
//                result = num1 + num2;
//                break;
//            case '-':
//                result = num1 - num2;
//                break;
//            case '*':
//                result = num1 * num2;
//                break;
//            case '/':
//                if (num2 != 0) // Проверка на ноль
//                {
//                    result = num1 / num2;
//                }
//                else
//                {
//                    Console.WriteLine("Деление на ноль невозможно. Результат будет 0."); // Простое сообщение об ошибке
//                }
//                break;
//            default:
//                Console.WriteLine("Неизвестная операция. Результат будет 0."); // Простое сообщение об ошибке
//                break;
//        }

//        return result;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        double num1 = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите второе число:");
//        double num2 = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите операцию (+, -, *, /):");
//        char operation = char.Parse(Console.ReadLine());

//        double result = Calculate(num1, num2, operation);
//        Console.WriteLine("Результат: " + result);
//    }
//}




//public class FactorialCalculator
//{
//    public static long ComputeFactorial(int n)
//    {
//        if (n < 0)
//        {
//            return -1; 
//        }

//        long Factorial(int num)
//        {
//            if (num == 0)
//            {
//                return 1; 
//            }
//            else
//            {
//                return num * Factorial(num - 1); // Рекурсивный вызов
//            }
//        }

//        return Factorial(n);
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите неотрицательное целое число:");
//        int number;
//        if (int.TryParse(Console.ReadLine(), out number))
//        {
//            long factorial = ComputeFactorial(number);
//            if (factorial == -1)
//            {
//                Console.WriteLine("Факториал не определен для отрицательных чисел.");
//            }
//            else
//            {
//                Console.WriteLine("Факториал " + number + "! = " + factorial);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: Неверный формат ввода.");
//        }
//    }
//}




//public class FibonacciCalculator
//{
//    public static long GetFibonacci(int n)
//    {
//        if (n < 0)
//        {
//            return -1;
//        }

//        long[] memo = new long[n + 1]; // Массив для мемоизации

//        long Fib(int k)
//        {
//            if (k <= 1)
//            {
//                return k; // Базовый случай: F(0) = 0, F(1) = 1
//            }

//            if (memo[k] != 0)
//            {
//                return memo[k]; 
//            }

//            memo[k] = Fib(k - 1) + Fib(k - 2); // Рекурсивный вызов с мемоизацией
//            return memo[k];
//        }

//        return Fib(n);
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите неотрицательное целое число n:");
//        if (int.TryParse(Console.ReadLine(), out int n))
//        {
//            long fibonacciNumber = GetFibonacci(n);
//            if (fibonacciNumber == -1)
//            {
//                Console.WriteLine("n должно быть неотрицательным.");
//            }
//            else
//            {
//                Console.WriteLine($"{n}-е число Фибоначчи: {fibonacciNumber}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: Неверный формат ввода.");
//        }
//    }
//}



//public class TemperatureConverter
//{
//    public static double ConvertTemperature(double temperature, string conversionType)
//    {
//        // Локальные функции для конвертации температур
//        double CelsiusToFahrenheit(double celsius) => celsius * 9.0 / 5.0 + 32.0;
//        double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32.0) * 5.0 / 9.0;

//        // Выбор функции конвертации.
//        switch (conversionType.ToUpper())
//        {
//            case "CTOF":
//                return CelsiusToFahrenheit(temperature);
//            case "FTOC":
//                return FahrenheitToCelsius(temperature);
//            default:
//                Console.WriteLine("Неверный тип конвертации. Возвращаю исходную температуру.");
//                return temperature; // Возвращаем исходную температуру при ошибке
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение температуры:");
//        double temperature = double.Parse(Console.ReadLine()); 

//        Console.WriteLine("Введите тип конвертации ('CtoF' или 'FtoC'):");
//        string conversionType = Console.ReadLine();

//        double convertedTemperature = ConvertTemperature(temperature, conversionType);
//        Console.WriteLine($"Результат: {convertedTemperature}");
//    }
//}






//Console.WriteLine("Введите первое целое число:");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите второе целое число:");
//int b = int.Parse(Console.ReadLine());

//int gcd = ComputeGCD(a, b);
//Console.WriteLine($"НОД ({a}, {b}) = {gcd}");

//int ComputeGCD(int a, int b)
//{
//    // Обработка случаев с нулем и отрицательными числами
//    a = Math.Abs(a);
//    b = Math.Abs(b);

//    if (a == 0) return b;
//    if (b == 0) return a;

//    int GCD(int num1, int num2)
//    {
//        if (num2 == 0)
//        {
//            return num1; // Базовый случай рекурсии
//        }
//        else
//        {
//            return GCD(num2, num1 % num2); // Рекурсивный вызов
//        }
//    }
//    return GCD(a, b);
//}





//Console.WriteLine("Введите текст:");
//string text = Console.ReadLine();

//Console.WriteLine("Введите сдвиг:");
//if (int.TryParse(Console.ReadLine(), out int shift))
//{
//    string encryptedText = CaesarCipher(text, shift);
//    Console.WriteLine($"Зашифрованный текст: {encryptedText}");
//}
//else
//{
//    Console.WriteLine("Ошибка: Неверный формат ввода сдвига.");
//}

//string CaesarCipher(string text, int shift)
//{
//    string result = "";

//    for (int i = 0; i < text.Length; i++)
//    {
//        char c = text[i];
//        if (char.IsLetter(c))
//        {
//            char start = char.IsUpper(c) ? 'A' : 'a';
//            c = (char)(((c - start + shift) % 26 + 26) % 26 + start);
//        }
//        result += c; // Конкатенация строк
//    }

//    return result;
//}



Console.WriteLine("Введите неотрицательное целое число n:");
if (int.TryParse(Console.ReadLine(), out int n))
{
    long result = SumOfSquares(n);
    Console.WriteLine($"Сумма квадратов чисел от 1 до {n}: {result}");
}
else
{
    Console.WriteLine("Ошибка: Неверный формат ввода.");
}

long SumOfSquares(int n)
{
    if (n < 0) n = 0; // Просто игнорируем отрицательное n

    long sum = 0;
    long[] cache = new long[n + 1];

    long Square(int x)
    {
        if (x < 0) x = 0; // Игнорируем отрицательные x
        if (x > n) x = n; // Игнорируем x > n



        cache[x] = (long)x * x;
        return cache[x];
        
    }

    for (int i = 1; i <= n; i++)
    {
        sum += Square(i);
    }

    return sum;
}




double Calculate(double num1, double num2, char operation)
{
    double Add(double a, double b) => a + b;
    double Subtract(double a, double b) => a - b;
    double Multiply(double a, double b) => a * b;
    double Divide(double a, double b) => b == 0 ? 0 : a / b;

    double result = 0; // Инициализируем result

    switch (operation)
    {
        case '+':
            result = Add(num1, num2);
            break;
        case '-':
            result = Subtract(num1, num2);
            break;
        case '*':
            result = Multiply(num1, num2);
            break;
        case '/':
            result = Divide(num1, num2); 
            break;
        default:
            Console.WriteLine("Неверная операция!"); // Выводим сообщение об ошибке
            break;
    }

    return result;
}


    Console.WriteLine(Calculate(5, 2, '+')); // 7
    Console.WriteLine(Calculate(5, 2, '-')); // 3
    Console.WriteLine(Calculate(5, 2, '*')); // 10
    Console.WriteLine(Calculate(5, 2, '/')); // 2.5
    Console.WriteLine(Calculate(5, 0, '/')); // 0 - теперь возвращается 0 при делении на 0
    Console.WriteLine(Calculate(5, 2, '%')); // 0 - и при неверной операции
