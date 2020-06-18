using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var splitPhrase = phrase.Split(" ").ToList();
        var abbreviation = string.Empty;

        foreach (var word in splitPhrase)
        {
            if (char.IsLetter(word[0]))
            {
                abbreviation += word[0];
            }
        }

        return abbreviation;
    }
}