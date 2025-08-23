using System;
using System.Collections.Generic;

public class DetectiveGame
{
    // Размер особняка
    const int MansionSize = 5;

    // Типы комнат
    const int Empty = 0;
    const int Clue = 1;
    const int Locked = 2;
    const int Puzzle = 3;
    const int Final = 4;


    static int[,] mansion = new int[MansionSize, MansionSize];
    static List<string> clues = new List<string>();
    static bool hasKey = false;
    static int playerX, playerY;


    // Инициализация особняка (пример)
    static void InitializeMansion()
    {
        // 0 - пусто, 1 - улика, 2 - заперто, 3 - загадка, 4 - финал
        mansion = new int[,] {
            {Empty, Clue, Empty, Empty, Empty},
            {Empty, Locked, Empty, Puzzle, Empty},
            {Empty, Empty, Empty, Empty, Empty},
            {Clue, Empty, Empty, Empty, Final},
            {Empty, Empty, Empty, Clue, Empty}
        };

        playerX = 0;
        playerY = 0;
    }


    // Отображение особняка
    static void DisplayMansion()
    {
        for (int y = 0; y < MansionSize; y++)
        {
            for (int x = 0; x < MansionSize; x++)
            {
                if (x == playerX && y == playerY)
                    Console.Write("P "); // Игрок
                else if (mansion[y, x] == Locked)
                    Console.Write("L "); // Заперто
                else
                    Console.Write(". "); // Другие комнаты
            }
            Console.WriteLine();
        }
    }


    // Перемещение игрока
    static void MovePlayer(char move)
    {
        int nextX = playerX, nextY = playerY;

        switch (move)
        {
            case 'w': nextY--; break;
            case 's': nextY++; break;
            case 'a': nextX--; break;
            case 'd': nextX++; break;
        }

        if (nextX >= 0 && nextX < MansionSize && nextY >= 0 && nextY < MansionSize)
        {
            if (mansion[nextY, nextX] == Locked && !hasKey)
            {
                Console.WriteLine("Дверь заперта! Нужен ключ.");
            }
            else
            {
                playerX = nextX;
                playerY = nextY;
            }
        }
        else
        {
            Console.WriteLine("Нельзя выйти за пределы особняка!");
        }
    }


    // Взаимодействие с комнатой
    static void InteractWithRoom()
    {
        switch (mansion[playerY, playerX])
        {
            case Clue:
                Console.WriteLine("Вы нашли улику! Добавить в инвентарь? (y/n)");
                if (Console.ReadKey().KeyChar == 'y')
                {
                    clues.Add("Улика " + clues.Count); // Замените на реальные улики
                    Console.WriteLine("\nУлика добавлена!");
                }
                mansion[playerY, playerX] = Empty; // Улика забрана
                break;
            case Puzzle:
                Console.WriteLine("Вы столкнулись с загадкой! (Пока что пропускаем)");
                hasKey = true; // Замените на реальную загадку
                mansion[playerY, playerX] = Empty;
                break;
            case Final:
                if (clues.Count >= 3)
                {
                    Console.WriteLine("Вы собрали достаточно улик! Тайна раскрыта!");
                }
                else
                {
                    Console.WriteLine("Недостаточно улик! Продолжайте поиски.");
                }
                break;
        }
    }


    public static void Main(string[] args)
    {
        InitializeMansion();

        while (true)
        {
            DisplayMansion();
            Console.WriteLine("Куда идти? (w/a/s/d)");

            char move = Console.ReadKey().KeyChar;
            Console.WriteLine();

            MovePlayer(move);
            InteractWithRoom();

            Console.WriteLine("Улики: " + string.Join(", ", clues));
            Console.WriteLine();
        }
    }
}