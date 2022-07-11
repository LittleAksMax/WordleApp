using Moq;

namespace WordleLib.Tests.Fixtures;

public class BaseLetterWordleFixture
{
    private const string dictionaryPath = @"dictionary.txt"; // all use the same context for the dictionary
    private const int wordLength = 5;
    private const string guess = "wreck";

    public Wordle wordle;

    public BaseLetterWordleFixture(string guess)
    {
        // specify word to guess for easy
        wordle = new WordleFactory().CreateWordle(It.IsAny<uint>(),
            wordLength, Path.GetFullPath(dictionaryPath), guess);
    }
}
