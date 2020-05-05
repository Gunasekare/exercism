using System;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        List<int> factors = Factor(number);
        int aliquotSum = 0;

        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        
        foreach (int value in factors)
            aliquotSum += value;
        
        if (aliquotSum == number)
            return Classification.Perfect;
        else if (aliquotSum > number)
            return Classification.Abundant;
        
        return Classification.Deficient;
    }

    public static List<int> Factor (int number)
    {
        List<int> factors = new List<int>() {0};

        for (int i = 1; i <= (number / 2); ++i)
            if (number % i == 0)
                factors.Add(i);

        return factors;
    }
}
