using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _637.Average_of_Levels_in_Binary_Tree_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode(3);
            TreeNode t1 = new TreeNode(9);
            TreeNode t2 = new TreeNode(20);
            TreeNode t21 = new TreeNode(15);
            TreeNode t22 = new TreeNode(7);
            t.left = t1;
            t.right = t2;
            t2.left = t21;
            t2.right = t22;

            IList<double> res = new Solution().AverageOfLevels(t);
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
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> res = new List<double>();
            Queue<TreeNode> tns = new Queue<TreeNode>();
            tns.Enqueue(root);
            while (tns.Count > 0)
            {
                double sum = 0;
                int length = tns.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode tn = tns.Dequeue();
                    sum += tn.val;
                    if (tn.left != null)
                        tns.Enqueue(tn.left);
                    if (tn.right != null)
                        tns.Enqueue(tn.right);
                }
                res.Add(sum / length);
            }

            return res;
        }
    }
}
