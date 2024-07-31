/*
 * @lc app=leetcode id=1110 lang=csharp
 *
 * [1110] Delete Nodes And Return Forest
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        HashSet<int> set = new (to_delete);
        set.Add(0);
        List<TreeNode> result = new ();

        TreeNode temp = new (0, root);

        void Travel(TreeNode node, TreeNode parent)
        {
            if (node == null)
            {
                return;
            }

            if (set.Contains(node.val))
            {
                if (parent.left == node)
                {
                    parent.left = null;
                }
                else
                {
                    parent.right = null;
                }

                if (node.left != null &&
                    !set.Contains(node.left.val))
                {
                    result.Add(node.left);
                }

                if (node.right != null &&
                    !set.Contains(node.right.val))
                {
                    result.Add(node.right);
                }
            }

            Travel(node.left, node);
            Travel(node.right, node);
        }

        Travel(root, temp);
        if (!set.Contains(root.val))
        {
            result.Add(root);
        }
        return result;
    }
}
// @lc code=end

