using WordleLib.Enums;
using WordleLib.Tests.Fixtures;

namespace WordleLib.Tests;

[Collection("Wordle letter collection")]
public abstract class LetterWordleTests
{
    protected readonly Wordle _wordle;

    protected LetterWordleTests(BaseLetterWordleFixture wordleFixture)
    {
        _wordle = wordleFixture.wordle;
    }

    public void Guess_ShouldReturnAppropriateGuessStateArray(string guess, GuessState[] expected)
    {
        // Arrange

        // Act
        GuessState[] actual = _wordle.Guess(guess);

        // Assert
        Assert.True(actual.SequenceEqual(expected));
    }
}
