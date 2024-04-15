using System;

class ArrayList<T>
{
    private T[] array;
    private int size;

    public ArrayList()
    {
        array = new T[8];
        size = 0;
    }

    public void Add(T item)
    {
        if (size == array.Length)
        {
            //copy to a new array doubling the size
            Array.Resize(ref array, array.Length * 2);
        }

        array[size] = item;
        size++;
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        T removedItem = array[index];

        for (int i = index; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }

        size--;
        return removedItem;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return array[index];
        }
        set
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            array[index] = value;
        }
    }

    public int Count => size;
}
