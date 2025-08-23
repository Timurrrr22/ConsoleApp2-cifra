public class Quiz
{
    private List<string> questions;
    private List<string> answers;

    public Quiz()
    {
        LoadQuestions();
    }

    // Инициализирует списки вопросов и ответов
    private void LoadQuestions()
    {
        questions = new List<string>()
        {
            "Столица Франции?",
            "Самая высокая гора в мире?",
            "Сколько планет в Солнечной системе?",
            "Крупнейший океан на Земле?",
            "В каком году закончилась Вторая мировая война?",
            "Какой буквой обозначается ускорение свободного падения(англ)?",
            "Маятник совершает 10 колебаний за 5 секунд. Какова его частота?",
            "Административный центр Кабардино-Балкарской республики?",
            "Крещение Руси. Дата?",
            "Дата падения Византийской империи?",
            "Фамилия ученого, написавшего Трактат по электричеству и магнетизму "
        };
        answers = new List<string>()
        {
            "Париж",
            "Эверест",
            "8",
            "Тихий океан",
            "1945",
            "g",
            "2",
            "Нальчик",
            "988",
            "1453",
            "Максвелл"
        };
    }


    // Задаёт вопрос, считывает ответ и возвращает результат проверки
    private bool AskQuestion(int index)
    {
        Console.WriteLine(questions[index]);
        string userAnswer = Console.ReadLine().ToLower(); 
        return userAnswer == answers[index].ToLower();
    }

    // Выводит итоговый результат викторины
    private void ShowResult(int score, int totalQuestions)
    {
        Console.WriteLine($"\nВаш итоговый балл: {score} из {totalQuestions}");
        if (score < totalQuestions)
        {
            Console.WriteLine("\nОтветы на вопросы:");
            for (int i = 0; i < totalQuestions; i++)
            {
                if (!AskQuestion(i))
                {
                    Console.WriteLine($"Вопрос {i + 1}: {questions[i]} \nПравильный ответ: {answers[i]}");
                }
            }
        }
    }



    public void Run()
    {
        int score = 0;
        int totalQuestions = questions.Count;

        for (int i = 0; i < totalQuestions; i++)
        {
            if (AskQuestion(i))
            {
                score++;
                Console.WriteLine("Правильно!\n");
            }
            else
            {
                Console.WriteLine($"Неправильно. Правильный ответ: {answers[i]}\n");
            }
        }

        ShowResult(score, totalQuestions);
    }


    public static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        quiz.Run();
    }
}
