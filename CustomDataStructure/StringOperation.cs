using MyDataStructureLibrary;

namespace CustomDataStructure;

internal class StringOperation
{
    private string text = string.Empty;
    private string[] words;
    private MyHashTable<string, int> wordTable;

    /// <summary>
    /// Initializes a new instance of the <see cref="StringOperation"/> class.
    /// </summary>
    public StringOperation(string text)
    {
        this.text = text;
        SplitText();
        wordTable = new MyHashTable<string, int>(words.Length);
    }

    /// <summary>
    /// Splits the text into words.
    /// </summary>
    public void SplitText()
    {
        // Split the text into array string containing the words in text
        char[] separators = @" !.@\(){}[]?,".ToCharArray();
        words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        EnterToHashTable();
    }

    /// <summary>
    /// Enters the word array to hash table.
    /// </summary>
    private void EnterToHashTable()
    {
        foreach (string word in words)
            if (wordTable.ContainsKey(word))
                wordTable.Update(word, wordTable.Get(word) + 1);
            else
                wordTable.Add(word, 1);
    }

    /// <summary>
    /// Gets the frequency of the word.
    /// </summary>
    public int GetFrequency(string word)
    {
        word = word.ToLower();
        return wordTable.Get(word);
    }
}
