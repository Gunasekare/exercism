using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public HighScores(List<int> list) => scores = list;

    public List<int> Scores() => new List<int>(scores);

    public int Latest() => scores.Last();

    public int PersonalBest() => scores.Max();

    public List<int> PersonalTopThree() => scores.OrderByDescending(x => x).Take(3).ToList();

    private readonly List<int> scores; 
}