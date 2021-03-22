using System;
using System.Collections;
using System.Collections.Generic;

namespace ASD_lab5.Lists
{
    public class DefaultEnumerator<T> : LinkedListEnumerator<T>
    {
        private Node<T> node;
        private T current;
        private int count;

        public DefaultEnumerator(LinkedListBase<T> listBase) : base(listBase)
        {
            node = listBase.root;
            Console.WriteLine("ctor");
        }

        public override void Dispose()
        {
        }

        public override bool MoveNext()
        {
            if (node == null)
                return false;

            ++count;
            current = node.Value;
            Console.WriteLine("current");
            node = node.Next;
            return true;
        }

        public override void Reset()
        {
            current = default;
            node = list.root;
            count = 0;
        }

        public override T Current
        {
            get
            {
                if (count == 0 || count == list.Count + 1)
                    throw new InvalidOperationException();
                return current;
            }
        }
    }
}