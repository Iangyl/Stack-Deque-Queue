using System;

namespace Deque
{
    class DequeA
    {
        private int[] array;
        public int currentSize { get; private set; }
        public int Length { get; private set; }

        protected int popBackIndex { get; private set; }
        protected int popFrontIndex { get; private set; }
        protected int TailIndex { get; private set; }
        public DequeA(int size)
        {
            Length = size;
            array = new int[size];
            currentSize = 0;
            TailIndex = Length - 1;
            popFrontIndex = 0;
            popBackIndex = TailIndex;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public int ShowHead() => array[popFrontIndex];
        public int ShowTail() => array[popBackIndex];
        public void Clear(ref DequeA obj) => obj = new DequeA(Length);
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool IsFull()
        {
            return currentSize == Length;
        }
        public void PushFront(int data)
        {
            if (!IsFull())
            {
                array[currentSize] = data;
                currentSize++;
            }
        }
        public void PushBack(int data)
        {
            if (!IsFull())
            {
                array[TailIndex] = data;
                TailIndex--;
                currentSize++;
            }
        }
        public int PopFront()
        {
            if (!IsEmpty())
            {
                int temp = array[popFrontIndex];
                popFrontIndex++;
                currentSize--;
                return temp;
            }
            else return -1;
        }
        public int PopBack()
        {
            if (!IsEmpty())
            {
                int temp = array[popBackIndex];
                popBackIndex--;
                currentSize--;
                return temp;
            }
            else return -1;
        }
        public void Show()
        {
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }
    }
}
