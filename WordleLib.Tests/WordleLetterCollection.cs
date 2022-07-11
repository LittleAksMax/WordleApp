namespace WordleLib.Tests;

[CollectionDefinition("Wordle letter collection")]
public class WordleLetterCollection
{
    // The sole purpose of this class is to apply [CollectionDefinition] and all
    // ICollectionFixture interfaces

    // I need to have done this so the tests are run sequentially which is
    // important so two tests don't open the same dictionary.txt file simultaneously
}
