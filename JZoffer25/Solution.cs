﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZoffer25
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode head = new ListNode(0);
            ListNode cur = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                cur = cur.next;
            }
            if (l1 == null)
            {
                cur.next = l2;
            }
            else
            {
                cur.next = l1;
            }
            return head.next;
        }
    }
}
