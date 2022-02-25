namespace MyDataStructureLibrary;

/// <summary>
/// Custom defenition of HashTable that uses LinkedList
/// </summary>
public class MyHashTable<K, V>
{
    private readonly int size;
    private readonly LinkedList<KeyValue<K, V>>[] items;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyHashTable{K, V}"/> class.
    /// </summary>
    public MyHashTable(int size)
    {
        this.size = size;
        this.items = new LinkedList<KeyValue<K, V>>[size];
    }

    /// <summary>
    /// Adds the specified key.
    /// <para>If key exists, then update else add</para>
    /// </summary>
    public void Add(K key, V value)
    {
        int position = GetArrayPosition(key);  // |-5| =5 |3|=3 |-3|=3
        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
        KeyValue<K, V> item = new() { Key = key, Value = value };
        if (ContainsKey(key))
            Update(key, value);
        else
            linkedList.AddLast(item);
    }

    /// <summary>
    /// Removes the specified key.
    /// </summary>
    public void Remove(K key)
    {
        int position = GetArrayPosition(key);
        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
        bool itemFound = false;
        KeyValue<K, V> foundItem = default(KeyValue<K, V>);
        foreach (KeyValue<K, V> item in linkedList)
            if (item.Key.Equals(key))
            {
                itemFound = true;
                foundItem = item;
            }
        if (itemFound)
            linkedList.Remove(foundItem);
    }

    /// <summary>
    /// Gets the specified value of the specified key.
    /// </summary>
    public V Get(K key)
    {
        int position = GetArrayPosition(key);
        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
        foreach (KeyValue<K, V> item in linkedList)
            if (item.Key.Equals(key))
                return item.Value;
        return default(V);
    }

    /// <summary>
    /// Gets the array position for said key.
    /// </summary>
    protected int GetArrayPosition(K key)
    {
        int position = key.GetHashCode() % size;
        return Math.Abs(position);
    }

    /// <summary>
    /// Gets the linked list at goven position in Hashtable array.
    /// </summary>
    protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
    {
        if (items[position] == null)
            return items[position] = new LinkedList<KeyValue<K, V>>();
        return items[position];
    }

    /// <summary>
    /// Determines whether the linkedlist contains key.
    /// </summary>
    public bool ContainsKey(K key)
    {
        int position = GetArrayPosition(key);
        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
        foreach (KeyValue<K, V> item in linkedList)
        {
            if (item.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Updates the value of the node containing key.
    /// </summary>
    public void Update(K key, V newValue)
    {
        Remove(key);
        Add(key, newValue);
    }

    /// <summary>
    /// Gets the size of the Hashtable
    /// </summary>
    public int GetSize()
    {
        return size;
    }

    /// <summary>
    /// Determines whether this Hashtable is empty.
    /// </summary>
    public bool IsEmpty()
    {
        if (size == 0)
            return true;
        return false;
    }
}

/// <summary>
/// Generic structure for (Key, Value) pair
/// </summary>
public struct KeyValue<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
}