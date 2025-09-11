using System;
using System.Threading;

//class Car
//{
//    private int position;
//    private readonly object lockObject = new object();
//    public string Name;

//    public Car(string name)
//    {
//        position = 0;
//        Name = name;
//    }

//    public void Move()
//    {
//        Thread.Sleep(1);
//        lock (lockObject)
//        {
//            position++;
//            if (this.Name == "Mercedes") Console.WriteLine($"{Name} на позиции: {position}");
//            else Console.WriteLine($"          {Name} на позиции: {position}");
//        }
//    }


//    public int GetPosition()
//    {
//        lock (lockObject)
//        {
//            return position;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car1 = new Car("Mercedes");
//        Car car2 = new Car("Ferrari");

//        Thread thread1 = new Thread(car1.Move);
//        Thread thread2 = new Thread(car2.Move);

//        thread1.Start();
//        thread2.Start();

//        while (car1.GetPosition() < 100 & car2.GetPosition() < 100)
//        {
//            Thread.Sleep(1);
//            car1.Move();
//            car2.Move();
//        }

//        thread1.Join();
//        thread2.Join();

//        Console.WriteLine("Гонка окончена!");
//    }
//}


//▎1.Что такое многозадачность, и для чего она используется в программировании?

//Многозадачность — это способность операционной системы или программы выполнять несколько задач одновременно. В контексте программирования многозадачность позволяет приложениям выполнять параллельные операции, что может значительно увеличить производительность и отзывчивость.

//Используется для:
//• Улучшения производительности: Позволяет использовать ресурсы процессора более эффективно.
//• Повышения отзывчивости: Например, в графических приложениях можно выполнять длительные операции в фоновом режиме, не блокируя пользовательский интерфейс.
//• Обработки событий: В сетевых приложениях многозадачность позволяет обрабатывать несколько соединений одновременно.

//▎2. Как создать поток в C#?

//В C# поток можно создать с помощью класса Thread. Пример создания и запуска потока:

//class Program
//{
//    static void Main()
//    {
//        Thread thread = new Thread(new ThreadStart(MyMethod));
//        thread.Start(); // Запуск потока
//    }

//    static void MyMethod()
//    {
//        Console.WriteLine("Это выполняется в новом потоке.");
//    }
//}

//Thread thread = new Thread(() => Console.WriteLine("Это выполняется в новом потоке."));
//thread.Start();


//▎3.Что такое безопасная многозадачность, и почему она важна?

//Безопасная многозадачность — это концепция, которая обеспечивает корректное выполнение программы при одновременном доступе нескольких потоков к общим ресурсам. Она важна, потому что без должной синхронизации может произойти "гонка данных", когда два или более потока пытаются изменить один и тот же ресурс одновременно, что может привести к непредсказуемым результатам и ошибкам.

//▎4. Какие методы и свойства класса Thread используются для работы с потоками?

//Некоторые основные методы и свойства класса Thread:

//• Методы:
//  – Start(): Запускает поток.
//  – Join(): Блокирует вызывающий поток до завершения указанного потока.
//  – Sleep(int milliseconds): Приостанавливает выполнение текущего потока на указанное количество миллисекунд.

//• Свойства:
//  – IsAlive: Указывает, выполняется ли поток в данный момент.
//  – ManagedThreadId: Возвращает уникальный идентификатор потока.
//  – Name: Имя потока(можно установить для удобства отладки).
//  – Priority: Устанавливает или получает приоритет потока.


//Объектно ориентированное 
//программирование на C# 
//Тема 26. Домашнее задание. 
//Демонстрация организации потоков 
//Падающие объекты. 
//Реализуйте анимацию падающих объектов, например, снежинок или 
//мячей. Каждый объект - это отдельный поток. Игрок может управлять 
//одним из объектов, а остальные двигаются независимо.



//class FallingObject
//{
//    private string symbol;
//    private int positionX; 
//    private int positionY; 
//    private Thread thread;
//    private Thread thread2;
//    private Thread thread3;
//    private Thread inputThread; 
//    public bool isActive;
//    public Random randomm;

