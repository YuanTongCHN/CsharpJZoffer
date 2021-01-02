using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer28
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
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return Recur(root.left, root.right);
        }
        public bool Recur(TreeNode L, TreeNode R)
        {
            if (L == null && R == null)
            {
                return true;
            }
            if (L == null || R == null)
            {
                return false;
            }
            return L.val == R.val && Recur(L.left, R.right) && Recur(L.right, R.left);
        }
    }
}
