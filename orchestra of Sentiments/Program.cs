using System;
using System.Collections.Generic;
using System.Linq; // Для Enumerable.Repeat

// 1. Класс-контейнер Mood (Настроение)
public class Mood
{
    public string Name { get; }
    public double VolumeMultiplier { get; } // Множитель громкости (например, 1.5 для радости)
    public double TempoMultiplier { get; } // Множитель темпа (например, 1.8 для радости)

    public Mood(string name, double volumeMultiplier, double tempoMultiplier)
    {
        Name = name;
        VolumeMultiplier = volumeMultiplier;
        TempoMultiplier = tempoMultiplier;
    }

    // Предопределенные настроения (для удобства)
    public static Mood Joy { get; } = new Mood("Радость 😊", 1.5, 1.8);      // Громче, быстрее
    public static Mood Sadness { get; } = new Mood("Грусть 😢", 0.6, 0.5);    // Тише, медленнее
    public static Mood Anger { get; } = new Mood("Гнев 😡", 2.0, 1.2);     // Очень громко, чуть быстрее
    public static Mood Calmness { get; } = new Mood("Спокойствие ✨", 0.8, 0.7); // Чуть тише, медленнее

    public override string ToString()
    {
        return Name;
    }
}

// 2. Базовый класс Instrument (Инструмент) с виртуальным/абстрактным методом Draw() -> Play()
public abstract class Instrument
{
    public string Name { get; }
    protected int BaseVolume { get; } // Базовая громкость инструмента (для нормального настроения)
    protected int BaseTempo { get; } // Базовый темп инструмента (для нормального настроения)

    // Конструктор базового класса
    protected Instrument(string name, int baseVolume, int baseTempo)
    {
        Name = name;
        BaseVolume = baseVolume;
        BaseTempo = baseTempo;
    }

    // Метод Play, который будет вызываться для каждого инструмента.
    // Он рассчитывает фактические параметры и вызывает абстрактный метод GenerateSound.
    public void Play(Mood mood)
    {
        // Рассчитываем фактическую громкость и темп с учетом множителей настроения
        // Ограничиваем значения, чтобы они не выходили за разумные пределы
        int actualVolume = Math.Clamp((int)(BaseVolume * mood.VolumeMultiplier), 0, 100);
        int actualTempo = Math.Clamp((int)(BaseTempo * mood.TempoMultiplier), 0, 300); // Ограничим темп, например, до 300 уд/мин

        // Генерируем текстовое представление звука, используя логику конкретного инструмента
        string sound = GenerateSound(actualVolume, actualTempo);

        // Выводим результат в консоль
        Console.WriteLine($"{Name}: громкость {actualVolume}, темп {actualTempo} ➜ {sound}");
    }

    // Абстрактный метод для генерации текстового звука.
    // Каждый производный класс должен реализовать его по-своему.
    protected abstract string GenerateSound(int volume, int tempo);
}

// 3. Производный класс Guitar (Гитара)
public class Guitar : Instrument
{
    // Задаем базовые параметры для гитары при создании
    public Guitar(int baseVolume, int baseTempo) : base("Гитара", baseVolume, baseTempo) { }

    protected override string GenerateSound(int volume, int tempo)
    {
        // Логика генерации звука "брынь" в зависимости от громкости и темпа
        string baseSound = "брынь";
        if (volume > 80) baseSound = "БРЫНЬ!!!";
        else if (volume > 50) baseSound = "БРЫНЬ";
        else if (volume > 20) baseSound = "Брынь";
        // else: "брынь"

        // Количество повторений звука зависит от темпа
        int repetitions = Math.Clamp(tempo / 40, 1, 10); // Темп 40 -> 1 повторение, 80 -> 2, и т.д.

        return string.Join("-", Enumerable.Repeat(baseSound, repetitions)); // Соединяем повторения через дефис
    }
}

// 4. Производный класс Drum (Барабан)
public class Drum : Instrument
{
    public Drum(int baseVolume, int baseTempo) : base("Барабан", baseVolume, baseTempo) { }

    protected override string GenerateSound(int volume, int tempo)
    {
        // Логика генерации звука "бум" в зависимости от громкости и темпа
        string baseSound = "бум";
        if (volume > 85) baseSound = "БУМ!!!";
        else if (volume > 60) baseSound = "БУМ";
        else if (volume > 30) baseSound = "Бум";
        // else: "бум"

        // Количество повторений зависит от темпа
        int repetitions = Math.Clamp(tempo / 60, 1, 8); // Темп 60 -> 1 повторение, 120 -> 2, и т.д.

        return string.Join(" ", Enumerable.Repeat(baseSound, repetitions)); // Соединяем повторения через пробел
    }
}

