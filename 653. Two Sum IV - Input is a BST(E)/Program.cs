using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _653.Two_Sum_IV___Input_is_a_BST_E_
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
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null || (root.left == null && root.right == null))
                return false;
            var values = new HashSet<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode tn = queue.Dequeue();
                    if (values.Contains(k - tn.val))
                        return true;
                    else
                        values.Add(tn.val);
                    if (tn.left != null)
                        queue.Enqueue(tn.left);
                    if (tn.right != null)
                        queue.Enqueue(tn.right);
                }
            }
            return false;
        }
    }

    //public class Solution
    //{
    //    public bool FindTarget(TreeNode root, int k)
    //    {
    //        var hash = new HashSet<int>();
    //        return dfs(root, hash, k);
    //    }
    //    private bool dfs(TreeNode root, HashSet<int> hash, int k)
    //    {
    //        if (root == null)
    //            return false;
    //        if (hash.Contains(k - root.val))
    //            return true;
    //        hash.Add(root.val);
    //        return dfs(root.left, hash, k) || dfs(root.right, hash, k);
    //    }
    //}
}
