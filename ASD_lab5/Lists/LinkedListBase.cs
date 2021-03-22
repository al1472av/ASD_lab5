using System.Collections.Generic;

namespace ASD_lab5.Lists
{
    public abstract class LinkedListBase<T>
    {
        public Node<T> root;
        protected IEnumerator<T> enumerator;

        public LinkedListBase(IEnumerator<T> enumerator)
        {
        }
        
        public LinkedListBase(IEnumerable<T> source, IEnumerator<T> enumerator)
        {
        }

        public LinkedListBase()
        {
            
        }

        public abstract int Count { get; }
        
        public abstract void Add(T obj);
        public abstract void Clear();
    }
}