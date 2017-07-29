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

        class MyListEnumerator : IEnumerator<T>
        {
            int index = -1;
            MyLinkedList<T> _theList;

            public MyListEnumerator(MyLinkedList<T> theList)
            {
                _theList = theList;
            }


            public T Current
            {
                get
                {
                    if (index < 0 || _theList.Count <= index)
                        return default(T);
                    return _theList[index];
                }
            }

            object IEnumerator.Current { get { return Current; } }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++index < _theList.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }

        ListItem _head;

        public int Count { get; private set; }
        public bool IsReadOnly { get; } = false;

        ListItem ElementAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            var count = 0;
            var current = _head;
            while (count++ != index)
                current = current.Next;
            return current;
        }

        public T this[int index]
        {
            get
            {
                var current = ElementAt(index);
                return current.Value;
            }
            set
            {
                var current = ElementAt(index);
                current.Value = value;
            }
        }

        public MyLinkedList()
        {
            _head = null;
        }

        public bool Remove(T value)
        {
            var current = _head;
            var prev = default(ListItem);
            while (current != null &&
                  current.Value != value)
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
            Count--;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            if (Count == 0) //_head == null
                return -1;
            var current = _head;
            var index = 0;
            while (index != Count - 1 &&
                current.Value != item)
            {
                current = current.Next;
                index++;
            }
            if (current.Value == item)
                return index;
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= Count)
                throw new InvalidOperationException();
            var newItem = new ListItem
            {
                Value = item
            };
            if (index == 0)
            {
                newItem.Next = _head;
                _head = newItem;
            }
            else
            {
                var prev = ElementAt(index - 1);
                newItem.Next = prev.Next;
                prev.Next = newItem;
            }
            Count++;
        }

        public void RemoveAt(int index)
        {
            
            var current = _head;
            var prev = default(ListItem);
            var count = 0;
            if (Count < index || current == null)
                return;

            Count--;
            while (count!=index)
            {
                prev = current;
                current = current.Next;
                count++;
            }
           
            if (prev == null)
                _head = current.Next;
            else
                prev.Next = current.Next;
            //Count--;
        }

        public void Add(T item)
        {
            Count++;
            if (_head == null)
            {
                var newItem = new ListItem();
                newItem.Value = item;
                _head = newItem;
            }
            else
            {
                var newItem = new ListItem
                {
                    Value = item,
                    Next = null
                };
                //var newItem = new ListItem();
                //newItem.Value = item;
                //newItem.Next = null;

                var current = _head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newItem;
            }
        }

        public void Clear()
        {
            Count = 0;
            _head = null;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        { 
            for (int i = 0; i < array.Length; i++)
                array[i] = this[arrayIndex++];
        }
    }
}

