using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100.Same_Tree_E_
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
                return false;
            return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}
