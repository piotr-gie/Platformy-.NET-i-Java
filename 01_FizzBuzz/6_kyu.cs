// solution https://www.codewars.com/kata/5592e3bd57b64d00f3000047

using System;
public class ASum
{

    public static long findNb(long m)
    {
        int n = 0;
        while (m > 0)
        {
            ++n;
            m -= (long)Math.Pow(n, 3);
        }
        return (m == 0) ? n : -1;
    }

}