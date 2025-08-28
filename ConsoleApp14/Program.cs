using System;
using System.Threading;

class Car
{
    private int position;
    private readonly object lockObject = new object();

    public Car()
    {
        position = 0;
    }

    public void Move()
    {
        while (position < 10) 
        {
            Thread.Sleep(1000); 
            lock (lockObject)
            {
                position++;
                Console.WriteLine($"Машинка на позиции: {position}");
            }
        }
    }

    public int GetPosition()
    {
        lock (lockObject)
        {
            return position;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Car car2 = new Car();

        Thread thread1 = new Thread(car1.Move);
        Thread thread2 = new Thread(car2.Move);

        thread1.Start();
        thread2.Start();

        thread1.Join(); 
        thread2.Join(); 

        Console.WriteLine("Гонка окончена!");
    }
}

