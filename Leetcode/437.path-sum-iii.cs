/*
 * @lc app=leetcode id=437 lang=csharp
 *
 * [437] Path Sum III
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
    public int PathSum(TreeNode root, int sum) {
        list = new List<TreeNode>();
        result = 0;
        help(root, sum, 0);
        return result;
    }
    IList<TreeNode> list;
    int result;
    
    private void help(TreeNode node, int sum, int curSum)
    {
        if (node == null) return;
        curSum += node.val;
        list.Add(node);
        if (curSum == sum) result++;
        int temp = curSum;
        for (int i = 0; i < list.Count - 1; i++)
        {
            temp -= list[i].val;
            if (temp == sum) result++;
        }
        help(node.left, sum, curSum);
        help(node.right, sum, curSum);
        list.RemoveAt(list.Count - 1);
    }
}
// @lc code=end

