using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildTree();
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        private static void BuildTree()
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(2);
            TreeNode t12 = new TreeNode(3);
            TreeNode t111 = new TreeNode(4);
            t1.left = t11;
            t1.right = t12;
            t11.left = t111;
            new Solution().FindTilt(t1);
        }
    }
}
