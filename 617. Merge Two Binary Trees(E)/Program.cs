using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617.Merge_Two_Binary_Trees_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(3);
            TreeNode t12 = new TreeNode(2);
            TreeNode t111 = new TreeNode(5);
            t1.left = t11;
            t1.right = t12;
            t11.left = t111;

            TreeNode t2 = new TreeNode(2);
            TreeNode t21 = new TreeNode(1);
            TreeNode t22 = new TreeNode(3);
            TreeNode t212 = new TreeNode(4);
            TreeNode t222 = new TreeNode(7);
            t2.left = t21;
            t2.right = t22;
            t21.right = t212;
            t22.right = t222;

            TreeNode tn = new Solution().MergeTrees(t1, t2);
            PreOrder(tn);

            Console.ReadLine();
        }

        private static void PreOrder(TreeNode tn)
        {
            if (tn == null)
                return;

            Console.Write(tn.val + " ");
            PreOrder(tn.left);
            PreOrder(tn.right);
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    //[1,3,2,5]
    //[2,1,3,null,4,null,7]

    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;
            TreeNode tn = new TreeNode(t1.val + t2.val);
            tn.left = MergeTrees(t1.left, t2.left);
            tn.right = MergeTrees(t1.right, t2.right);
            return tn;
        }
    }
}
