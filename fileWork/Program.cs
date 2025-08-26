////Console.WriteLine("Введите свое имя и фамилию: ");
////string nameSurname = Console.ReadLine();
////string path = $"Y:\\Gaziev\\{nameSurname}.txt";

////if (File.Exists(path))
////{
////    Console.WriteLine("Здравствуйте");
////}
////else
////{
////    Console.WriteLine("Введите свои данные: ");
////    string userInfo = nameSurname + "\n" + Console.ReadLine();

////    File.WriteAllText(path, userInfo);
////}
int a = 10 + 5;

////2
////Console.WriteLine("Введите ваш файл со списком покупок: ");
////string nameFile = Console.ReadLine();
////string path = $"Y:\\Gaziev\\{nameFile}.txt";
////if (File.Exists(path))
////{
////    string[] lines = File.ReadAllLines(path);
////    for (int i = 0; i < lines.Length; i++)
////    {
////        Console.WriteLine(lines[i]);
////    }
////}
////else
////{
////    Console.WriteLine("Тогда создадим свой файл со списком продуктов: ");
////    string[] content = new string[3]
////    {
////        "1.bread",
////        "2.butter",
////        "3.milk"
////    };

////    File.WriteAllLines(path, content);
////}

////3
////string path2 = "Y:\\Gaziev\\quotes.txt";
////if (!File.Exists(path2))
////{
////    Console.WriteLine("Файл с цитатами не найден.");
////}

////string[] quotes = File.ReadAllLines(path2);

////// Проверка на наличие цитат в файле
////if (quotes.Length == 0)
////{
////    Console.WriteLine("Файл с цитатами пуст. Добавьте цитаты в файл.");
////}
////// Выбор случайной цитаты
////Random random = new Random();
////int randomIndex = random.Next(quotes.Length);
////string randomQuote = quotes[randomIndex];

////// Вывод цитаты
////Console.WriteLine($"Цитата дня: {randomQuote}");


////4
////Console.WriteLine("Введите сообщение, которое хотите зашифровать: ");
////string coo = Console.ReadLine();
////string reversed = new string(coo.Reverse().ToArray());


//////char[] charArray = coo.ToCharArray();
//////for(int i = 0; i < charArray.Length; i++)
//////{
//////    char temp = charArray[i];
//////    charArray[i] = charArray[coo.Length -i-1];
//////    charArray[coo.Length -i -1] = temp;
//////    string reversed2 = new string(charArray);
//////    Console.WriteLine(reversed2);
//////}

////string pathForShifrov = "Y:\\Gaziev\\taras.txt";
////File.WriteAllText(pathForShifrov, reversed);
//////Console.WriteLine(reversed);
////string[] lines = File.ReadAllLines(pathForShifrov);
////for (int i = 0; i < lines.Length; i++)
////{
////    Console.WriteLine(lines[i]);
////}

////6
////string path = "Y:\\Gaziev\\gvgv.txt";
////while (true)
////{
////    if (!File.Exists(path))
////    {
////        Console.WriteLine("Файл не найден");
////        break;
////    }
////    else
////    {
////        Console.WriteLine("Содержимое файла: ");
////        string[] lines2 = File.ReadAllLines(path);
////        for(int i = 0; i < lines2.Length; i++)
////        {
////            Console.WriteLine(lines2[i]);
////        }
////        Console.WriteLine("Введите задачу, которую хотите сохранить в файл(если хотите выйти, введите exit): ");
////        string task = Console.ReadLine();
////        if (task.ToLower() == "exit")
////        {
////            break;
////        }
////        File.AppendAllText(path, ", " + task);
////    }
////}

////7
//string pathToContactBook = "Y:\\Gaziev\\Contact_book.txt";
//while (true)
//{
//    if (!File.Exists(pathToContactBook))
//    {
//        Console.WriteLine("Файл не найден");
//    }
//    else
//    {

//        Console.WriteLine("Контакты в файле: ");
//        string[] lines2 = File.ReadAllLines(pathToContactBook);
//        for (int i = 0; i < lines2.Length; i++)
//        {
//            Console.WriteLine(lines2[i]);
//        }
//        Console.WriteLine("Введите имя контактa, который хотите сохранить в файл с контактами(если хотите выйти, введите exit): ");
//        string newNameOfContact = Console.ReadLine();
//        if (newNameOfContact.ToLower() == "exit")
//        {
//            break;
//        }
//        File.AppendAllText(pathToContactBook, newNameOfContact);
//        Console.WriteLine("Введите номер для этого контакта: ");
//        string numberOfContact = Console.ReadLine();
//        File.AppendAllText(pathToContactBook, " - " + numberOfContact + "." + Environment.NewLine);
//    }
//}


