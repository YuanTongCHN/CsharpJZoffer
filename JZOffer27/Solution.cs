using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer27
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
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Reverse(root);
            return root;
        }
        public void Reverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Reverse(node.left);
            Reverse(node.right);
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;
        }
    }
}
