/*
 * @lc app=leetcode id=2348 lang=csharp
 *
 * [2348] Number of Zero-Filled Subarrays
 */

// @lc code=start
public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        var result = 0L;

        int i = 0;
        while (i < nums.Length)
        {
            while (i < nums.Length && nums[i] != 0)
            {
                i++;
            }

            var l = i;

            while (i < nums.Length && nums[i] == 0)
            {
                i++;
            }

            long count = i - l;
            result += (count + 1) * count / 2;
        }

        return result;
    }
}
// @lc code=end

