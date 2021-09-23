using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _606.Construct_String_from_Binary_Tree_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            TreeNode t11 = new TreeNode(2);
            TreeNode t12 = new TreeNode(3);
            TreeNode t111 = new TreeNode(4);
            t1.left = t11;
            t1.right = t12;
            t11.left = t111;

            new Solution().Tree2str(t1);
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
        public string Tree2str(TreeNode t)
        {
            if (t == null)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append(t.val);
            if (t.left != null && t.right == null)
                sb.Append("(").Append(Tree2str(t.left)).Append(")");
            else if (t.right != null)
                sb.Append("(").Append(Tree2str(t.left)).Append(")")
                    .Append("(").Append(Tree2str(t.right)).Append(")");
            return sb.ToString();
        }
    }
}
