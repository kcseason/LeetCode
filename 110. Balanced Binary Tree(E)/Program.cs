using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110.Balanced_Binary_Tree_E_
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
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            int leftDepth = Depth(root.left);
            int rightDepth = Depth(root.right);
            if (Math.Abs(leftDepth - rightDepth) <= 1)
                if (IsBalanced(root.left) && IsBalanced(root.right))
                    return true;

            return false;
        }
        public int Depth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(Depth(root.left), Depth(root.right)) + 1;
        }
    }
}
