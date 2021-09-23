using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _257.Binary_Tree_Paths_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(2);
            t1.left = t11;

            new Solution().BinaryTreePaths(t1);
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
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var ans = new List<string>();
            if (root != null)
                SearchPaths(root, "", ans);
            return ans;
        }

        public void SearchPaths(TreeNode tn, string path, List<string> ans)
        {
            if (tn.left == null && tn.right == null)
                ans.Add(path + tn.val);
            if (tn.left != null)
                SearchPaths(tn.left, path + tn.val + "->", ans);
            if (tn.right != null)
                SearchPaths(tn.right, path + tn.val + "->", ans);
        }
    }
}
