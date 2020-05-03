using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string rnaComplement = "";

        Dictionary<char, char> aminoAcids = new Dictionary<char, char>();
        aminoAcids.Add('G', 'C');
        aminoAcids.Add('C', 'G');
        aminoAcids.Add('T', 'A');
        aminoAcids.Add('A', 'U');

        foreach (char letter in nucleotide)
        {
            char value;
            if (aminoAcids.TryGetValue(letter, out value))
                rnaComplement += aminoAcids[letter];
        }
        return rnaComplement;
    }
}