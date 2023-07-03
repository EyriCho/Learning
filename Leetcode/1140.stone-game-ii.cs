/*
 * @lc app=leetcode id=1140 lang=csharp
 *
 * [1140] Stone Game II
 */

// @lc code=start
public class Solution {
    public int StoneGameII(int[] piles) {
        var dp = new int[piles.Length, piles.Length + 1];
        int sum = 0;

        for (int i = piles.Length - 1; i >= 0; i--)
        {
            sum += piles[i];
            for (int m = 1; m <= piles.Length; m++)
            {
                var max = m << 1;
                if (i + max >= piles.Length)
                {
                    dp[i, m] = sum;
                }
                else
                {
                    for (int take = 1; take <= max; take++)
                    {
                        dp[i, m] = Math.Max(dp[i, m],
                            sum - dp[i + take, Math.Max(m, take)]);
                    }
                }
            }
        }

        return dp[0, 1];
    }
}
// @lc code=end

