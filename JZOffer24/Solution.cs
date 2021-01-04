using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer24
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode temp = null;
            ListNode cur = head;
            ListNode pre = null;
            while (cur != null)
            {
                temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }
            return pre;


        }
    }
}
