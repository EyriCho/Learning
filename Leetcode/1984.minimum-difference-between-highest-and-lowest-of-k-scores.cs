/*
 * @lc app=leetcode id=1984 lang=csharp
 *
 * [1984] Minimum Difference Between Highest and Lowest of K Scores
 */

// @lc code=start
public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);

        int result = nums[^1] - nums[0];

        for (int l = 0, r = k - 1; r < nums.Length; l++, r++)
        {
            result = Math.Min(result, nums[r] - nums[l]);
        }

        return result;
    }
}
// @lc code=end

