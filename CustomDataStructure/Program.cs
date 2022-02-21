using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

UnOrderedLinkedList<int> list = new UnOrderedLinkedList<int>();

Console.WriteLine("Appending 56, 30, 70 to list");
list.Append(56);
list.Append(70);
list.Insert(1, 30);
list.Display();

Console.WriteLine("Insert 40 after 30");
int pos = list.Index(30);
list.Insert(pos + 1, 40);
list.Display();

Console.WriteLine("Remove 40");
list.Remove(40);
list.Display();

Console.WriteLine("Size of list: " + list.Size());