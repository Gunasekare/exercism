using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        input = new String(inputArray);
        return input;
    }
}