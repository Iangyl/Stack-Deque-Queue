using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackList
{
    class Program
    {
        enum People { Derek, Ivan, Angelina, Sophia};
        static void Main(string[] args)
        {
            StackL stack = new StackL();
            People people = People.Derek;
            for (int i = 0; i < 4; i++)
            {
                stack.Push(people.ToString());
                people++;
            }
            //Console.WriteLine(stack.Top());//source stack
            StackL stackL = new StackL();
            int border = stack.CurrentSize;
            for (int i = 0; i < border - 1; i++)
            {
                if (i % 2 == 0) stackL.Push(stack[stack.CurrentSize - 1]);
                stack.Pop();
            }
            Console.WriteLine(stackL.CurrentSize);//stack without even numbers of elements
            stackL.Show();
            
        }
    }
}
