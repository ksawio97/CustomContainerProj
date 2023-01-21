namespace CustomContainer
{
    class MyLinkedList<T>
    {
        public T value;

        public MyLinkedList<T> next;

        public MyLinkedList(T value, MyLinkedList<T> next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
}
