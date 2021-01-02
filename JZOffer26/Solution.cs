using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer26
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (A == null || B == null)
            {
                return false;
            }
            return Recur(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B);
        }
        public bool Recur(TreeNode A, TreeNode B)
        {
            if (B == null)
            {
                return true;
            }
            if (A == null)
            {
                return false;
            }
            if (A.val != B.val)
            {
                return false;
            }
            return Recur(A.left, B.left) && Recur(A.right, B.right);
        }
    }
}
