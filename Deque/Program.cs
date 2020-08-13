using System;

namespace Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            DequeA deque = new DequeA(5);
            for (int i = 0; i < 3; i++)
            {
                deque.PushFront(i + 1);
            }
            for (int i = 5; i > 3; i--)
            {
                deque.PushFront(i + 1);
            }
            deque.Show();
            //перевірка для задачі #8 (дек)
            DequeA dequeA = new DequeA(7);
            for (int i = 0; i < 7; i++)
            {
                if (i < deque.Length)
                {
                    dequeA.PushFront(deque.PopFront());
                    if (deque[i] % 2 == 0) dequeA.PushFront(0);
                }
            }
            Console.WriteLine("----------------------");
            dequeA.Show();
            //перевірка для завдання №6 (дек)
            //Console.WriteLine(deque.currentSize + " - current size");
            //Console.WriteLine(deque.ShowHead() + " - Head");
            //Console.WriteLine(deque.ShowTail() + " - Tail");
            //deque.PopFront();
            //deque.PopBack();
            //Console.WriteLine(deque.currentSize + " - current size");
            //Console.WriteLine(deque.ShowHead() + " - Head");
            //Console.WriteLine(deque.ShowTail() + " - Tail");
            //deque.Clear(ref deque);
            //Console.WriteLine(deque.currentSize + " - current size");
            //Console.WriteLine(deque.ShowHead() + " - Head");
            //Console.WriteLine(deque.ShowTail() + " - Tail");
        }
    }
}
