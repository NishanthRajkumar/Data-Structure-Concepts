namespace MyDataStructureLibrary;

public class UnOrderedLinkedList<T> where T : IComparable<T>
{
    public Node<T> head;

    public UnOrderedLinkedList()
    {
        head = null;
    }

    /// <summary>
    /// Creates and returns empty list.
    /// </summary>
    /// <returns>empty UnOrderedLinkedList object</returns>
    public UnOrderedLinkedList<T> List()
    {
        UnOrderedLinkedList<T> emptyList = new UnOrderedLinkedList<T>();
        return emptyList;
    }

    public void Append(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;
        else
        {
            Node<T> temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = node;
        }
    }

    public void Display()
    {
        Node<T> temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + "\n");
            temp = temp.next;
        }
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;
        else
        {
            node.next = head;
            head = node;
        }
    }

    public void Insert(int pos, T data)
    {
        Node<T> temp = head;
        if (pos < 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        if (pos == 0)
            Add(data);
        else
        {
            Node<T> node = new Node<T>(data);
            for (int i = 1; i < pos; i++)
                temp = temp.next;
            node.next = temp.next;
            temp.next = node;
        }
    }

    public void Pop()
    {
        if (head == null)
            return;
        else
            head = head.next;
    }

    public void PopLast()
    {
        if (head == null)
            return;
        else
        {
            Node<T> temp = head;
            while (temp.next.next != null)
                temp = temp.next;
            temp.next = null;
        }
    }

    public bool Search(T data)
    {
        Node<T> temp = head;
        while (temp != null)
        {
            if (temp.data.CompareTo(data) == 0)
                return true;
            temp = temp.next;
        }
        return false;
    }
}
