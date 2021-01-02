using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer09
{
    public class CQueue
    {

        private Stack<int> stack1;
        private Stack<int> stack2;

        public CQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            stack1.Push(value);
        }

        public int DeleteHead()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                return -1;
            }
            else
            {
                if (stack2.Count != 0)
                {
                    int deleteItem = stack2.Pop();
                    return deleteItem;
                }
                else
                {
                    while (stack1.Count != 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                    int deleteItem = stack2.Pop();
                    return deleteItem;
                }
            }


        }
    }

    /**
     * Your CQueue object will be instantiated and called as such:
     * CQueue obj = new CQueue();
     * obj.AppendTail(value);
     * int param_2 = obj.DeleteHead();
     */
}
