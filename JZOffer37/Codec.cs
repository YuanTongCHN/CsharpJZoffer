using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpJZoffer.JZOffer37
{

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return "";
            //string result = "[";
            StringBuilder res = new StringBuilder();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();
                if (node != null)
                {
                    //result = result + node.val.ToString() + ",";
                    res.Append(node.val);
                    res.Append(",");
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else
                {
                    //result = result + "null，";
                    res.Append("null,");
                }
            }
            //result.Remove(result.Length - 1);
            //result += "]";
            //return result;
            res.Remove(res.Length - 1, 1);
            return res.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == "") return null;
            // data = data.Remove(0);
            // data = data.Remove(data.Length - 1);
            string[] dataSplit = data.Split(",");
            if (dataSplit[0] == "null") return null;
            TreeNode head = new TreeNode(int.Parse(dataSplit[0]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(head);
            int i = 1;
            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();
                if (dataSplit[i] != "null")
                {
                    node.left = new TreeNode(int.Parse(dataSplit[i]));
                    queue.Enqueue(node.left);
                }
                i++;
                if (dataSplit[i] != "null")
                {
                    node.right = new TreeNode(int.Parse(dataSplit[i]));
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return head;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
}