//1
List<string> listNames = new List<string>()
{ };
List<string> listNumber = new List<string>();
{ };
string path = "Y:\\Gaziev\\Contact_book.txt";

while (true)
{
    Console.WriteLine("Введите опцию, которой хотите" +
        " воспользоваться(1 - добавления, 2 - удаление, 3 - поиск, 4 - переименование," +
        " 5 - Сохранить в файл, 6 - Посмотреть все контакты или e, если хотите выйти): ");
    char choose = Console.ReadKey().KeyChar;
    switch (choose)
    {
        case '1':
            AddContact();
            break;
        case '2':
            RemoveContact();
            break;
        case '3':
            SearchContact();
            break;
        case '4':
            RenameContact();
            break;
        case '5':
            SaveToFile();
            break;
        case '6':
            ShowContacts();
            break;
        case 'E' or 'e':
            Console.WriteLine("Выход...");
            return;
        default:
            Console.WriteLine("Неверный ввод. Пожалуйста, повторите попытку.");
            break;
    }

    for (int i = 0; i < listNames.Count; i++)
    {
        Console.WriteLine($"{listNames[i]} : {listNumber[i]}");
    }
}

void AddContact()
{

    Console.WriteLine("Введите имя контактa, который хотите сохранить: ");
    string newNameOfContact = Console.ReadLine();
    Console.WriteLine("Введите номер для этого контакта: ");
    string number = Console.ReadLine();
    listNames.Add(newNameOfContact);
    listNumber.Add(number);
}
void RemoveContact()
{
    Console.WriteLine("Введите имя контакта, который вы хотите удалить: ");
    string contactForRemove = Console.ReadLine();
    int index = listNames.IndexOf(contactForRemove);
    listNames.Remove(contactForRemove);
    listNumber.RemoveAt(index);
    Console.WriteLine("Deleted!");
}

void SearchContact()
{
    Console.WriteLine("Введите имя контакта, который хотите найти: ");
    string search = Console.ReadLine();
    if (!listNames.Contains(search))
    {
        Console.WriteLine("not finded");
    }
    int index = listNames.IndexOf(search);
    Console.WriteLine($"{listNames[index]} : {listNumber[index]}");
}

void RenameContact()
{
    Console.WriteLine("Введите имя контакта, который хотите переименовать: ");
    string oldNameOfContact = Console.ReadLine();
    if (!listNames.Contains(oldNameOfContact))
    {
        Console.WriteLine("not finded");
    }
    int index = listNames.IndexOf(oldNameOfContact);
    Console.WriteLine("Введите новое имя для контакта: ");
    string newNameOfContact = Console.ReadLine();
    listNames[index] = newNameOfContact;
}

void SaveToFile()
{
    for (int i = 0; i < listNames.Count; i++)
    {
        string stringa = $"{listNames[i]} - {listNumber[i]}";
        File.AppendAllText(path, stringa + Environment.NewLine);
    }
}

void ShowContacts()
{
    string[] lines = File.ReadAllLines(path);
    for (int i = 0; i < lines.Length; i++)
    {
        Console.WriteLine(lines[i]);
    }
}






















////8
//string path3 = "Y:\\Gaziev\\Game_record.txt";
//while (true)
//{
//    if (!File.Exists(path3))
//    {
//        Console.WriteLine("Файл с игровым рекордом не найден");
//    }
//    Console.WriteLine("Текущий игровой рекорд: ");
//    string[] lines2 = File.ReadAllLines(path3);
//    string record = "";
//    for (int i = 0; i < lines2.Length; i++)
//    {
//        Console.WriteLine(lines2[i]);
//        record = lines2[i];
//    }
//    int recordd = int.Parse(record);
//    Console.WriteLine("Введите результат своей последней попытки: ");
//    string abh = Console.ReadLine();
//    int newResult = int.Parse(abh);
//    if (newResult < recordd)
//    {
//        Console.WriteLine("Рекорд не обновлен, иди играй, пень");
//    }
//    else
//    {
//        Console.WriteLine($"Ты обновил свой рекорд, теперь он: {newResult}");
//        string abs = newResult.ToString();
//        File.WriteAllText(path3, abs);
//        break;
//    }
//}


int[] array = new int[5]
{
    3, 5,6,7,8
};
List<int> list = array.ToList();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}