/*
 * @lc app=leetcode id=3336 lang=csharp
 *
 * [3336] Find the Number of Subsequences With Equal GCD
 */

// @lc code=start
public class Solution {
    public int SubsequencePairCount(int[] nums) {
        const int mod = 1_000_000_007;
        int max = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
        }

        int Gcd(int a, int b)
        {
            int temp = 0;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }

        int[,] prev = new int[max + 1, max + 1],
            dp = new int[max + 1, max + 1];
        prev[0, 0] = 1;

        int gcd1 = 0,
            gcd2 = 0;
        foreach (int num in nums)
        {
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j <= max; j++)
                {
                    dp[i, j] = 0;
                }
            }
            for (int i = 0; i <= max; i++)
            {
                gcd1 = Gcd(i, num);
                for (int j = 0; j <= max; j++)
                {
                    if (prev[i, j] == 0)
                    {
                        continue;
                    }

                    gcd2 = Gcd(j, num);
                    dp[i, j] = (prev[i, j] + dp[i, j]) % mod;
                    dp[gcd1, j] = (prev[i, j] + dp[gcd1, j]) % mod;
                    dp[i, gcd2] = (prev[i, j] + dp[i, gcd2]) % mod;
                }
            }

            (prev, dp) = (dp, prev);
        }

        int result = 0;
        for (int i = 1; i <= max; i++)
        {
            result = (result + prev[i, i]) % mod;
        }

        return result;
    }
}
// @lc code=end

