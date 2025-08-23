////1,2
//int rows = 3;
//int columns = 4;
//int[,] array = new int[rows, columns];
//Random random = new Random();
////Цикл для помещения двумерного массива рандомными числами
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        array[i, j] = random.Next(1, 10);
//    }
//}
////Цикл для вывода двумерного массива
//for (int y = 0; y < array.GetLength(1); y++)
//{
//    string row = "";
//    for (int x = 0; x < array.GetLength(0); x++)
//    {
//        row += array[x, y] + "\t";
//    }
//    Console.WriteLine(row);
//}
////Цикл для подсчета суммы элементов двумерного массива
//int sum = 0;
//for (int i = 0; i < rows; i++)
//{
//    for(int j = 0; j < columns;j++)
//    {
//        sum += array[i, j];
//    }
//}
////Цикл для подсчета произведения элементов двумерного массива
//int multiplication = 1;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        multiplication *= array[i, j];
//    }
//}
////Вывод результатов:
//Console.WriteLine($"Сумма элементов массива: {sum}");
//Console.WriteLine($"Произведение элементов массива: {multiplication}");


////3
//int rows2 = 3;
//int columns2 = 3;
//int[,] array2 = new int[rows, columns];
//Random random2 = new Random();
////Цикл для помещения двумерного массива рандомными числами
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns2; j++)
//    {
//        array2[i, j] = random2.Next(1, 10);
//    }
//}
//int rrow = array2.GetLength(0);
//int columnss = array2.GetLength(1);
////Цикл для вывода элементов двумерного массива по диагонали

//    for (int d = 0; d < rows + columnss - 1; d++)
//    {
//        int rowStart = Math.Max(0, d - columnss + 1);
//        int count = Math.Min(d, Math.Min(rrow - rowStart, columnss));
//        for (int j = 0; j < count; j++)
//        {
//            Console.Write(array[rowStart + j, d - rowStart - j] + " ");
//        }
//    }

////4
//string[,] contacts = new string[5, 3]
//{
//    {"Ivan", "123-4567", "ivan@mail.ru" },
//    {"Petr", "223-4887", "petya@mail.ru" },
//    {"Svetlana", "190-2267", "svetka@mail.ru" },
//    {"Maria", "786-9087", "mashka@mail.ru" },
//    {"Aleksey", "777-1234", "lyoha@mail.ru" },
//};
//Console.WriteLine("Телефонный справочник:");
//for(int i = 0; i < contacts.GetLength(0); i++)
//{
//    Console.WriteLine(contacts[i, 0]);
//    Console.WriteLine(contacts[i, 1]);
//    Console.WriteLine(contacts[i, 2]);
//}

////3
//int[,] origArr =
//{
//    {1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 },
//};
//int[,] transposedArr = new int[origArr.GetLength(1), origArr.GetLength(0)];
//for(int i = 0; i < origArr.GetLength(0); i++)
//{
//    for(int j = 0; j < origArr.GetLength(1); j++)
//    {
//        transposedArr[j, i] = origArr[i, j];
//    }
//}

////Вывод:
//for(int i = 0;i < transposedArr.GetLength(1);i++)
//{
//    for(int j = 0; j < transposedArr.GetLength(0);j++)
//    {
//        Console.Write(transposedArr[i, j]);
//    }
//}


int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
Random random = new Random();
//Цикл для помещения двумерного массива рандомными числами
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(1, 10);
    }
}
int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
}
int summ1 = 0;
float numberOfElementsInArray = 12f;
float srednee = sum / numberOfElementsInArray;
Console.WriteLine($"Среднее арифметическое всех элементов массива: {srednee}");
for(int i = 0;i < columns;i++)
{
    summ1 += array[0, i];
}
int summ2 = 0;
for (int i = 0; i < rows; i++)
{
    summ1 += array[0, i];
}
float srednee2 = summ1 / 4;
Console.WriteLine($":{srednee2}");

