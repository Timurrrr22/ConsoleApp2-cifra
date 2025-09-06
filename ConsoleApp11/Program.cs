//void Guess()
//{
//    Random random = new Random();
//    int загаданноеЧисло = random.Next(1, 101); 
//    int попытки = 0;
//    bool угадано = false;

//    Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
//    Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать.");

//    while (!угадано)
//    {
//        Console.Write("Введите ваше предположение: ");
//        string ввод = Console.ReadLine();

//        if (int.TryParse(ввод, out int предположение)) // Проверяем, что введено число
//        {
//            попытки++;

//            if (предположение < загаданноеЧисло)
//            {
//                Console.WriteLine("Загаданное число больше.");
//            }
//            else if (предположение > загаданноеЧисло)
//            {
//                Console.WriteLine("Загаданное число меньше.");
//            }
//            else
//            {
//                угадано = true;
//                Console.WriteLine($"Поздравляю! Вы угадали число {загаданноеЧисло} за {попытки} попыток.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
//        }
//    }
//    Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
//    Console.ReadKey();
//}
//Guess();


class Program
{
    static void Main(string[] args)
    {
        Task task1 = Task.Run(() => Console.WriteLine("Задача 1: Привет из задачи 1!"));
        Task task2 = Task.Run(() => Console.WriteLine("Задача 2: Привет из задачи 2!"));
        Task task3 = Task.Run(() => Console.WriteLine("Задача 3: Привет из задачи 3!"));

        Task.WaitAll(task1, task2, task3);
    }
}






//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 10, 15, 20, 25 }; // Для больших чисел
//        Task<long>[] tasks = new Task<long>[numbers.Length];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int number = numbers[i];
//            tasks[i] = Task.Run(() => Factorial(number));
//        }

//        Task.WaitAll(tasks);

//        for (int i = 0; i < tasks.Length; i++)
//        {
//            Console.WriteLine($"Факториал {numbers[i]} = {tasks[i].Result}");
//        }
//    }

//    static long Factorial(int n)
//    {
//        if (n == 0) return 1;
//        long result = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            result *= i;
//        }
//        return result;
//    }
//}





//class Program
//{
//    static void Main(string[] args)
//    {
//        int numberOfRandoms = 10; // Количество случайных чисел
//        Task<int>[] tasks = new Task<int>[numberOfRandoms];

//        Random random = new Random();

//        for (int i = 0; i < numberOfRandoms; i++)
//        {
//            int index = i; // Локальная переменная для замыкания
//            tasks[i] = Task.Run(() => random.Next(1, 100)); // Генерация случайного числа от 1 до 99
//        }

//        Task.WaitAll(tasks);

//        Console.WriteLine("Сгенерированные случайные числа:");
//        foreach (var task in tasks)
//        {
//            Console.WriteLine(task.Result);
//        }
//    }
//}
