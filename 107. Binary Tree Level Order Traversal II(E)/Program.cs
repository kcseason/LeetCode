using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107.Binary_Tree_Level_Order_Traversal_II_E_
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null)
                return res;
            var tns = new Queue<TreeNode>();
            tns.Enqueue(root);
            while (tns.Count > 0)
            {
                var elements = new List<int>();
                int length = tns.Count;
                for (int i = 0; i < length; i++)
                {
                    var tn = tns.Dequeue();
                    elements.Add(tn.val);
                    if (tn.left != null)
                        tns.Enqueue(tn.left);
                    if (tn.right != null)
                        tns.Enqueue(tn.right);
                }
                res.Add(elements);
            }

            res.Reverse();
            return res;
        }
    }
}
