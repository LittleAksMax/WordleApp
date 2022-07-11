using Moq;
using WordleLib.Exceptions;

namespace WordleLib.Tests;

public class GeneralWordleTests
{
    private const int wordLength = 5;
    private readonly Wordle _wordle = new WordleFactory()
        .CreateWordle(It.IsAny<uint>(), wordLength, @"dictionary.txt");

    [Theory]
    [InlineData("sdasd")]
    [InlineData("xxxxx")]
    [InlineData("M0n3y")]
    [InlineData("Coin$")]
    [InlineData("fattt")]
    [InlineData("2suck")]
    public void Guess_ShouldThrowUnacceptableWordExceptionIfInvalidWord(string guess)
    {
        // Arrange

        // Act + Assert
        Assert.Throws<UnacceptableWordException>(() => _wordle.Guess(guess));
    }
}
