using System;

namespace Stucks_Decks_Queues
{
    class QueueP
    {
        private int[] array { get; set; }
        private int[] priority { get; set; }
        private int maxSize;
        public int currentSize { get; private set; }

        public QueueP(int length)
        {
            maxSize = length;
            array = new int[maxSize];
            priority = new int[maxSize];
            currentSize = 0;
        }
        public void Show()
        {
            for (int i = 0; i < currentSize; i++)
            {
                Console.WriteLine(array[i] + " - " + priority[i] + "\n\n");
            }
        }
        public void Clear()
        {
            currentSize = 0;
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool IsFull()
        {
            return currentSize == maxSize;
        }
        public int GetCount()
        {
            return currentSize;
        }
        public void Push(int element, int prior)
        {
            if (!IsFull())
            {
                array[currentSize] = element;
                priority[currentSize] = prior;
                currentSize++;
            }
        }
        public int Pop()
        {
            if (!IsEmpty())
            {
                int max_pri = priority[0];//priority element
                int max_priIndex = 0;//priority index

                //find more priority mean
                for (int i = 0; i < currentSize; i++)
                {
                    if ((max_pri % 10) < (priority[i] % 10))
                    {
                        max_pri = priority[i];
                        max_priIndex = i;
                    }
                }
                int temp1 = array[max_priIndex];
                int temp2 = priority[max_priIndex];

                for (int i = max_priIndex; i < currentSize - 1; i++)
                {
                    array[i] = array[i + 1];
                    priority[i] = priority[i + 1];
                }
                //reduce quantity
                currentSize--;
                //come back	
                return temp1;
            }
            else return -1;
        }
    }
}
