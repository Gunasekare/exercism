using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string result = "";
        foreach (char letter in phoneNumber.ToCharArray())
            if (letter >= '0' && letter <= '9')
                result += letter;
        
        if (result.Length == 11 && result.ToCharArray()[0] == '1')
            result = result.Substring(1);

        if (result.Length != 10 || result.ToCharArray()[0] < '2' || result.ToCharArray()[3] < '2')
            throw new ArgumentException();
        else
            return result;
    }
}