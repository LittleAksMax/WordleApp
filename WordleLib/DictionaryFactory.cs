using System.Collections.ObjectModel;
using WordleLib.Exceptions;

namespace WordleLib;

public class DictionaryFactory
{
    public IReadOnlyCollection<string> CreateDictionaryFromFilePath(string dictionaryFilePath, uint wordLength)
    {
        List<string> dictionary = new List<string>();
        using StreamReader sr = new StreamReader(new FileInfo(dictionaryFilePath)
            .Open(FileMode.Open, FileAccess.Read));
        while (!sr.EndOfStream)
        {
            var word = sr.ReadLine();
            if (!WordleValidator.ValidateWord(word, wordLength))
            {
                throw new UnacceptableWordException();
            }
            dictionary.Add(word!); // don't need conditional access since Validation checks for null
        }

        return new ReadOnlyCollection<string>(dictionary);
    }
}