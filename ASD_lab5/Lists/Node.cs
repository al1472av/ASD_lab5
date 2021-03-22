namespace ASD_lab5.Lists
{
    public class Node<T>
    {
        private Node<T> next;
        private Node<T> previous;
        private T item;


        public Node(T value) => item = value;

        public Node(LinkedListBase<T> list, T value)
        {
            item = value;
        }

        public Node<T> Next
        {
            get => next;
            set => next = value;
        }


        public Node<T> Previous
        {
            get => previous;
            set => previous = value;
        }


        public T Value
        {
            get => item;
            set => item = value;
        }

        public void Clear()
        {
            next = null;
            previous = null;
        }
    }
}