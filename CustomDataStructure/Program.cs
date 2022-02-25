using CustomDataStructure;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

// String used to test the word frequency count of the para
string testString;
testString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

StringOperation wordOperation = new(testString);

Console.WriteLine($"Frequency of 'Paranoid': {wordOperation.GetFrequency("paranoid")}");