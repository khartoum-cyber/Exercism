using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int count = 0;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);

        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
                count++;
            }
            else
            {
                number = (number * 3) + 1;
                count++;
            }
        }
        return count;
    }
}