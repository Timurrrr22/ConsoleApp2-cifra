//3.Калькулятор с историей операций

//**Описание:**
//Создайте консольный калькулятор, поддерживающий базовые арифметические операции. Каждый расчёт сохраняется в историю, которую можно просмотреть или сохранить в файл.

//**Требования:**

//-Операции сложения, вычитания, умножения и деления.
//- Сохранение каждого вычисления (например, в виде строки «3 + 5 = 8») в список истории.
//- Возможность вывода истории и сохранения её в файл.
//- Разбиение логики на функции для ввода, выполнения операции, вывода результата, работы с историей.

//**Пример функций:**

//- `double PerformOperation(double a, double b, char op)` – вычисляет результат операции.
//- `void AddToHistory(string operation)` – добавляет запись в историю.
//- `void ShowHistory()` – выводит всю историю операций.
//- `void SaveHistoryToFile()` – сохраняет историю в файл.
//- `double GetOperand(string prompt)` – запрашивает ввод числа у пользователя.

//Console.WriteLine("Добро пожаловать в калькулятор с сохранением истории! Всё будет записываться в файл");
//while(true)
//{
//    Console.WriteLine("Введите операцию, которую хотите выполнить: " +
//        "1. Сложение. 2. Вычитание. 3. Умножение. 4. Деление");
//    string operation = Console.ReadLine();

//    DefineInputNumbers(out var number1, out var number2);
//    switch (operation)
//    {
//        case "1":
//            float resultOfSumm = Summ(number1, number2);
//            string stringaForSumm = $"{number1} + {number2} = {resultOfSumm}";
//            break;
//        case "2":
//            float resultOfSubstraction = Substraction(number1, number2);
//            string stringaForSubstraction = $"{number1} - {number2} = {resultOfSubstraction}";
//            break;
//        case "3":
//            float resultOfMultiplication = Substraction(number1, number2);
//            string stringaForMultiplication = $"{number1} * {number2} = {resultOfMultiplication}";
//            break;
//        case "4":
//            float resultOfDivision = Division(number1, number2);
//            string stringaForDivision = $"{number1} / {number2} = {resultOfDivision}";
//            break;

//    }
//}



//void DefineInputNumbers(out float number111, out float number222)
//{
//    Console.WriteLine("Введите первое число: ");
//    number111 = float.Parse(Console.ReadLine());
//    Console.WriteLine("Введите второе число: ");
//    number222 = float.Parse(Console.ReadLine());
//}
//float Summ(float number1, float number2)
//{
//    float result = number1 + number2;
//    return result;
//}
//float Substraction(float number1, float number2)
//{
//    return number1 - number2;
//}
//float Multiplication(float number1, float number2)
//{
//    return (number1 * number2);
//}
//float Division(float number1, float number2)
//{
//    return number1 / number2;
//}


