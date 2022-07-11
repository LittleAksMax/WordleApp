using WordleLib.Enums;
using WordleLib.Exceptions;

namespace WordleLib;

public class Wordle : IWordle
{
    public uint GuessesLeft { get; private set; }
    public uint WordLength { get; }

    private readonly string _wordToGuess;

    private readonly Dictionary<char, int> _frequency = new();

    public IReadOnlyCollection<string> Dictionary { get; }

    public string WordToGuess { get => _wordToGuess; }

    public Wordle(uint guesses, uint wordLength, IReadOnlyCollection<string> dictionary, Dictionary<char, int> frequency, string wordToGuess)
    {
        GuessesLeft = guesses;
        WordLength = wordLength;
        Dictionary = dictionary;
        _frequency = frequency;
        _wordToGuess = wordToGuess;
    }

    public GuessState[] Guess(string guess)
    {
        guess = guess.ToLower(); // make sure it's lower case

        
        if (!WordleValidator.ValidateWord(guess, WordLength) || !WordleValidator.IsInDictionary(guess, Dictionary))
        {
            throw new UnacceptableWordException();
        }

        GuessesLeft--;
        var states = new GuessState[WordLength];

        var frequency = new Dictionary<char, int>(_frequency);

        for (int i = 0; i < WordLength; i++)
        {
            if (guess[i] == _wordToGuess[i])
            {
                states[i] = GuessState.Correct;
                frequency[guess[i]]--;
            }
        }
        for (int i = 0; i < WordLength; i++)
        {
            // skip already examined (correct) letters
            if (states[i] == GuessState.Correct)
            {
                continue;
            }

            if (!_wordToGuess.Contains(guess[i]))
            {
                states[i] = GuessState.None;
            }
            else
            {
                if (frequency[guess[i]] == 0) continue;
                
                states[i] = GuessState.Elsewhere;
                frequency[guess[i]]--;
            }
        }

        return states;
    }
}