// 5. Производный класс Flute (Флейта)
public class Flute : Instrument
{
    public Flute(int baseVolume, int baseTempo) : base("Флейта", baseVolume, baseTempo) { }

    protected override string GenerateSound(int volume, int tempo)
    {
        // Логика генерации звука "ву-ву"
        string baseSound = "ву";
        if (volume > 75) baseSound = "ВУ-ВУУУ";
        else if (volume > 45) baseSound = "Ву-Ву";
        // else: "ву-ву"

        int repetitions = Math.Clamp(tempo / 50, 1, 7);

        return string.Join("-", Enumerable.Repeat(baseSound, repetitions));
    }
}

// 6. Производный класс Bass (Бас)
public class Bass : Instrument
{
    public Bass(int baseVolume, int baseTempo) : base("Бас", baseVolume, baseTempo) { }

    protected override string GenerateSound(int volume, int tempo)
    {
        // Логика генерации звука "бум" (ниже, чем у барабана)
        string baseSound = "бом";
        if (volume > 70) baseSound = "БОМ!!!";
        else if (volume > 40) baseSound = "БОМ";
        else if (volume > 10) baseSound = "Бом";
        // else: "бом"

        int repetitions = Math.Clamp(tempo / 70, 1, 5); // Бас обычно медленнее

        return string.Join("..", Enumerable.Repeat(baseSound, repetitions)); // Соединяем через точки
    }
}

// 7. Производный класс Violin (Скрипка)
public class Violin : Instrument
{
    public Violin(int baseVolume, int baseTempo) : base("Скрипка", baseVolume, baseTempo) { }

    protected override string GenerateSound(int volume, int tempo)
    {
        // Логика генерации звука "вжииих"
        string baseSound = "вжииих";
        if (volume > 90) baseSound = "ВЖИИИИХХХХ!!!";
        else if (volume > 60) baseSound = "ВЖИИИХ";
        else if (volume > 30) baseSound = "Вжиих";
        // else: "вжииих"

        int repetitions = Math.Clamp(tempo / 35, 1, 12); // Скрипка может быть очень быстрой

        return string.Join("~", Enumerable.Repeat(baseSound, repetitions)); // Соединяем волной
    }
}


// 8. Класс Orchestra (Оркестр) - контейнер для инструментов
public class Orchestra
{
    private List<Instrument> _instruments = new List<Instrument>();

    // Метод для добавления инструмента в оркестр
    public void AddInstrument(Instrument instrument)
    {
        _instruments.Add(instrument);
    }

    // Метод для "игры" оркестра в заданном настроении
    public void Perform(Mood mood)
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // Для выделения заголовка настроения
        Console.WriteLine($"\n>>> Оркестр играет в настроении: {mood.Name} <<<");
        Console.ResetColor(); // Сброс цвета

        // Используем полиморфизм: вызываем метод Play для каждого объекта в списке
        // Фактическая реализация GenerateSound будет вызвана для каждого конкретного типа инструмента
        foreach (var instrument in _instruments)
        {
            instrument.Play(mood);
        }

        Console.WriteLine("----------------------------------------------");
    }
}

// 9. Основная программа для демонстрации
public class Program
{
    public static void Main(string[] args)
    {
        // Создаем оркестр
        Orchestra myOrchestra = new Orchestra();

        // Добавляем инструменты в оркестр с их базовыми параметрами
        // (Эти базовые параметры можно настроить для каждого инструмента)
        myOrchestra.AddInstrument(new Guitar(baseVolume: 60, baseTempo: 120));
        myOrchestra.AddInstrument(new Drum(baseVolume: 70, baseTempo: 100));
        myOrchestra.AddInstrument(new Flute(baseVolume: 50, baseTempo: 140));
        myOrchestra.AddInstrument(new Bass(baseVolume: 75, baseTempo: 80));
        myOrchestra.AddInstrument(new Violin(baseVolume: 65, baseTempo: 160));

        // Создаем список доступных настроений
        var availableMoods = new List<Mood>
        {
            Mood.Joy,
            Mood.Sadness,
            Mood.Anger,
            Mood.Calmness // Добавили спокойствие, как просил клиент
        };

        // Основной цикл программы для выбора настроения
        while (true)
        {
            Console.WriteLine("\nВыберите настроение (введите номер):");
            for (int i = 0; i < availableMoods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableMoods[i].Name}");
            }
            Console.WriteLine("0. Выйти");

            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break; // Выход из программы
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= availableMoods.Count)
            {
                // Выбираем настроение из списка по введенному номеру
                Mood selectedMood = availableMoods[choice - 1];

                // Заставляем оркестр играть в выбранном настроении
                myOrchestra.Perform(selectedMood);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный ввод. Пожалуйста, выберите номер из списка.");
                Console.ResetColor();
            }
        }

        Console.WriteLine("\nПрограмма завершена.");
    }
}