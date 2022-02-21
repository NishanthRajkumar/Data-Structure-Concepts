using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

StackList<int> stack = new StackList<int>();
Console.WriteLine("Pushing to stack: 70 then 30 then 56");
stack.Push(70);
stack.Push(30);
stack.Push(56);
stack.Display();