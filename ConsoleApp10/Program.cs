int width = 30;
int height = 15;
char[,] map = new char[height, width];
int playerX = 1;
int playerY = 1;

int itemsCount = 0;
int collectedItems = 0;

int enemiesCount = 0;
int defeatedEnemies = 0;

int boostersCount = 0;
int collectedBoosters = 0;

Random random = new Random();
int enemieX = 1;
int enemieY = 1;


// Генерация карты
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (i == 0 || i == 14 || j == 0 || j == 29)
        {
            map[i, j] = '#';
        }
        else
        {
            if (random.Next(13) == 0 && (i != playerY || j != playerX))
            {
                map[i, j] = 'I';
                itemsCount++;
            }
            else
            {
                map[i, j] = '.';
            }
            if (random.Next(80) == 0 && (i != playerY || j != playerX) && map[i, j] != 'I')
            {
                map[i, j] = '@'; //враги
                enemiesCount++;
            }
            if (random.Next(10) == 0 && (i != playerY || j != playerX) && map[i, j] != 'I' && map[i, j] != '@' && map[i, j] != '#')
            {
                map[i, j] = 'U'; //усилители
                boostersCount++;
            }
        }
    }
}

map[playerY, playerX] = 'P';

while (true)
{
    // Отрисовка карты
    for (int v = 0; v < height; v++)
    {
        for (int p = 0; p < width; p++)
        {
            Console.Write(map[v, p]);
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Собрано предметов: {collectedItems}/{itemsCount}");
    Console.WriteLine($"Усилителей на данный момент: {collectedBoosters}/{boostersCount}");
    Console.WriteLine($"Врагов повержено:{defeatedEnemies}/{enemiesCount}");

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (map[i, j] == '@')
            {
                enemieY = i; 
                enemieX = j;
            }
        }
    }

    // Расчет новой позиции врагов
    int newEnemieY = enemieY;
    int newEnemieX = enemieX;

    if (enemiesCount != defeatedEnemies)
    {   
        int choice = random.Next(0, 5);
        switch (choice)
        {
            case 1: newEnemieY--; break;
            case 2: newEnemieY++; break;
            case 3: newEnemieX--; break;
            case 4: newEnemieX++; break;
        }

        if (map[newEnemieY, newEnemieX] != '#' && map[newEnemieY, newEnemieX] != 'I' && map[newEnemieY, newEnemieX] != 'U'
            && map[newEnemieY, newEnemieX] != 'P')
        {
            map[enemieY, enemieX] = '.';
            enemieY = newEnemieY;
            enemieX = newEnemieX;
            map[enemieY, enemieX] = '@';
        }
    }

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
        else if (map[newY, newX] == 'U')
        {
            collectedBoosters++;
        }
        else if (map[newY, newX] == '@' && collectedBoosters >= 3)
        {
            defeatedEnemies++;
            collectedBoosters = collectedBoosters - 3;
        }
        else if (map[newY, newX] == '@' && collectedBoosters <= 3)
        {
            Console.WriteLine("Тебя убили, лошпед....");
            break;
        }
        map[playerY, playerX] = '.';
        playerX = newX;
        playerY = newY;
        map[playerY, playerX] = 'P';

        if (collectedItems == itemsCount && defeatedEnemies == enemiesCount)
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
