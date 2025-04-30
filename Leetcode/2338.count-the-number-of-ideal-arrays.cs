/*
 * @lc app=leetcode id=2338 lang=csharp
 *
 * [2338] Count the Number of Ideal Arrays
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        long[,] dp = new long[maxValue + 1, 15];
        for (int i = 1; i <= maxValue; i++)
        {
            dp[i, 1] = 1L;
        }

        for (int j = 1; j < 14; j++)
        {
            for (int num = 1; num <= maxValue; num++)
            {
                for (int next = num * 2; next <= maxValue; next += num)
                {
                    dp[next, j + 1] = (dp[num, j] + dp[next, j + 1]) % 1_000_000_007L;
                }
            }
        }

        long[,] combines = new long[n, 15];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 15 && j <= i; j++)
            {
                if (j == 0)
                {
                    combines[i, j] = 1L;
                }
                else
                {
                    combines[i, j] = (combines[i - 1, j - 1] + combines[i - 1, j]) % 1_000_000_007L;
                }
            }
        }

        long result = 0;
        for (int num = 1; num <= maxValue; num++)
        {
            for (int j = 1; j <= 14 && j <= n; j++)
            {
                result = (result + dp[num, j] * combines[n - 1, j - 1]) % 1_000_000_007L;
            }
        }
        return (int)result;
    }
}
// @lc code=end

