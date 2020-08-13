using System;

namespace PriorityQueueList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var numbers = new PriorityQueue();
            for (int i = 0; i < 10; i++)
            {
                int temp = random.Next(0, 100);
                numbers.Enqueue(temp);
            }
            numbers.ShowQueue();
            Console.WriteLine("Remove value:");
            numbers.Dequeue();
            numbers.ShowQueue();
        }
    }
}
