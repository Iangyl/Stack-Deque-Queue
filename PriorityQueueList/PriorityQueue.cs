using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueueList
{
    class PriorityQueue
    {
        private List<int> items = new List<int>();
        private int Head => items.Last();
        private int Tail => items.First();
        public int Count() => items.Count;
        public void Enqueue(int data)
        {
            items.Insert(0, data);
            items = SortQueue(items);
        }
        public int Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public int Peek() { return Head; }
        public void ShowQueue()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i] + " - " + items[i] % 10);
            }
        }
        private List<int> SortQueue(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if ((list[i] % 10) > (list[i + 1] % 10))
                {
                    int temp = list[i + 1];
                    list[i + 1] = list[i];
                    list[i] = temp;
                }
            }
            bool check = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if ((list[i] % 10) > (list[i + 1] % 10))
                {
                    check = false;
                    break;
                }
            }
            if (check == false) return SortQueue(list);
            else return list;
        }
    }
}
