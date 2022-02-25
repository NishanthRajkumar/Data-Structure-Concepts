using MyDataStructureLibrary;

namespace CustomDataStructure;

/// <summary>
/// String operations using Hash Table
/// </summary>
internal class StringOperation
{
    private string text = string.Empty;
    private string[] words;
    private MyHashTable<string, LinkedList<int>> wordTable;

    /// <summary>
    /// Initializes a new instance of the <see cref="StringOperation"/> class.
    /// </summary>
    public StringOperation(string text)
    {
        this.text = text;
        SplitText();
        wordTable = new MyHashTable<string, LinkedList<int>>(words.Length);
        EnterToHashTable();
    }

    /// <summary>
    /// Splits the text into words.
    /// </summary>
    public void SplitText()
    {
        // Split the text into array string containing the words in text
        char[] separators = @" !.@\(){}[]?,".ToCharArray();
        words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Enters the word array to hash table.
    /// </summary>
    private void EnterToHashTable()
    {
        for (int i = 0; i < words.Length; i++)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(i);
            if (wordTable.Get(words[i]) != null)
            {
                list = wordTable.Get(words[i]);
                list.AddLast(i);
                if (wordTable.ContainsKey(words[i]))
                    wordTable.Remove(words[i]);
            }
            wordTable.Add(words[i], list);
        }
    }

    /// <summary>
    /// Gets the frequency of the word.
    /// </summary>
    public LinkedList<int> GetVal(string word)
    {
        word = word.ToLower();
        return wordTable.Get(word);
    }

    /// <summary>
    /// Gets the string after the avoidable word is removed from text
    /// </summary>
    public string GetAvoidedString()
    {
        LinkedList<int> avoidWordIndex = new LinkedList<int>();
        foreach (string word in words)
        {
            LinkedList<int> temp = wordTable.Get(word);
            if (temp.Count > avoidWordIndex.Count)
                avoidWordIndex = temp;
        }
        return RemoveAvoidable(avoidWordIndex);
    }

    /// <summary>
    /// Removes the avoidable word
    /// </summary>
    public string RemoveAvoidable(LinkedList<int> avoidWordIndex)
    {
        string str = "";
        for (int i = 0; i < words.Length; i++)
            if (avoidWordIndex.Contains(i) is false || i == avoidWordIndex.First())
            {
                str += words[i] + " ";
            }
        return str;
    }
}
