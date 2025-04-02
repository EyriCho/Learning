/*
 * @lc app=leetcode id=3105 lang=csharp
 *
 * [3105] Longest Strictly Increasing or Strictly Decreasing Subarray
 */

// @lc code=start
public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int longest = 1,
            increase = 1,
            decrease = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                increase++;
                decrease = 1;
            }
            else if (nums[i] < nums[i - 1])
            {
                increase = 1;
                decrease++;
            }
            else
            {
                increase = 1;
                decrease = 1;
            }

            longest = Math.Max(longest, increase);
            longest = Math.Max(longest, decrease);
        }

        return longest;
    }
}
// @lc code=end