//    public FallingObject(string symbol)
//    {
//        this.symbol = symbol;
//        this.positionX = 5; 
//        this.positionY = 0; 
//        this.isActive = true;
//        thread = new Thread(Fall);
//        inputThread = new Thread(HandleInput);
//    }

//    public void Start()
//    {
//        inputThread.Start(); 
//        thread.Start();  
//    }

//public void FallForOtherSnowflakes()
//{
//    while (isActive)
//    {
//        Console.SetCursorPosition(random.Next(10, 50), positionY);
//        Console.Write(symbol);
//        Thread.Sleep(1000);
//        Console.SetCursorPosition(random.Next(10, 50), positionY);
//        Console.Write(" ");
//        positionY++;

//        if (positionY >= Console.WindowHeight)
//        {
//            isActive = false;
//        }
//    }
//}

//    public void Fall()
//    {
//        while (isActive)
//        {
//            Console.SetCursorPosition(positionX, positionY);
//            Console.Write(symbol);
//            Thread.Sleep(1000);
//            Console.SetCursorPosition(positionX, positionY);
//            Console.Write(" ");
//            positionY++;

//            if (positionY >= Console.WindowHeight)
//            {
//                isActive = false;
//            }
//        }
//    }

//    private void HandleInput()
//    {
//        while (isActive)
//        {
//            ConsoleKey key = Console.ReadKey(true).Key;
//            switch (key)
//            {
//                case ConsoleKey.A:
//                    MoveLeft();
//                    break;
//                case ConsoleKey.D:
//                    MoveRight();
//                    break;
//            }
//        }
//    }

//    private void MoveLeft()
//    {
//        if (positionX > 0)
//        {
//            Console.SetCursorPosition(positionX, positionY);
//            Console.Write(" "); 
//            positionX--; 
//        }
//    }

//    private void MoveRight()
//    {
//        if (positionX < Console.WindowWidth ) 
//        {
//            Console.SetCursorPosition(positionX, positionY);
//            Console.Write(" "); 
//            positionX++; 
//        }
//    }

//    public void Stop()
//    {
//        isActive = false;
//        inputThread.Join(); 
//        thread.Join(); 
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var fallingObject = new FallingObject("*"); 
//        fallingObject.Start();
//        Console.CursorVisible = false;
//        if (!fallingObject.isActive)
//        {
//            fallingObject.Stop();
//            Console.SetCursorPosition(0, Console.WindowHeight);
//            Console.ReadKey(); 
//        }

//    Random random = new Random();
//    int positionSnowflakes = 0;
//    void FallForOtherSnowflakes()
//        {
//            while (fallingObject.isActive)
//            {
//                Console.SetCursorPosition(random.Next(10, 50), positionSnowflakes);
//                Console.Write("*");
//                Thread.Sleep(1000);
//                Console.SetCursorPosition(random.Next(10, 50), positionSnowflakes);
//                //Console.Write(" ");
//                Console.Clear();
//                positionSnowflakes++;

//                if (positionSnowflakes >= Console.WindowHeight)
//                {
//                    fallingObject.isActive = false;
//                }
//            }
//        }
//    List<Thread> threads = new List<Thread>();
//        for (int i = 0;  i < 6; i++)
//        {
//            threads.Add(new Thread(() => FallForOtherSnowflakes()));
//        }

//        foreach (var thread in threads)
//        {
//            thread.Start();
//            thread.Join();
//        }
//    }
//}

