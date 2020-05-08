using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
            throw new ArgumentOutOfRangeException();
        
        if (n == 1)
            return 1;
        
        return 2 * Square(n - 1);
    }

    public static ulong Total(int index = 1)
    {
        if (index == 65)
            return 0;
        
        return Square(index) + Total(index + 1);
    }
}