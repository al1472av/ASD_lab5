using System.Collections;
using System.Collections.Generic;

namespace ASD_lab5.Lists
{
    public abstract class LinkedListEnumerator<T> : IEnumerator<T>
    {

        protected LinkedListBase<T> list;
        
        protected LinkedListEnumerator(LinkedListBase<T> list)
        {
            this.list = list;
        }

        public abstract void Dispose();
        public abstract bool MoveNext();
        public abstract void Reset();
        public abstract T Current { get; }

        object IEnumerator.Current => Current;
    }
}