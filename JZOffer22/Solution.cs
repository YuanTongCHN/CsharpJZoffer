using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer22
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {

            ListNode node1 = head;
            ListNode node2 = head;
            for (int i = 1; i <= k - 1; i++)
            {

                node1 = node1.next;
            }
            while (node1.next != null)
            {

                node1 = node1.next;

                node2 = node2.next;
            }
            return node2;
        }
    }
}
