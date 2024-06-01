/*
 * @lc app=leetcode id=514 lang=csharp
 *
 * [514] Freedom Trail
 */

// @lc code=start
public class Solution {
    public int FindRotateSteps(string ring, string key) {
        int[,] dp = new int[key.Length + 1, ring.Length];
        int diff = 0,
            step = 0;

        for (int k = key.Length - 1; k >= 0; k--)
        {
            for (int r = 0; r < ring.Length; r++)
            {
                dp[k, r] = int.MaxValue;
                for (int i = 0; i < ring.Length; i++)
                {
                    if (ring[i] == key[k])
                    {
                        diff = Math.Abs(i - r);
                        step = Math.Min(diff, ring.Length - diff);
                        dp[k, r] = Math.Min(dp[k, r], step + dp[k + 1, i]);
                    }
                }
            }
        }

        return dp[0, 0] + key.Length;
    }
}
// @lc code=end

