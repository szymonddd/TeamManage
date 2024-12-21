using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Score { get; private set; }

    public Player(string name, string position, int score)
    {
        Name = name;
        Position = position;
        Score = score;
    }

    public void UpdateScore(int additionalPoints)
    {
        if (additionalPoints < 0)
        {
            Console.WriteLine("Punkty nie mogą być ujemne.");
            return;
        }

        Score += additionalPoints;
        Console.WriteLine($"Wynik zawodnika {Name} został zaktualizowany. Aktualny wynik: {Score}.");
    }
}