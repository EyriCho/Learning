/*
 * @lc app=leetcode id=312 lang=csharp
 *
 * [312] Burst Balloons
 */

// @lc code=start
public class Solution {
    public int MaxCoins(int[] nums) {
        var dp = new int[nums.Length + 2, nums.Length + 2];
        
        var list = new List<int>(nums.Length + 2);
        list.Add(1);
        list.AddRange(nums);
        list.Add(1);
        
        for (int len = 1; len <= nums.Length; len++)
            for (int i = 1; i <= nums.Length - len + 1; i++)
            {
                int last = i + len - 1;
                for (int k = i; k <= last; k++)
                    dp[i, last] = Math.Max(dp[i, last],
                        list[i - 1] * list[k] * list[last + 1] + dp[i, k - 1] + dp[k + 1, last]);
            }
        
            return dp[1, nums.Length];
    }
}
// @lc code=end

