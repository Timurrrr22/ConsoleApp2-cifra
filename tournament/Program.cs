//### 10. Турнир по спорту

//**Описание:**
//Симуляция спортивного турнира, где формируются команды, проводятся матчи с рандомным начислением очков, и по итогам турнира формируется таблица лидеров.

//**Требования:**

//-Хранение списка названий команд и их текущих очков.
//- Функции для создания команд, проведения матча (с использованием генератора случайных чисел для определения счёта), обновления таблицы результатов и вывода итоговой таблицы.
//- Возможность повторного проведения матчей (например, круговая система).

//**Пример функций: **

//- `void CreateTeams()` – запрашивает у пользователя количество команд и их названия, заполняет список.
//- `void SimulateMatch(int teamAIndex, int teamBIndex)` – генерирует случайный счёт для двух команд и обновляет их очки.
//- `void UpdateStandings()` – сортирует список команд по количеству очков (можно реализовать с помощью циклов).
//- `void ShowLeaderboard()` – выводит текущую таблицу результатов.

string pathForGames = "Y:\\Gaziev\\gamesOnTheTournament.txt";
string pathToTable = "Y:\\Gaziev\\table.txt";
int count = 10;
List<string> teams = new List<string>(count);
List<int> points = new List<int>(count);
List<int> numberOfGames = new List<int>(count);
List<int> goalsScored = new List<int>(count);
List<int> goalsConceded = new List<int>(count);
Random random = new Random();

for (int i = 0; i < count; i++)
{
    points.Add(0);
    numberOfGames.Add(0);
    goalsScored.Add(0);
    goalsConceded.Add(0);
}

void ConductingGames(int i, int random2)
{
    numberOfGames[i] += 1; numberOfGames[random2] += 1;
    Console.WriteLine($"Матч между {teams[i]} : {teams[random2]} идет..........................................");
    //Thread.Sleep(5000);
    int goals1 = random.Next(0, 6);
    int goals2 = random.Next(0, 6);
    if (goals1 == goals2)
    {
        string str = $"Ничья {teams[i]} и {teams[random2]}! {goals1} : {goals2}";
        Console.WriteLine(str);
        //Thread.Sleep(4000);
        goalsScored[i] += goals1;
        goalsScored[random2] += goals2;
        goalsConceded[i] += goals2;
        goalsConceded[random2] += goals1;
        points[i] += 1;
        points[random2] += 1;
        File.AppendAllText(pathForGames, str + Environment.NewLine);
    }
    else if (goals1 > goals2)
    {
        string str2 = $"Побеждает {teams[i]} со счетом {goals1} : {goals2} и получает 3 очка в копилку." +
            $" {teams[random2]} - 0. Ахахахахах ";
        Console.WriteLine(str2);
        //Thread.Sleep(4000);
        goalsScored[i] += goals1;
        goalsScored[random2] += goals2;
        goalsConceded[i] += goals2;
        goalsConceded[random2] += goals1;
        points[i] += 3;
        File.AppendAllText(pathForGames, str2 + Environment.NewLine);
    }
    else if (goals1 < goals2)
    {
        string str3 = $"Побеждает {teams[random2]} со счетом {goals1} : {goals2} и получает 3 очка в копилку." +
            $" {teams[i]} - 0. Ахахахахах ";
        Console.WriteLine(str3);
        //Thread.Sleep(4000);
        goalsScored[i] += goals1;
        goalsScored[random2] += goals2;
        goalsConceded[i] += goals2;
        goalsConceded[random2] += goals1;
        points[random2] += 3;
        File.AppendAllText(pathForGames, str3 + Environment.NewLine);
    }
}

while (true)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите название для {i + 1} команды: ");
        string input = Console.ReadLine();
        teams.Add(input);
    }

    int n = teams.Count;
    for(int i = 0; i < n-1; i++)
    {
        for(int j = i+1; j < n; j++)
        {
            ConductingGames(i, j);
        }
    }


    for (int i = 0; i < teams.Count - 1; i++)
    {
        for (int j = 0; j < teams.Count - i - 1; j++)
        {
            if (points[j] < points[j + 1])
            {
                // Swap points
                int tempScore = points[j];
                points[j] = points[j + 1];
                points[j + 1] = tempScore;

                //swap goalsScored
                int tempScored = goalsScored[j];
                goalsScored[j] = goalsScored[j+1];
                goalsScored[j + 1] = tempScored;

                //swap goalsConceded
                int tempConcended = goalsConceded[j];
                goalsConceded[j] = goalsConceded[j+1];
                goalsConceded[j+1] = tempConcended;

                // Swap names
                string tempName = teams[j];
                teams[j] = teams[j + 1];
                teams[j + 1] = tempName;
            }
        }
    }

    for (int k = 0; k < teams.Count; k++)
    {
        Console.WriteLine("Название команды. Очки. Кол-во игр. ГЗ. ГП.");
        Console.WriteLine($"{k + 1}. {teams[k]}: {points[k]} - {numberOfGames[k]} - {goalsScored[k]} - {goalsConceded[k]}" 
            + Environment.NewLine);
        File.AppendAllText(pathToTable, $"{k + 1}. {teams[k]} - Очки:{points[k]}" +
            $" - Кол-во игр:{numberOfGames[k]} - ГЗ:{goalsScored[k]} - ГП:{goalsConceded[k]}"
            + Environment.NewLine);
    }
}

