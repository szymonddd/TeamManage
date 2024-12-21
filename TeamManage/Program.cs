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
public class Team
{
    private List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        if (player == null)
        {
            Console.WriteLine("Nie można dodać pustego zawodnika.");
            return;
        }

        players.Add(player);
        Console.WriteLine($"Zawodnik {player.Name} został dodany do drużyny.");
    }

    public void RemovePlayer(string playerName)
    {
        Player player = players.FirstOrDefault(p => p.Name == playerName);
        if (player != null)
        {
            players.Remove(player);
            Console.WriteLine($"Zawodnik {playerName} został usunięty z drużyny.");
        }
        else
        {
            Console.WriteLine($"Zawodnik {playerName} nie został znaleziony w drużynie.");
        }
    }