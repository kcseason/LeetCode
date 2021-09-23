using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _538.Convert_BST_to_Greater_Tree_E_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Solution
    {
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
                return null;
            ConvertBST(root.right);
            root.val += sum;
            sum = root.val;
            ConvertBST(root.left);

            return root;
        }
    }
}
