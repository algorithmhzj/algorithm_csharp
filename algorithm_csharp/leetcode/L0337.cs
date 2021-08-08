using System;
using System.Collections.Generic;

namespace algorithm_csharp.leetcode
{
    public class L0337
    {
        
        public int Rob(TreeNode root)
        {
            return Rob(root, new Dictionary<TreeNode, int>(), new Dictionary<TreeNode, int>());
        }
        
        /**
         * max of the node
         */
        private int Rob(TreeNode node, Dictionary<TreeNode, int> dict, Dictionary<TreeNode, int> notDict)
        {
            if (node == null)
            {
                return 0;
            }

            if (dict.ContainsKey(node))
            {
                return dict[node];
            }
            var max = Math.Max(Rob(node.left, dict, notDict) + Rob(node.right, dict, notDict), node.val + RobNot(node.left, dict, notDict) + RobNot(node.right, dict, notDict));
            dict.Add(node, max);
            return max;
        }

        private int RobNot(TreeNode node, Dictionary<TreeNode, int> dict, Dictionary<TreeNode, int> notDict)
        {
            if (node == null)
            {
                return 0;
            }
            if (notDict.ContainsKey(node))
            {
                return dict[node];
            }

            var max = Rob(node.left, dict, notDict) + Rob(node.right, dict, notDict);
            notDict.Add(node, max);
            return max;
        }
        
    }
}