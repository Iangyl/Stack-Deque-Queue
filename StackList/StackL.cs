using System.Collections.Generic;
using System.Linq;
using System;

namespace StackList
{
    class StackL
    {
        private List<string> items = new List<string>();
        public int CurrentSize { get; private set; }
        private string Head;
        public StackL()
        {
            CurrentSize = 0;
        }
        public string this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }   
        public bool IsEmpty() => CurrentSize == 0;
        public void Clear(ref StackL obj) => obj = new StackL();
        public string Top() => Head;
        public int Size() => CurrentSize;
        public void Push(string data)
        {
            items.Add(data);
            CurrentSize++;
            Head = items.Last();
        }
        public string Pop()
        {
            string temp = Head;
            items.Remove(Head);
            CurrentSize--;
            return temp;
        }
        public void Show()
        {
            foreach (string sr in items)
            {
                Console.WriteLine(sr);
            }
        }
    }
}
