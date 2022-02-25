namespace MyDataStructureLibrary;

/// <summary>
/// Manages a instance of a binary node used in Binary Search Tree
/// </summary>
/// <typeparam name="T"></typeparam>
public class BinaryNode<T> where T : IComparable
{
    public T data;
    public BinaryNode<T> left;
    public BinaryNode<T> right;

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryNode{T}"/> class.
    /// </summary>
    public BinaryNode(T data)
    {
        this.data = data;
        left = null;
        right = null;
    }

    /// <summary>
    /// Displays the details of the current node in the following order:
    /// <para>left->data->right</para>
    /// <para>This is a recursive method that will be called until reaching leaf node</para>
    /// </summary>
    public void Display()
    {
        // Traverse left tree
        if (left != null)
            left.Display();

        // print current node data
        Console.Write(data + " ");

        //traverse right tree
        if (right != null)
            right.Display();
    }

    /// <summary>
    /// Adds the specified data to the node's left or right tree after comparing data
    /// <para>This is a recursive method that will be called until reaching leaf node</para>
    /// </summary>
    /// <param name="data">The data.</param>
    public void Add(T data)
    {
        if (this.data.CompareTo(data) < 0)
        {
            if (right != null)
                right.Add(data);
            else
                right = new(data);
        }
        else if (left != null)
            left.Add(data);
        else
            left = new(data);
    }
}
