using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool[] alphabet = new bool[26];

        foreach (char letter in input)
        {
            char value;
            value = char.ToUpper(letter);
            if (value < 65 || value > 90)
                continue;
            alphabet[value - 65] = true;
        }
        return Array.TrueForAll(alphabet, value => value == true);
    }
}
