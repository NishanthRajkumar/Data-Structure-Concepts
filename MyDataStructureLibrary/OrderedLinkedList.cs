namespace MyDataStructureLibrary;

/// <summary>
/// Creates and maintains ordered list
/// </summary>
/// <typeparam name="T">IComparable data types only</typeparam>
public class OrderedLinkedList<T> where T : IComparable
{
    // An object of Onordered list variable is declared
    private UnOrderedLinkedList<T> list;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderedLinkedList{T}"/> class.
    /// </summary>
    public OrderedLinkedList()
    {
        list = new UnOrderedLinkedList<T>();
    }

    /// <summary>
    /// Adds the specified data in Ordered list.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Add(T data)
    {
        int index = GetIndex(data);
        list.Insert(index, data);
    }

    /// <summary>
    /// Gets the Index where the specified data is to be added in the sorted list
    /// </summary>
    public int GetIndex(T data)
    {
        int index = 0;
        Node<T> temp = list.head;
        while (temp != null)
        {
            if (temp.data.CompareTo(data) > 0)
                return index;
            temp = temp.next;
            index++;
        }
        return index;
    }

    /// <summary>
    /// Displays the list.
    /// </summary>
    public void Display()
    {
        list.Display();
    }
}
