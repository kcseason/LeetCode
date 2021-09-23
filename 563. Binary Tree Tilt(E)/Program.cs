using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _563.Binary_Tree_Tilt_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(2);
            TreeNode t12 = new TreeNode(3);
            t1.left = t11;
            t1.right = t12;

            new Solution().FindTilt(t1);
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
        public int FindTilt(TreeNode root)
        {
            Helper(root);
            return sum;
        }

        public int Helper(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = Helper(root.left);
            int right = Helper(root.right);
            sum += Math.Abs(left - right);
            return root.val + left + right;
        }
    }
}
