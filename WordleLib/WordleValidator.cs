namespace WordleLib;

public static class WordleValidator
{
    public static bool ValidateWord(string? word, uint wordLength)
    {
        return word is not null && word.Length == wordLength && word.All(char.IsLetter);
    }

    public static bool IsInDictionary(string word, IReadOnlyCollection<string> dictionary)
    {
        return dictionary.Contains(word);
    }
}