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



class FallingObject
{
    private string symbol;
    private int positionX; 
    private int positionY; 
    private Thread thread;
    private Thread thread2;
    private Thread thread3;
    private Thread inputThread; 
    public bool isActive;
    public Random randomm;

    public FallingObject(string symbol)
    {
        this.symbol = symbol;
        this.positionX = 5; 
        this.positionY = 0; 
        this.isActive = true;
        thread = new Thread(Fall);
        inputThread = new Thread(HandleInput);
    }

    public void Start()
    {
        inputThread.Start(); 
        thread.Start();  
    }

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

    public void Fall()
    {
        while (isActive)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(" ");
            positionY++;

            if (positionY >= Console.WindowHeight)
            {
                isActive = false;
            }
        }
    }

    private void HandleInput()
    {
        while (isActive)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.A:
                    MoveLeft();
                    break;
                case ConsoleKey.D:
                    MoveRight();
                    break;
            }
        }
    }

    private void MoveLeft()
    {
        if (positionX > 0)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(" "); 
            positionX--; 
        }
    }

    private void MoveRight()
    {
        if (positionX < Console.WindowWidth ) 
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(" "); 
            positionX++; 
        }
    }

    public void Stop()
    {
        isActive = false;
        inputThread.Join(); 
        thread.Join(); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fallingObject = new FallingObject("*"); 
        fallingObject.Start();
        Console.CursorVisible = false;
        if (!fallingObject.isActive)
        {
            fallingObject.Stop();
            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.ReadKey(); 
        }

    Random random = new Random();
    int positionSnowflakes = 0;
    void FallForOtherSnowflakes()
        {
            while (fallingObject.isActive)
            {
                Console.SetCursorPosition(random.Next(10, 50), positionSnowflakes);
                Console.Write("*");
                Thread.Sleep(1000);
                Console.SetCursorPosition(random.Next(10, 50), positionSnowflakes);
                //Console.Write(" ");
                Console.Clear();
                positionSnowflakes++;

                if (positionSnowflakes >= Console.WindowHeight)
                {
                    fallingObject.isActive = false;
                }
            }
        }
    List<Thread> threads = new List<Thread>();
        for (int i = 0;  i < 6; i++)
        {
            threads.Add(new Thread(() => FallForOtherSnowflakes()));
        }

        foreach (var thread in threads)
        {
            thread.Start();
            thread.Join();
        }
    }
}

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



