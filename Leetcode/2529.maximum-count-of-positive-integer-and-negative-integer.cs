/*
 * @lc app=leetcode id=2529 lang=csharp
 *
 * [2529] Maximum Count of Positive Integer and Negative Integer
 */

// @lc code=start
public class Solution {
    public int MaximumCount(int[] nums) {
        int negative = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                negative = i + 1;
            }
            else if (nums[i] > 0)
            {
                return Math.Max(negative, nums.Length - i);
            }
        }

        return negative;
    }
}
// @lc code=end

