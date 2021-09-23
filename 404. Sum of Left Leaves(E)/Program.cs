using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404.Sum_of_Left_Leaves_E_
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
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left != null && (root.left.left == null && root.left.right == null))
                return root.left.val + SumOfLeftLeaves(root.right);
            return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        }
    }
}
