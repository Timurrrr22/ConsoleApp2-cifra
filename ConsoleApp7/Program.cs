//1
string[,] board = new string[8, 8];

// Заполнение доски
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        // Чередование цветов клеток
        if ((i + j) % 2 == 0)
        {
            //Белые
            board[i, j] = "W";
        }
        else
        {
            //Черные
            board[i, j] = "B";
        }
    }
}
//Вывод доски
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write(board[i, j] + " "); 
    }
    Console.WriteLine(); // Переход на новую строку после каждой строки доски
}

//2
string[] suits = { "Червы", "Бубны", "Крести", "Пики" }; // Масти
string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Королева", "Король", "Туз" }; // Ранг карты

string[,,] players = new string[4, 2, 2]; // 4 игрока, 2 карты, [масть, ранг]
Random random = new Random();

// Заполнение массива players
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 2; j++)
    {
        int suitIndex = random.Next(suits.Length);
        int rankIndex = random.Next(ranks.Length);

        players[i, j, 0] = suits[suitIndex]; // Масть
        players[i, j, 1] = ranks[rankIndex]; // Ранг
    }
}


// Вывод результатов
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Игрок {i + 1}:");
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine($"{players[i, j, 0]} {players[i, j, 1]}"); // Вывод карты
    }
    Console.WriteLine();
}

