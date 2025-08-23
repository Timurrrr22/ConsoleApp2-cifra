//Пример: 23 / 16, 32 / 8, 11110 / 2.  14

//Решение: переведём все числа в десятичную систему счисления:

//23 / 16 = 35 / 10. 14
//32 / 8 = 26 / 10. 14
//11110 / 2 = 30 / 10.  14
//Таким образом, наибольшим среди этих трёх чисел является число 35.  14

//Console.WriteLine(Convert.ToInt32("32", 8));

//int F(string x, int i)
//{
//    return Convert.ToInt32(x, i);
//}
//Console.WriteLine(F("2F", 16));
//Console.WriteLine(F("1111011", 2));

Console.WriteLine(Convert.ToInt32("55", 16));
Console.WriteLine(Convert.ToInt32("222", 8));
Console.WriteLine(Convert.ToInt32("1111", 2));