using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer30
{
    public class MinStack
    {
        Stack<int> stack;
        Stack<int> minQueue;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<int>();
            minQueue = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
            if (minQueue.Count == 0 || x <= minQueue.Peek())
            {
                minQueue.Push(x);
            }
        }

        public void Pop()
        {
            int x = stack.Pop();
            if (x == minQueue.Peek())
            {
                minQueue.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int Min()
        {
            return minQueue.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.Min();
     */
}
