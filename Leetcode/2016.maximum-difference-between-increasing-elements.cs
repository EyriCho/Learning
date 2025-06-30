/*
 * @lc app=leetcode id=2016 lang=csharp
 *
 * [2016] Maximum Difference Between Increasing Elements
 */

// @lc code=start
public class Solution {
    public int MaximumDifference(int[] nums) {
        int min = nums[0],
            result = -1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > min)
            {
                result = Math.Max(result, nums[i] - min);
            }
            min = Math.Min(min, nums[i]);
        }

        return result;
    }
}
// @lc code=end

