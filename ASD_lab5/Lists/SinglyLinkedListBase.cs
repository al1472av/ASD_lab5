using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace ASD_lab5.Lists
{
    public class SinglyLinkedListBase<T> : LinkedListBase<T>, IEnumerable<T>
    {
        public override int Count => count;
        private int count;

        public override void Add(T obj)
        {
            Node<T> target = new Node<T>(obj);
            if (root == null)
                root = target;
            else
            {
                Node<T> temp = root;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = target;
            }

            count++;
        }

        public override void Clear()
        {
            root = null;
            count = 0;
        }

        public IEnumerator<T> GetEnumerator() => enumerator;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        public SinglyLinkedListBase(LinkedListEnumerator<T> enumerator = null) : base(enumerator)
        {
            if (enumerator == null)
                enumerator = new DefaultEnumerator<T>(this);
            this.enumerator = enumerator;
        }

        public SinglyLinkedListBase(IEnumerable<T> source, LinkedListEnumerator<T> enumerator = null) : base(source,
            enumerator)
        {
            
            Clear();
            foreach (var t in source)
                Add(t);
            if (enumerator == null)
                enumerator = new DefaultEnumerator<T>(this);
            this.enumerator = enumerator;
        }
    }
}