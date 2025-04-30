/*
 * @lc app=leetcode id=2444 lang=csharp
 *
 * [2444] Count Subarrays With Fixed Bounds
 */

// @lc code=start
public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long result = 0;
        for (int i = 0, outScope = -1, min = -1, max = -1;
            i < nums.Length;
            i++)
        {
            if (nums[i] < minK || nums[i] > maxK)
            {
                outScope = i;
                min = max = -1;
            }
            else
            {
                if (nums[i] == minK)
                {
                    min = i;
                }
                if (nums[i] == maxK)
                {
                    max = i;
                }
                if (min > -1 && max > -1)
                {
                    result += Math.Min(min, max) - outScope;
                }
            }
        }

        return result;
    }
}
// @lc code=end

