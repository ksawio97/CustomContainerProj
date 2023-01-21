using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomContainer
{
    public class MyList<T>
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
            var curr = head;
            while (curr.next != null)
                curr = curr.next;
            curr.next = new MyLinkedList<T>(value);
        }

        public T Show(int index)
        {
            if (Count <= index)
                new IndexOutOfRangeException($"{Count - 1} is max index");

            var curr = head;
            while ((index--) != 0)
            {
                curr = curr.next;
            }

            return curr.value;
        }
    }
}
