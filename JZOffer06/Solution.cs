using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer06
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class Solution
    {
        public int[] ReversePrint(ListNode head)
        {
            ListNode temp;
            temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            int[] result = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                result[i] = head.val;
                head = head.next;
            }
            return result;
        }
    }
}
