using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

BinarySearchTree<int> intTree = new BinarySearchTree<int>();

intTree.Add(56);
intTree.Add(30);
intTree.Add(70);
intTree.Add(22);
intTree.Add(40);
intTree.Add(60);
intTree.Add(95);
intTree.Add(11);
intTree.Add(65);
intTree.Add(3);
intTree.Add(16);
intTree.Add(63);
intTree.Add(67);

intTree.Display();

Console.WriteLine("Size of tree: " + intTree.Size());