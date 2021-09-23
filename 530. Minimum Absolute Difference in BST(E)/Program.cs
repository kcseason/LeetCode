using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _530.Minimum_Absolute_Difference_in_BST_E_
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
        int minDiff = int.MaxValue;
        TreeNode preNode = null;
        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null)
                return minDiff;
            InOrder(root);
            return minDiff;
        }

        public void InOrder(TreeNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            if (preNode != null)
                minDiff = Math.Min(minDiff, root.val - preNode.val);
            preNode = root;
            InOrder(root.right);
        }
    }
}
