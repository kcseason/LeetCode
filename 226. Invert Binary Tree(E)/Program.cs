using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226.Invert_Binary_Tree_E_
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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            if (root.left != null)
                InvertTree(root.left);
            if (root.right != null)
                InvertTree(root.right);
            return root;
        }
    }

    //public class Solution
    //{
    //    public TreeNode InvertTree(TreeNode root)
    //    {
    //        if (root == null)
    //            return null;
    //        if (root.left == null && root.right == null)
    //            return root;
    //        root.left = InvertTree(root.left);
    //        root.right = InvertTree(root.right);
    //        return root;
    //    }
    //}
}
