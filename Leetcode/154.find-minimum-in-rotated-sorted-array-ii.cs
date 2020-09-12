/*
 * @lc app=leetcode id=154 lang=csharp
 *
 * [154] Find Minimum in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        
        var result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] > nums[i])
                return nums[i];
        }
        return result;        
    }
}
// @lc code=end

