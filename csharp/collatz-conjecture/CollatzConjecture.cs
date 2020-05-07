using System;

public static class CollatzConjecture
{
    static int steps = 0;
    
    public static int Steps(int number)
    {   
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        
        //bug detected during Euler #14
        //all n > 0 contains at least 1 step
        else if (number == 1)
        {   
            int value = steps;  //ideally should be int value = ++steps;
            steps = 0;
            return value;
        }
        else if (number % 2 == 0)
        {
            ++steps;
            return Steps(number / 2);
        }
        else
        {
            ++steps;
            return Steps(3 * number + 1);
        }
    }
}