//Объектно ориентированное 
//программирование на C# 
//Тема 26. Домашнее задание. 
//Введение в многопоточность 
//Задание: Многозадачный счетчик 
//Пояснение к выполнению: 
//Это задание предполагает создание простого многозадачного приложения 
//на C#. 
//Вам нужно будет создать два потока: один для увеличения счетчика, а 
//другой для уменьшения его значения. 
//Основная цель - добиться параллельной работы этих потоков и обеспечить 
//безопасное обновление общего ресурса, а именно, счетчика. 
//Создайте класс счетчика, который будет представлять общий ресурс для 
//обоих потоков. Этот класс должен содержать методы для увеличения и 
//уменьшения значения счетчика, а также метод для получения текущего 
//значения. 
//Создайте два потока: один для увеличения счетчика и один для 
//уменьшения. 
//В методах каждого потока вызывайте методы счетчика для обновления 
//значения. 
//Обеспечьте синхронизацию доступа к счетчику так, чтобы потоки не могли 
//перезаписать его значение одновременно. 
//Выведите текущее значение счетчика на экран в каждом потоке. 
//Запустите оба потока и следите за изменениями счетчика.


//class Counter
//{
//    private int _count;
//    private readonly object _lock = new object();

//    public void Increment()
//    {
//        lock (_lock)
//        {
//            _count++;
//            Console.WriteLine($"Увеличение: {_count}");
//        }
//    }

//    public void Decrement()
//    {
//        lock (_lock)
//        {
//            _count--;
//            Console.WriteLine($"Уменьшение: {_count}");
//        }
//    }

//    public int GetValue()
//    {
//        lock (_lock)
//        {
//            return _count;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Counter counter = new Counter();

//        Thread incrementThread = new Thread(() =>
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                counter.Increment();
//                Thread.Sleep(100);
//            }
//        });

//        Thread decrementThread = new Thread(() =>
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                counter.Decrement();
//                Thread.Sleep(150);
//            }
//        });

//        incrementThread.Start();
//        decrementThread.Start();

//        incrementThread.Join();
//        decrementThread.Join();

//        Console.WriteLine($"Конечное значение счетчика: {counter.GetValue()}");
//    }
//}




class Program
{
    static void Main(string[] args)
    {
        const int numThreads = 5;
        Thread[] threads = new Thread[numThreads];
        FileWriter fileWriter = new FileWriter("Z:\\Gaziev\\table.txt");

        for (int i = 0; i < numThreads; i++)
        {
            threads[i] = new Thread(() => fileWriter.WriteToFile($"Запись от потока {i + 1}"));
            threads[i].Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Все записи завершены.");
    }
}

class FileWriter
{
    private readonly string _filePath;
    private readonly Mutex _mutex;

    public FileWriter(string filePath)
    {
        _filePath = filePath;
        _mutex = new Mutex();
    }

    public void WriteToFile(string message)
    {
        _mutex.WaitOne();
        try
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"                        {DateTime.Now}: {message}");
            }
        }
        finally
        {
            _mutex.ReleaseMutex();
        }
    }
}


namespace MutexChangeFile
{
    internal class Program
    {
        private const string MutexName = "Global\\MyUniqueFileLock";
        static void Main(string[] args)
        {
            var fileMutex = new Mutex(false, MutexName);

            for (int i = 0; i < 1000; i++)
            {
                fileMutex.WaitOne();
                File.AppendAllText(@"C:\\Users\\Student\\Desktop\\Даниил Ванеев\\txts\\testMutex.txt", 
                    $"Hello From MutexChangeFile - {i}\n");
                Thread.Sleep(10);
                fileMutex.ReleaseMutex();
            }
        }
    }
}


//Объектно ориентированное 
//программирование на C# 
//Тема 26. Практика. Tasks. Async Await. 
//Вычисление суммы простых чисел. 
//Создайте асинхронный метод, который будет вычислять сумму всех 
//простых чисел в заданном диапазоне. Каждое простое число можно 
//проверить с небольшой задержкой для имитации вычислительной 
//нагрузки. 
//В главном потоке запустите асинхронный метод и ожидайте его 
//завершения. Во время ожидания выведите текущее количество секунд с 
//задержкой от 1 до 10. 
//Поиск наибольшего общего делителя (НОД). 
//Создайте асинхронный метод, который будет вычислять наибольший 
//общий делитель (НОД) двух чисел. Этот метод может использовать 
//алгоритм Евклида для нахождения НОД. В каждой итерации алгоритма 
//можно добавить небольшую задержку для имитации вычислительной 
//нагрузки. В главном потоке запустите асинхронный метод для нахождения 
//НОД двух чисел и ожидайте его завершения. Во время ожидания выводите 
//текущее количество секунд с задержкой от 1 до 10.



