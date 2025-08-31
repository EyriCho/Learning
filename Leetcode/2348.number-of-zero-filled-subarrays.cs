/*
 * @lc app=leetcode id=2348 lang=csharp
 *
 * [2348] Number of Zero-Filled Subarrays
 */

// @lc code=start
public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long result = 0L;
        int i = 0,
            l = -1;
        
        while (i < nums.Length)
        {
            if (nums[i] != 0)
            {
                l = i;
            }
            else
            {
                result += i - l;
            }

            i++;
        }

        return result;
    }
}
// @lc code=end

