using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer52
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            int countA = 1;
            ListNode nodeA = headA;
            ListNode nodeB = headB;
            int countB = 1;
            int d = 0;
            while (true)
            {
                if (nodeA.next != null)
                {
                    countA++;
                    nodeA = nodeA.next;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (nodeB.next != null)
                {
                    countB++;
                    nodeB = nodeB.next;
                }
                else
                {
                    break;
                }
            }
            nodeA = headA;
            nodeB = headB;
            if (countA > countB)
            {
                d = countA - countB;
                for (int i = 0; i < d; i++)
                {
                    nodeA = nodeA.next;
                }
            }
            if (countA < countB)
            {
                d = countB - countA;
                for (int i = 0; i < d; i++)
                {
                    nodeB = nodeB.next;
                }
            }
            while (nodeA != nodeB)
            {
                nodeA = nodeA.next;
                nodeB = nodeB.next;
            }
            return nodeA;
        }
    }
}
