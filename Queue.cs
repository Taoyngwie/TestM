class Queue<T>
{
    private Node<T> top = null;
    private int length = 0;

    public void Push(T value)
    {
        Node<T> node = new Node<T>(value);
<<<<<<< HEAD
        if (this.top == null)
=======
        if(this.top == null)
>>>>>>> TimeInput
        {
            this.top = node;
        }
        else
        {
<<<<<<< HEAD
            Node<T> lastNode = this.GetNode(this.length - 1);
=======
            Node<T> lastNode = this.GetNode(this.length-1);
>>>>>>> TimeInput
            lastNode.SetNext(node);
        }
        this.length++;
    }

    public T Pop()
    {
        Node<T> node = this.top;
        this.top = this.top.Next();
        this.length--;
        return node.GetValue();
    }

    public T Get(int index)
    {
        Node<T> ptr = this.GetNode(index);
        return ptr.GetValue();
    }

    public int GetLength()
    {
        return this.length;
    }

    private Node<T> GetNode(int index)
    {
        Node<T> ptr = this.top;
<<<<<<< HEAD
        while (index > 0)
=======
        while(index > 0)
>>>>>>> TimeInput
        {
            ptr = ptr.Next();
            index--;
        }
        return ptr;
    }
}