/*
 * @lc app=leetcode id=3350 lang=csharp
 *
 * [3350] Adjacent Increasing Subarrays Detection II
 */

// @lc code=start
public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        int count = 1,
            prev = 0,
            result = 0;
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                count++;
            }
            else
            {
                prev = count;
                count = 1;
            }

            result = Math.Max(result, Math.Min(prev, count));
            result = Math.Max(result, count >> 1);
        }

        return result;
    }
}
// @lc code=end

