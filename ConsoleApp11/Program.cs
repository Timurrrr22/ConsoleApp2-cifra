void Guess()
{
    Random random = new Random();
    int загаданноеЧисло = random.Next(1, 101); 
    int попытки = 0;
    bool угадано = false;

    Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
    Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать.");

    while (!угадано)
    {
        Console.Write("Введите ваше предположение: ");
        string ввод = Console.ReadLine();

        if (int.TryParse(ввод, out int предположение)) // Проверяем, что введено число
        {
            попытки++;

            if (предположение < загаданноеЧисло)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (предположение > загаданноеЧисло)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                угадано = true;
                Console.WriteLine($"Поздравляю! Вы угадали число {загаданноеЧисло} за {попытки} попыток.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }
    Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
    Console.ReadKey();
}
Guess();