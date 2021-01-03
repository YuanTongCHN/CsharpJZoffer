using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer18
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            ListNode cur = head;
            ListNode pre = new ListNode(0);
            ListNode first = pre;
            pre.next = cur;
            while (cur != null && cur.val != val)
            {
                pre = cur;
                cur = cur.next;
            }
            if (cur != null)
            {
                pre.next = cur.next;
            }
            return first.next;
        }
    }
}
