using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || sliceLength <= 0)
            throw new ArgumentException();

        List<string> slicedNumbers = new List<string>();
        for (int i = 0; (i + sliceLength) <= numbers.Length; ++i)
            slicedNumbers.Add( numbers.Substring(i,sliceLength));
        
        return slicedNumbers.ToArray();
    }
}