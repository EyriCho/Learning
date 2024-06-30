/*
 * @lc app=leetcode id=1382 lang=csharp
 *
 * [1382] Balance a Binary Search Tree
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
    public TreeNode BalanceBST(TreeNode root) {
        List<int> list = new ();

        void Travel(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Travel(node.left);
            list.Add(node.val);
            Travel(node.right);
        }

        Travel(root);

        TreeNode Build(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            int m = array.Length >> 1;

            TreeNode rst = new (array[m]);
            rst.left = Build(array[0..m]);
            rst.right = Build(array[(m + 1)..]);

            return rst;
        }

        return Build(list.ToArray());
    }
}
// @lc code=end

