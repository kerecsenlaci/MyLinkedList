using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class MyLinkedList<T> : IList<T>  where T : class
    {
        class ListItem
        {
            public T Value { get; set; }
            public ListItem Next { get; set; }
        }
        ListItem _head;

        public int Count { get { throw new NotImplementedException(); } }
        public bool IsReadOnly { get {return false;} }

        public T this[int index] {
            get {
                var current = _head;
                var count = 0;
                while (current.Next != null)
                {
                    if (count == index)
                        return current.Value;
                    count++;
                    current = current.Next;
                }
                if (count == index)
                    return current.Value;
                throw new IndexOutOfRangeException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public MyLinkedList()
        {
            _head = null;
        }

        public void InsertAtStart(T value)
        {
            var newItem = new ListItem();
            newItem.Value = value;
            newItem.Next = _head;
            _head = newItem;
        }

        public void InsertAtEnd(T value)
        {
            if (_head == null)
                InsertAtStart(value);
            else
            {
                var newItem = new ListItem();
                newItem.Value = value;
                newItem.Next = null;
                var current = _head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newItem;
            }
        }

        public bool Remove(T value)
        {
            var current = _head;
            var prev = default(ListItem);
            while (current != null && current.Value != value)
            {
                prev = current;
                current = current.Next;
            }
            if (current == null)
                return false;
            if (prev == null)
                _head = current.Next;
            else
                prev.Next = current.Next;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            int count = 0;

            return count;

        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            InsertAtEnd(item);
        }

        public void Clear()
        {
            _head = null;
        }

        public bool Contains(T item)
        {
            var current = _head;
            while (current.Next != null)
            {
                if (current.Value == item)
                    return true;
                current = current.Next;
            }
                
            return false;

        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

    }

}

