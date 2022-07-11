using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleLib.Exceptions;

namespace WordleLib;

public class WordleFactory
{
    DictionaryFactory dictionaryFactory = new DictionaryFactory();
    Random random = new Random();

    public Wordle CreateWordle(uint guesses, uint wordLength, string dictionaryPathFile, string? wordToGuess = null)
    {
        IReadOnlyCollection<string> dictionary = dictionaryFactory.CreateDictionaryFromFilePath(dictionaryPathFile, wordLength);

        if (wordToGuess is null)
        {
            wordToGuess = dictionary.ElementAt(random.Next(dictionary.Count));
        }
        else
        {
            wordToGuess = wordToGuess.ToLower();
            if (!WordleValidator.ValidateWord(wordToGuess, wordLength) || !WordleValidator.IsInDictionary(wordToGuess, dictionary))
            {
                throw new UnacceptableWordException();
            }
        }

        var frequency = new Dictionary<char, int>();

        foreach (var c in wordToGuess)
        {
            frequency[c] = wordToGuess.Count(ch => ch == c);
        }
        return new Wordle(guesses, wordLength, dictionary, frequency, wordToGuess);
    }
}
