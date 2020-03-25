// solution https://www.codewars.com/kata/53369039d7ab3ac506000467

using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        if (word == true) return "Yes";
        else return "No";
    }
}

// solution https://www.codewars.com/kata/54edbc7200b811e956000556

using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int counter = 0;
        for (int i = 0; i < sheeps.Length; ++i)
        {
            if (sheeps[i]) ++counter;
        }
        return counter;
    }
}