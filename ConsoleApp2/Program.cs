const int size = 10;
const char playerSymbol = 'P';

char[,] symbols = new char[size, size / 2];

int playerX = 0, playerY = 0;

for (int x = 0; x < symbols.GetLength(0); x++)
{
    for (int y = 0; y < symbols.GetLength(1); y++)
    {
        symbols[x, y] = 'a';
    }
}
symbols[playerX, playerY] = playerSymbol;


while (true)
{
    for (int y = 0; y < symbols.GetLength(1); y++)
    {
        string row = "";
        for (int x = 0; x < symbols.GetLength(0); x++)
        {
            row += symbols[x, y];
        }

        Console.WriteLine(row);
    }

    Console.WriteLine("1 - вверх\n2 - вниз\n3 - влево\n4 - вправо");
    string option = Console.ReadLine(); // Валидация

    symbols[playerX, playerY] = 'a';
    if (option == "1")
    {
        playerY += 1;
    }

    symbols[playerX, playerY] = playerSymbol;
}



namespace SpaceTest
{
    public class Test
    {
        public static void Hello()
        {
            Console.WriteLine("Hello!");
        }
    }
}