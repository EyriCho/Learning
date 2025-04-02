/*
 * @lc app=leetcode id=1749 lang=csharp
 *
 * [1749] Maximum Absolute Sum of Any Subarray
 */

// @lc code=start
public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int min = 0,
            max = 0,
            result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(0, max + nums[i]);
            min = Math.Min(0, min + nums[i]);
            result = Math.Max(result, Math.Max(-min, max));
        }

        return result;
    }
}
// @lc code=end

