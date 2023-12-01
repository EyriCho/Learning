/*
 * @lc app=leetcode id=501 lang=csharp
 *
 * [501] Find Mode in Binary Search Tree
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
    public int[] FindMode(TreeNode root) {
        List<int> list = new();
        int lastVal = int.MinValue,
            count = 0,
            max = 0;

        void Travel(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Travel(node.left);
            count = node.val == lastVal ? (count + 1) : 1;
            if (count > max)
            {
                max = count;
                list.Clear();
                list.Add(node.val);
            }
            else if (count == max)
            {
                list.Add(node.val);
            }
            lastVal = node.val;
            Travel(node.right);
        }
        Travel(root);

        return list.ToArray();
    }
}
// @lc code=end

