using WordleLib.Enums;
using WordleLib.Tests.Fixtures;

namespace WordleLib.Tests
{
    [Collection("Wordle letter collection")]
    public class DoubleLetterWordleTests : LetterWordleTests, IClassFixture<DoubleLetterWordleFixture>
    {

        public DoubleLetterWordleTests(DoubleLetterWordleFixture wordleFixture)
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
                new object[] { "speed",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.Correct
                    } },
                new object[] { "snake",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere
                    } },
                new object[] { "judge",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.None,
                        GuessState.Elsewhere
                    } },
                new object[] { "needy",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.Correct,
                        GuessState.Elsewhere,
                        GuessState.None
                    } },
                new object[] { "crass",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.None
                    } },
                new object[] { "penis",
                    new GuessState[]
                    {
                        GuessState.Elsewhere,
                        GuessState.Elsewhere,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere
                    } },
                new object[] { "trash",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.None
                    } },
                new object[] { "night",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None
                    } },
                new object[] { "tense",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.Elsewhere
                    } },
                new object[] { "peace",
                    new GuessState[]
                    {
                        GuessState.Elsewhere,
                        GuessState.Elsewhere,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere
                    } },
                new object[] { "sheet",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.None
                    } },
                new object[] { "spend",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.Correct
                    } },
                new object[] { "spill",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None
                    } },
                new object[] { "smile",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere
                    } },
                new object[] { "wound",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Correct
                    } },
                new object[] { "braid",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Correct
                    } },
                new object[] { "bread",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.Correct
                    } },
                new object[] { "lands",
                    new GuessState[]
                    {
                        GuessState.None,
                        GuessState.None,
                        GuessState.None,
                        GuessState.Elsewhere,
                        GuessState.Elsewhere
                    } },
                new object[] { "swell",
                    new GuessState[]
                    {
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.Correct,
                        GuessState.None,
                        GuessState.None
                    } },
                new object[] { "penny",
                    new GuessState[]
                    {
                        GuessState.Elsewhere,
                        GuessState.Elsewhere,
                        GuessState.None,
                        GuessState.None,
                        GuessState.None
                    } },
            };
        }
}