//Объектно ориентированное 
//программирование на C# 
//Тема 26. Домашнее задание. Task. 
//Задача. 
//Создайте 4 метода. 
//Первый: 
//Принимает два параметра и возвращает сумму 
//Второй: 
//Выводит текст на консоль: 
//“На далекой планете в галактике Гиперион, где небеса были 
//разукрашены яркими звездами и лазурными небесами, жили странные 
//существа, известные как блоглорпы. Блоглорпы были маленькими,
//пушистыми созданиями с шестиугольными глазами и тройными 
//хвостами. Их домами были деревья, выращенные из кристаллов, и они 
//питались музыкой, которую производили цветы, растущие на дне их 
//океанов. Вечными друзьями блоглорпов были музыкальные киты,
//которые пели им мелодии о магии вселенной и тайнах времени.” 
//Третий: 
//Выводит факториал числа 9 
//Четвертый: 
//Записывает текст, переданный в параметре, в текстовый файл: 
//“Каждый день на планете Гиперион был особенным для блоглорпов. Они 
//проводили свои утренние ритуалы, слушая мелодии, которые 
//цветы-композиторы создавали для них на дне океанов. Каждый аккорд и 
//нота наполняли воздух магией и вдохновением. 
//Однако, однажды, вечером, когда блоглорпы собрались вокруг своих 
//деревьев-домов, они заметили нечто необычное - на небе появилась 
//звезда, которую они никогда раньше не видели. Она сверкала 
//ослепительно и меняла цвета от синего до зеленого, создавая 
//потрясающее световое шоу. 
//Блоглорпы ощутили, что это было знаком судьбы, и отправились в 
//путь к источнику этой новой звезды. Во время своего путешествия они 
//встретили музыкальных китов, которые сообщили им, что эта звезда - 
//ключ к магии вселенной и тайнам времени. Она предоставляла 
//уникальную возможность путешествия во времени и пространстве. 
//Блоглорпы решили использовать этот дар мудро и с благоразумием. 
//Они отправились в путешествие сквозь временной вихрь и открыли 
//перед собой несметные возможности и приключения. Они исследовали 
//прошлое и будущее, встречали разные цивилизации и учились у мудрых 
//старейшин разных эпох. 
//Но всегда, в конце каждого своего путешествия, блоглорпы 
//возвращались домой, к своим деревьям из кристаллов и 
//цветам-композиторам, чтобы поделиться своими удивительными 
//историями и мелодиями с музыкальными китами. 
//Так продолжалась жизнь блоглорпов на Гиперионе, где каждый день был 
//новым приключением, а магия вселенной и тайны времени оставались 
//их вечными спутниками.” 
//Все эти методы должны выполняться параллельно, но так как у нас один 
//из методов должен возвращать результат, основной поток придется 
//останавливать, чтобы получить его, передать в переменную и вывести на 
//экран.




//Объектно ориентированное 
//программирование на C# 
//Тема 26. Домашнее задание. Tasks. Async Await 
//Создайте простой асинхронный метод, результат выполнения которого 
//ожидается во вторичном потоке. 
//К примеру, пусть это будет простой метод, возвращающий факториал 
//переданного числа 
//Так как факториал считается в цикле, притормозите каждую итерацию 
//цикла на 250мс 
//Результат выводить во вторичном потоке 
//В главном потоке, в цикле выводить секунды с задержкой от 1 до 10.


public abstract class Animal
{
    public string Class;
    public string Subclass;
    public string Kingdom;
    public string Type;
    public string HabitatArea;
    public DateTime OpeningDate;

    public Animal(string @class, string subclass, string kingdom, string type, string habitatArea, DateTime openingDate)
    {
        Class = @class;
        Subclass = subclass;
        Kingdom = kingdom;
        Type = type;
        HabitatArea = habitatArea;
        OpeningDate = openingDate;
    }
}