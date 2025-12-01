/*
 * @lc app=leetcode id=3349 lang=csharp
 *
 * [3349] Adjacent Increasing Subarrays Detection I
 */

// @lc code=start
public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int[] dp = new int[nums.Count];
        dp[0] = 1;
        int count = 1;
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                ++count;
            }
            else
            {
                count = 1;
            }
            dp[i] = count;
        }

        for (int i = k; i < nums.Count; i++)
        {
            if (dp[i] >= k && dp[i - k] >= k)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

