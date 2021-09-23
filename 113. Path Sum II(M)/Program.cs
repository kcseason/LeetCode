using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113.Path_Sum_II_M_
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
        IList<IList<int>> res;
        IList<int> elements;
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null)
                return res;

            res = new List<IList<int>>();
            elements = new List<int>();
            FindPath(root, sum);
            return res;
        }

        private void FindPath(TreeNode root, int sum)
        {
            if (root == null)
                return;

            elements.Add(root.val);
            if (root.left == null && root.right == null && root.val == sum)
                res.Add(elements);

            if (root.left != null)
                FindPath(root.left, sum - root.val);
            if (root.right != null)
                FindPath(root.right, sum - root.val);

            elements.RemoveAt(elements.Count - 1);
        }
    }

    public class Solution2
    {
        public IList<IList<int>> pathSum(TreeNode root, int sum)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            helper(root, sum, new List<int>(), res);
            return res;
        }
        void helper(TreeNode root, int sum, IList<int> list, IList<IList<int>> res)
        {
            if (root.left == null && root.right == null)
            {
                if (sum - root.val == 0)
                {
                    list.Add(root.val);
                    res.Add(list);
                    list.Remove(list.Count - 1);
                }
                return;
            }
            if (root.left != null)
            {
                list.Add(root.val);
                helper(root.left, sum - root.val, list, res);
                list.Remove(list.Count - 1);
            }
            if (root.right != null)
            {
                list.Add(root.val);
                helper(root.right, sum - root.val, list, res);
                list.Remove(list.Count - 1);
            }
            return;
        }
    }
}
