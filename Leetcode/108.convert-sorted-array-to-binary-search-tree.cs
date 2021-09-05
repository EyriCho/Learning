/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0)
            return null;
        
        var m = nums.Length / 2;
        var result = new TreeNode(nums[m]);
        result.left = SortedArrayToBST(nums[0..m]);
        result.right = SortedArrayToBST(nums[(m + 1)..nums.Length]);
        return result;
    }
}
// @lc code=end

