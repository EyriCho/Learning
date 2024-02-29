/*
 * @lc app=leetcode id=1043 lang=csharp
 *
 * [1043] Partition Array for Maximum Sum
 */

// @lc code=start
public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int[] dp = new int[arr.Length + 1];
        dp[1] = arr[0];

        for (int i = 1; i <= arr.Length; i++)
        {
            int max = arr[i - 1];
            for (int j = i - 1; j >= 0 && j >= i - k; j--) 
            {
                dp[i] = Math.Max(dp[i], dp[j] + max * (i - j));
                
                if (j > 0)
                {
                    max = Math.Max(max, arr[j - 1]);
                }
            }
        }

        return dp[arr.Length];
    }
}
// @lc code=end

