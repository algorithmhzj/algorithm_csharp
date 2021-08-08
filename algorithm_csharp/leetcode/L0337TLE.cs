using System;

namespace algorithm_csharp.leetcode
{
    public class L0337TLE
    {
        /**
         * max of the node
         */
        public int Rob(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(root.val + RobNot(root.left) + RobNot(root.right), Rob(root.left) + Rob(root.right));
        }

        public int RobNot(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Rob(root.left) + Rob(root.right);
        }
        
    }
}