namespace MyDataStructureLibrary;

/// <summary>
/// Manages the nodes in a Binary Search Tree
/// </summary>
public class BinarySearchTree<T> where T : IComparable
{
    public BinaryNode<T> node;

    /// <summary>
    /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
    /// </summary>
    public BinarySearchTree()
    {
        node = null;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
    /// </summary>
    /// <param name="data">The data.</param>
    public BinarySearchTree(T data)
    {
        node = new BinaryNode<T>(data);
    }

    /// <summary>
    /// Adds the specified data to the tree.
    /// </summary>
    public void Add(T data)
    {
        if (node == null)
            node = new(data);
        else
            node.Add(data);
    }

    /// <summary>
    /// Displays this tree.
    /// </summary>
    public void Display()
    {
        node.Display();
        Console.WriteLine();
    }

    /// <summary>
    /// Returns the size of the tree
    /// </summary>
    /// <returns></returns>
    public int Size()
    {
        return BinaryNode<T>.Size(node);
    }
}
