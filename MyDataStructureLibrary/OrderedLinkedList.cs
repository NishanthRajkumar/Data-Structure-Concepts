namespace MyDataStructureLibrary;

/// <summary>
/// Creates and maintains ordered list
/// </summary>
public class OrderedLinkedList<T> : MyLinkedList<T> where T : IComparable
{
    /// <summary>
    /// Adds the specified data in Ordered list.
    /// </summary>
    public new void Add(T data)
    {
        int index = 0;
        Node<T> temp = head;
        while (temp != null)
        {
            if (temp.data.CompareTo(data) > 0)
                break;
            temp = temp.next;
            index++;
        }
        Insert(index, data);
    }

    /// <summary>
    /// Pops the first element in list.
    /// </summary>
    public new void Pop()
    {
        base.Pop();
    }

    /// <summary>
    /// returns an empty instance of ordered list
    /// </summary>
    /// <returns>an instance of Ordered List</returns>
    public static OrderedLinkedList<T> OrderedList()
    {
        return new OrderedLinkedList<T>();
    }
}
