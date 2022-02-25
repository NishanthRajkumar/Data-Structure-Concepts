using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

BinarySearchTree<int> intTree = new BinarySearchTree<int>();

intTree.Add(56);
intTree.Add(30);
intTree.Add(70);

intTree.Display();