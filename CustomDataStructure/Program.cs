using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

UnOrderedLinkedList<int> list = new UnOrderedLinkedList<int>();

/*Console.WriteLine("Appending 56, 30, 70 to list");
list.Append(56);
list.Append(30);
list.Append(70);*/


Console.WriteLine("Adding 10, 20, 30");
list.Add(10);
list.Add(20);
list.Add(30);

Console.WriteLine("List 1");
list.Display();