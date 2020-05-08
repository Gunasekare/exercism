using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string wordChars = "";

        foreach (char letter in word)
        {
            char value = char.ToUpper(letter);
            if (value < 65 || value > 90)
                continue;
            
            if (wordChars.Contains(value))
                return false;
            
            wordChars += value;
        }
        return true;
    }
}
