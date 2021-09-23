using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112.Path_Sum_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(-2);
            TreeNode t12 = new TreeNode(-3);
            TreeNode t111 = new TreeNode(1);
            TreeNode t112 = new TreeNode(3);
            TreeNode t121 = new TreeNode(-2);
            TreeNode t1111 = new TreeNode(-1);
            t1.left = t11;
            t1.right = t12;
            t11.left = t111;
            t11.right = t112;
            t12.left = t121;
            t111.left = t1111;

            var bl = new Solution().HasPathSum(t1, 3);
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
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            else if (root.left == null && root.right == null && root.val == sum)
                return true;
            else
                return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
