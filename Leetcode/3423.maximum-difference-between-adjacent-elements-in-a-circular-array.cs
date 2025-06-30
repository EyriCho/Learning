/*
 * @lc app=leetcode id=3423 lang=csharp
 *
 * [3423] Maximum Difference Between Adjacent Elements in a Circular Array
 */

// @lc code=start
public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int result = Math.Abs(nums[0] - nums[^1]);
        for (int i = 1; i < nums.Length; i++)
        {
            result = Math.Max(result, Math.Abs(nums[i] - nums[i - 1]));
        }
        return result;
    }
}
// @lc code=end

