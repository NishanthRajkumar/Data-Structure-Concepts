using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

// String used to test the word frequency count
string testString = "To be or not to be";

// Split the text into array string containing the words in text
char[] separators = @" !.@\(){}[]?,".ToCharArray();
string[] words = testString.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

// HashTable to store all words as key and their count as Value
MyHashTable<string, int> wordTable = new MyHashTable<string, int>(words.Length);

foreach (string word in words)
    if (wordTable.ContainsKey(word))
        wordTable.Update(word, wordTable.Get(word) + 1);
    else
        wordTable.Add(word, 1);

Console.WriteLine($"Frequency of 'to': {wordTable.Get("to")}");