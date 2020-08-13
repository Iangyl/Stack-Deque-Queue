using System;

namespace Stucks_Decks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueP queueP = new QueueP(10);
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int local = random.Next(0, 100);
                queueP.Push(local, local % 10);
            }
            queueP.Show();
            queueP.Pop();
            Console.WriteLine("result: ");
            queueP.Show();
        }
    }
}
