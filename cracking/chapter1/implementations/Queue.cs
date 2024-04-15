public class Queue<T>
{
    //FIFO
    private LinkedList<T> _items = new LinkedList<T>();

    // Adiciona um item ao final da fila - O(1)
    public void Enqueue(T item)
    {
        _items.AddLast(item);
    }

    // Remove e retorna o item no início da fila - O(1)
    public T Dequeue()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        T item = _items.First.Value;
        _items.RemoveFirst();
        return item;
    }

    // Retorna o item no início da fila sem removê-lo - O(1)
    public T Peek()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        return _items.First.Value;
    }

    // Retorna o número de itens na fila - O(N)
    public int Count
    {
        get { return _items.Count; }
    }

    // Remove todos os itens da fila - O(N)
    public void Clear()
    {
        _items.Clear();
    }
}
