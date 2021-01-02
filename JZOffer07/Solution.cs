using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer07
{
    
    
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int len = preorder.Length;
            if (len == 0)
            {
                return null;
            }
            int value = preorder[0];
            TreeNode root = new TreeNode(value);
            if (len == 1)
            {
                return root;
            }
            int index = 0;
            for (; index < len; index++)
            {
                if (inorder[index] == value)
                {
                    break;
                }
            }

            int[] leftPre = new int[index];
            int[] leftIn = new int[index];
            int[] righrPre = new int[len - index - 1];
            int[] rightIn = new int[len - index - 1];
            Array.Copy(preorder, 1, leftPre, 0, index);
            Array.Copy(inorder, 0, leftIn, 0, index);
            Array.Copy(preorder, index + 1, righrPre, 0, len - index - 1);
            Array.Copy(inorder, index + 1, rightIn, 0, len - index - 1);
            root.left = BuildTree(leftPre, leftIn);
            root.right = BuildTree(righrPre, rightIn);
            return root;
        }
    }
}
