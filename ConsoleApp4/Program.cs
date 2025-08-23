// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////1

//int[] lox = new int[]
//{
//    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
//};

////2,3

//string[] namesKakixtoLoxov = new string[]
//{
//    "Дмитрий", "Максим", "Сергей", "Андрей", "Владислав"
//};
//Console.WriteLine(namesKakixtoLoxov[1]);
//Console.WriteLine("Введите цифру имени");
//string yrt = Console.ReadLine();
//int aia = int.Parse(yrt);
//for (int i = 0;  i < namesKakixtoLoxov.Length; i++)
//{
//    Console.WriteLine($"{i+1}.{namesKakixtoLoxov[i]}");
//}
//Console.WriteLine(namesKakixtoLoxov[aia - 1]);

//4

//string[] names = new string[5];
//for  (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Вводите имена:");
//    string a = Console.ReadLine();
//    names[i] = a;



//}
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//5

//int[] bad = new int[]
//{
//    12, 34, 65, 34, 7, 6, 56, 54, 90, 15, 10
//};
//Console.WriteLine("Введите число, для проверки наличия его в массиве: ");
//string a = Console.ReadLine();
//int b = int.Parse(a);
//for (int i = 0; i < bad.Length; i++)
//{
//    if (bad[i] == b)
//    {
//        Console.WriteLine($"Красавчик: {b}");
//        return;
//    }
//    else
//    {
//        Console.WriteLine("Число не найдено");
//    }
//}





//1

//int[] chislaVrodeNormalnie = new int[]
//{
//    12, 50, 34, 21, 90, 67, 89, 77, 22, 3
//};
//int sum = 0;
//for (int i = 0; i < chislaVrodeNormalnie.Length; i++)
//{
//    if (chislaVrodeNormalnie[i] % 3 == 0)
//    {
//        sum += chislaVrodeNormalnie[i];
//    }
//}
//Console.WriteLine(sum);

//2

//int[] chislaUzheNenormalnie = new int[]
//{
//    42,13,23,23,45,54, -90,543, 123, 43, -23, 456, 78, 1, 0, 9, 5, 7,50, 23
//};
//for (int i = 0; i < chislaUzheNenormalnie.Length; i++)
//{
//    if (chislaUzheNenormalnie[i] < 0)
//    {
//        int index = Array.IndexOf(chislaUzheNenormalnie, chislaUzheNenormalnie[i]);
//        Console.WriteLine(index);
//        break;
//    }
//}

//3

//int[] chisla = new int[]
//{
//    23, 56, 54, 21, 89, 67, 35, 79,13, 43, 87, 22, 90, 66, 68
//};
//for (int i = 0; i < chisla.Length; i++)
//{
//    if (chisla[i] % 2 == 0 & chisla[i] % 3 != 0)
//    {
//        Console.WriteLine(chisla[i]);
//    }
//}

//6

//int[] chisla1 = new int[]
//{
//    23, 56, 54, 21, 89, 67, 35, 79,13, 43, 87, 22, 90, 66, 68, 66, 79
//};
//for (int i = 0; i < chisla1.Length; i++)
//{
//    for (int j = i + 1; j < chisla1.Length; j++)
//        if (chisla1[i] == chisla1[j])
//        {
//            Console.WriteLine(chisla1[i]);
//        }
//}


//1
int[] numbers = new int[5]; // Создаем массив из 5 элементов

// Запрашиваем у пользователя 5 чисел
Console.WriteLine("Введите 5 чисел:");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Число {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int number)) // Проверяем корректность ввода
    {
        numbers[i] = number;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
        i--; // Повторяем ввод для текущего элемента
    }
}
Array.Reverse(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//2
string[] words = new string[5]; // Массив для хранения слов

// Запрашиваем у пользователя 5 слов
Console.WriteLine("Введите 5 слов:");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Слово {i + 1}: ");
    words[i] = Console.ReadLine();
}

// Находим самое длинное слово
string longestWord = "";
foreach (string word in words)
{
    if (word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}

// Выводим результат
Console.WriteLine($"\nСамое длинное слово: {longestWord}");

//3
Random random = new Random();
int[] array1 = Enumerable.Range(0, 5).Select(x => random.Next(1, 101)).ToArray(); // 5 чисел от 1 до 100
int[] array2 = Enumerable.Range(0, 7).Select(x => random.Next(1, 101)).ToArray(); // 7 чисел от 1 до 100


// Выводим исходные массивы 
Console.WriteLine("Первый массив: " + string.Join(", ", array1));
Console.WriteLine("Второй массив: " + string.Join(", ", array2));


// Объединяем массивы с помощью Concat()
int[] combinedArray = array1.Concat(array2).ToArray();

// Вычисляем среднее арифметическое
double average = combinedArray.Average();

// Выводим объединенный массив и среднее арифметическое
Console.WriteLine("\nОбъединенный массив: " + string.Join(", ", combinedArray));
Console.WriteLine("Среднее арифметическое: " + average);

//4
int[] numbers1 = new int[10]; // Массив для хранения 10 чисел

// Запрашиваем у пользователя 10 чисел с проверкой на корректность ввода
Console.WriteLine("Введите 10 чисел:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Число {i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out numbers1[i]))
    {
        Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
    }
}

// Находим наименьшее и наибольшее числа
int min = numbers1[0];
int max = numbers1[0];
for (int i = 1; i < numbers1.Length; i++)
{
    if (numbers1[i] < min)
    {
        min = numbers1[i];
    }
    if (numbers1[i] > max)
    {
        max = numbers1[i];
    }
}

int abh = numbers1.Max();
// Выводим результаты
Console.WriteLine($"\nНаименьшее число: {min}");
Console.WriteLine($"Наибольшее число: {max}");
Console.WriteLine(abh);

//5
Console.WriteLine("Введите 5 слов с маленькой буквы:");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Слово {i + 1}: ");
    words[i] = Console.ReadLine();
}
Console.Write("\nВведите начальную букву: ");
char startLetter = char.ToLower(Console.ReadKey().KeyChar); // Преобразуем к нижнему регистру

Console.WriteLine("\nСлова, начинающиеся на '" + startLetter + "':");
bool found = false; 
foreach (string word in words)
{
    if (word.Length > 0 && word[0] == startLetter) // Проверяем, что слово не пустое
    {
        Console.WriteLine(word);
        found = true;
    }
}

if (!found)
{
    Console.WriteLine("Слова, начинающиеся на '" + startLetter + "', не найдены.");
}