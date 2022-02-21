using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

QueueList<int> queue = new QueueList<int>();

Console.WriteLine("create a Queue of 56->30->70");
queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
Console.WriteLine("Queue: ");
queue.Display();

while (queue.IsEmpty() is false)
{
    Console.WriteLine("Dequeue....");
    queue.Dequeue();
    Console.WriteLine("Queue: ");
    queue.Display();
}