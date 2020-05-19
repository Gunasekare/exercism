using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        string[] splitString = phrase.Replace("-", " ").Replace("_","").Split(" ");

        foreach (string value in splitString)
            if (value.Length > 0)
                acronym += value[0];

        return acronym.ToUpper();
    }
}