using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> factorsList = new List<int>();
        int sum = 0;

        foreach (int value in multiples)
        {
            if (value != 0)
            {
                int factor = value;
                for (int i = 2; factor < max; factor = value * i++)
                    if (!factorsList.Contains(factor))
                        factorsList.Add(factor);
            }
        }

        foreach (int value in factorsList)
            sum += value;

        return sum;
    }
}