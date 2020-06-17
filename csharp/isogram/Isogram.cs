using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var characterSet = new List<char>();

        foreach (var character in word.ToLower())
        {
            if (!char.IsLetter(character) || (char.IsLetter(character) && !characterSet.Contains(character)))
            {
                characterSet.Add(character);
            }
        }

        return characterSet.Count.Equals(word.Length);
    }
}
