using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var characterSet = new HashSet<char>();

        foreach (var character in input)
        {
            if (char.IsLetter(character))
            {
                characterSet.Add(char.ToLower(character));
            }
        }

        return characterSet.Count.Equals(26);
    }
}
