int width = 10;
int height = 10;
char[,] map = new char[height, width];
int playerX = 1;
int playerY = 1;
int itemsCount = 0;
int collectedItems = 0;
Random random = new Random();

// Генерация карты
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (i == 0 || i == 9 || j == 0 || j == 9)
        {
            map[i, j] = '#';
        }
        else
        {
            if (random.Next(5) == 0 && (i != playerY || j != playerX))
            {
                map[i, j] = 'I';
                itemsCount++;
            }
            else
            {
                map[i, j] = '.';
            }
        }
    }
}


map[playerY, playerX] = 'P';

while (true)
{
    // Отрисовка карты
    for(int v = 0; v < height; v++)
    {
        for(int p = 0; p < width; p++)
        {
            Console.Write(map[v, p]);
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Собрано предметов: {collectedItems}/{itemsCount}");
    

    // Ввод направления
    Console.WriteLine("Введите направление (w, a, s, d):");
    char direction = Console.ReadKey().KeyChar;
    Console.WriteLine();

    // Расчет новой позиции 
    int newX = playerX;
    int newY = playerY;
    switch (direction)
    {
        case 'w': newY--; break;
        case 's': newY++; break;
        case 'a': newX--; break;
        case 'd': newX++; break;
        default:
            Console.WriteLine("Неверное направление. Используйте w, a, s, d.");
            continue; // Переходим к следующей итерации цикла
    }

    // Проверка на столкновения и перемещение
    if (map[newY, newX] != '#')
    {
        if (map[newY, newX] == 'I')
        {
            collectedItems++;
        }
        map[playerY, playerX] = '.';
        playerX = newX;
        playerY = newY;
        map[playerY, playerX] = 'P';

        if (collectedItems == itemsCount)
        {
            Console.WriteLine("Игра окончена!");
            break;
        }
    }
    else
    {
        Console.WriteLine("Вы не можете двигаться в этом направлении.");
    }
}