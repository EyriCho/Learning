/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0],
            current = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            current = Math.Max(nums[i], nums[i] + current);
            max = Math.Max(max, current);
        }
        
        return max;
    }
}
// @lc code=end

