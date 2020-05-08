using System;

public static class ResistorColor
{
    static string[] resistorCodes = new string[] {"black", "brown", "red", "orange", "yellow",
                                                  "green", "blue", "violet", "grey", "white"};
    public static int ColorCode(string color)
    {

        for (int i = 0; i < 10; ++i)
            if (resistorCodes[i] == color)
                return i;

        return -1;
    }

    public static string[] Colors()
    {
        return resistorCodes;
    }
}