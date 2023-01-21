using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomContainer
{
    public class MyList<T>: IEnumerable<T>
    {
        private int _count;

        public int Count { get { return _count; } }

        MyLinkedList<T> head;

        public void Append(T value)
        {
            if (head == null)
                head = new MyLinkedList<T>(value);
            else
                Add(value);
            _count++;
        }

        private void Add(T value)
        {
            int lastElementIndex = Count - 1;
            GoTo(lastElementIndex).next = new MyLinkedList<T>(value);
        }

        private MyLinkedList<T> GoTo(int index)
        {
            var curr = head;
            for (int i = 0; i < index; i++)
                curr = curr.next;

            return curr;
        }

        private void CheckIndex(int index)
        {
            if (Count <= index)
                new IndexOutOfRangeException($"{Count - 1} is max index");
            if (index < 0)
                new IndexOutOfRangeException($"Min index is 0");
        }
        private T GetValue(int index)
        {
            CheckIndex(index);
            return GoTo(index).value;
        }

        private void SetValue(int index, T value)
        {
            CheckIndex(index);
            GoTo(index).value = value;
        }


        public void Clear()
        {
            head = null;
            _count = 0;
        }

        public T this[int index]
        {
            get => GetValue(index);
            set => SetValue(index, value);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (var curr = head; curr != null; curr = curr.next)
                yield return curr.value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
