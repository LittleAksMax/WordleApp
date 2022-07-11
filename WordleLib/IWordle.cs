using WordleLib.Enums;

namespace WordleLib;

public interface IWordle
{
    uint GuessesLeft { get; }
    uint WordLength { get; }
    IReadOnlyCollection<string> Dictionary { get; }

    GuessState[] Guess(string guess);
}