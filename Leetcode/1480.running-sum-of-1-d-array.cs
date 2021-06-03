/*
 * @lc app=leetcode id=1480 lang=csharp
 *
 * [1480] Running Sum of 1d Array
 */

// @lc code=start
public class Solution {
    public int[] RunningSum(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}
// @lc code=end

