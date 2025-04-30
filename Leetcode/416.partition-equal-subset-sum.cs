/*
 * @lc app=leetcode id=416 lang=csharp
 *
 * [416] Partition Equal Subset Sum
 */

// @lc code=start
public class Solution {
    public bool CanPartition(int[] nums) {
        if (nums.Length == 1)
        {
            return false;
        }

        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        if ((sum & 1) == 1)
        {
            return false;
        }

        sum >>= 1;
        bool[] dp = new bool[sum + 1];
        dp[0] = true;
        foreach (int num in nums)
        {
            for (int i = sum; i >= num; i--)
            {
                dp[i] |= dp[i - num];
            }
        }

        return dp[sum];
    }
}
// @lc code=end

