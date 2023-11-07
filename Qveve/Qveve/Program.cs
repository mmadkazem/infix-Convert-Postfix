using Queue;
using System;

namespace Qveve
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Queue is Empty!!!");
            }
        }

        private static Queue<int> reversQveve1(Queue<int> queue)
        {
            int[] qu = queue.ToArray();
            Queue<int> rev = new Queue<int>();
            for (int i = 0; i < queue.Count; i++)
            {
                rev.Enqueue(qu[queue.Count - i - 1]);
            }
            return rev;
        }

        private static Queue<int> reversQveve2(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queue.Count; i++) 
            {
                stack.Push(queue.Dequeue());
            }
            for (int i = 0; i < stack.Count; i++)
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        private static void Change(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
    }
}