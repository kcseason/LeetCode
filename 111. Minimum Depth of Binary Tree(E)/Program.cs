using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111.Minimum_Depth_of_Binary_Tree_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(2);
            t1.left = t11;

            int i = new Solution().MinDepth(t1);
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
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftDepth = MinDepth(root.left);
            int rightDepth = MinDepth(root.right);
            if (leftDepth == 0 && rightDepth == 0)
                return 1;
            if (leftDepth == 0)
                return rightDepth + 1;
            if (rightDepth == 0)
                return leftDepth + 1;
            return Math.Min(leftDepth, rightDepth) + 1;
        }
    }
}
