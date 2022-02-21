using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

OrderedLinkedList<int> list = new OrderedLinkedList<int>();

Console.WriteLine("Adding 56, 30, 40, 70 to ordered list");
list.Add(56);
list.Add(30);
list.Add(40);
list.Add(70);

Console.WriteLine("Sorted List: ");
list.Display();