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

    /// <summary>
    /// Returns the size of current node along with left and right
    /// </summary>
    public static int Size(BinaryNode<T> node)
    {
        if (node == null)
            return 0;
        return Size(node.left) + 1 + Size(node.right);
    }

    /// <summary>
    /// Searches the specified data in the current node.
    /// <para>Searches recursively</para>
    /// </summary>
    public bool Search(T data)
    {
        if (this.data.CompareTo(data) == 0)
            return true;
        if (this.data.CompareTo(data) < 0)
        {
            if (right == null)
                return false;
            return right.Search(data);
        }
        else if (left == null)
            return false;
        return left.Search(data);
    }
}
