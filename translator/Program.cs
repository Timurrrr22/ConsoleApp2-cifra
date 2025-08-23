//### 7. Словарь иностранных слов

//**Описание:**
//Приложение для изучения иностранного языка, где хранятся слова и их переводы.
//Пользователь может добавлять слова, проходить тест (визуально выбирая перевод), удалять слова и сохранять данные.

//**Требования:**

//-Два списка для слов и переводов.
//- Функции для добавления новой пары слово-перевод,
//удаления, показа всех пар, проведения теста, в котором программа задаёт слово и предлагает варианты перевода.
//- Возможность сохранения и загрузки данных из файла.

//**Пример функций:**

//- `void AddWord()` – добавляет новую пару слово-перевод.
//- `void RemoveWord()` – удаляет выбранную пару.
//- `void ShowDictionary()` – выводит все слова и переводы.
//- `void QuizUser()` – проводит тест, задавая вопросы и оценивая ответы.
//- `void SaveDictionaryToFile()` и `void LoadDictionaryFromFile()` – работа с файлом.

List<string> words = new List<string>();
List<string> translations = new List<string>();
Random random = new Random();
string path = "Y:\\Gaziev\\Dictionary.txt";
string pathToTable = "Y:\\Gaziev\\table.txt";
Console.WriteLine("Добро пожаловать в ваш личный словарь слов на английском языке!");
while  (true)
{
    Console.WriteLine("Введите цифру операции: \n" + 
        "1.Добавить новую пару\n" +
        "2.Удалить пару слов\n" +
        "3.Вывести весь словарь\n" +
        "4.Пройти тест на проверку ваших знаний\n" +
        "5.Cохранить весь словарь в файл\n" +
        "e - если хотите выйти из приложения");
    char choose = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (choose)
    {
        case '1':
            Console.WriteLine("Введите слово для записи его в словарь: ");
            string word = Console.ReadLine();
            Console.WriteLine("Введите перевод этого слова: ");
            string translate = Console.ReadLine();
            AddPairOfWords(word, translate);
            break;
        case '2':
            Console.WriteLine("Введите слово для удаления его пары из словаря: ");
            string wordForRemove = Console.ReadLine();
            RemovePairOfWords(wordForRemove);
            break;
        case '3':
            ShowDictionary();
            break;
        case '4':
            QuizUser();
            break;
        case '5':
            SaveDictionaryToFile();
            break;
        case 'E' or 'e':
            Console.WriteLine("Выход...");
            return;
        default:
            Console.WriteLine("Неверный ввод. Пожалуйста, повторите попытку.");
            break;
    }
}

void AddPairOfWords(string word, string translate)
{
    words.Add(word);
    translations.Add(translate);
}
void RemovePairOfWords(string word)
{
    int index = words.IndexOf(word);
    words.RemoveAt(index);
    translations.RemoveAt(index);
}
void ShowDictionary()
{
    //for (int i = 0; i < words.Count; i++)
    //{
    //    Console.WriteLine($"{words[i]} - {translations[i]}");
    //}
    string[] lines = File.ReadAllLines(path);
    for (int i = 0; i < lines.Length; i++)
    {
        Console.WriteLine(lines[i]);
    }
}
void QuizUser()
{
    int score = 0;
    for(int i = 0; i < 5;i++)
    {
        int rnd = random.Next(0, words.Count);
        Console.WriteLine($"Введите перевод для слова - {words[rnd]}: ");
        string answer = Console.ReadLine();
        if(answer.ToLower() == translations[rnd].ToLower())
        {
            Console.WriteLine("Верно!");
            score++;
        }
        else
        {
            Console.WriteLine($"Неверно! {translations[rnd]} - правильный ответ");
        }
    }
    Console.WriteLine($"Ваш результат: {score}/5");
}
void SaveDictionaryToFile()
{
    
    for (int i = 0; i < words.Count; i++)
    {
        string stringa = $"{words[i]} - {translations[i]}";
        File.AppendAllText(path, stringa + Environment.NewLine);
    }
    Console.WriteLine("Успешно!");
}