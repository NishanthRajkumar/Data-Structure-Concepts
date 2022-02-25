namespace MyDataStructureLibrary;

/// <summary>
/// handles all operations in unordered list
/// </summary>
/// <typeparam name="T"></typeparam>
public class UnOrderedLinkedList<T> : MyLinkedList<T> where T : IComparable
{
    /// <summary>
    /// Creates and returns empty list.
    /// </summary>
    /// <returns>empty UnOrderedLinkedList object</returns>
    public static UnOrderedLinkedList<T> List()
    {
        return new UnOrderedLinkedList<T>();
    }

    /// <summary>
    /// Appends the specified data to end of list.
    /// </summary>
    public new void Append(T data)
    {
        base.Append(data);
    }

    /// <summary>
    /// Displays the list.
    /// </summary>
    public new void Display()
    {
        base.Display();
    }

    /// <summary>
    /// Adds the specified data at the begining of the list.
    /// </summary>
    public new void Add(T data)
    {
        base.Add(data);
    }

    /// <summary>
    /// Inserts data at the specified position.
    /// </summary>
    /// <param name="pos">The position.</param>
    /// <param name="data">The data.</param>
    public new void Insert(int pos, T data)
    {
        base.Insert(pos, data);
    }

    /// <summary>
    /// Pops the first element in list.
    /// </summary>
    public new void Pop()
    {
        base.Pop();
    }

    /// <summary>
    /// Pops the last element in list.
    /// </summary>
    public new void PopLast()
    {
        base.PopLast();
    }
}
