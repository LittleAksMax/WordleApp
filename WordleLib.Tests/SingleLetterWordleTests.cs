using WordleLib.Enums;
using WordleLib.Tests.Fixtures;

namespace WordleLib.Tests;

public class SingleLetterWordleTests : LetterWordleTests, IClassFixture<SingleLetterWordleFixture>
{
    public SingleLetterWordleTests(SingleLetterWordleFixture wordleFixture)
        : base(wordleFixture)
    {
    }

    [Theory]
    [MemberData(nameof(GuessStateTestData))]
    public void Guess_ShouldReturnAppropriateGuessStateArray_(string guess, GuessState[] expected)
    {
        Guess_ShouldReturnAppropriateGuessStateArray(guess, expected);
    }

    public static IEnumerable<object[]> GuessStateTestData =>
        new List<object[]>
        {
            new object[] { "wreck",
                new GuessState[]
                {
                    GuessState.Correct,
                    GuessState.Correct,
                    GuessState.Correct,
                    GuessState.Correct,
                    GuessState.Correct
                } },
            new object[] { "elect",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.None,
                    GuessState.Correct,
                    GuessState.Correct,
                    GuessState.None
                } },
            new object[] { "stalk",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.None,
                    GuessState.None,
                    GuessState.None,
                    GuessState.Correct
                } },
            new object[] { "speed",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.None,
                    GuessState.Correct,
                    GuessState.None,
                    GuessState.None
                } },
            new object[] { "breed",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.Correct,
                    GuessState.Correct,
                    GuessState.None,
                    GuessState.None
                } },
            new object[] { "beefy",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.None,
                    GuessState.Correct,
                    GuessState.None,
                    GuessState.None
                } },
            new object[] { "bevel",
                new GuessState[]
                {
                    GuessState.None,
                    GuessState.Elsewhere,
                    GuessState.None,
                    GuessState.None,
                    GuessState.None
                } },
        };
}
