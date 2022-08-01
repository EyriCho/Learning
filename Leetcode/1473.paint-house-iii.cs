/*
 * @lc app=leetcode id=1473 lang=csharp
 *
 * [1473] Paint House III
 */

// @lc code=start
public class Solution {
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        const int MaxCost = 1_000_001;
        var dp = new int[m, target + 1, n];

        for (int h = 0; h < m; h++)
        {
            for (int t = 0; t <= target; t++)
            {
                for (int c = 0; c < n; c++)
                {
                    dp[h, t, c] = MaxCost;
                }
            }
        }

        for (int c = 1; c <= n; c++)
        {
            if (houses[0] == c)
            {
                dp[0, 1, c - 1] = 0;
            }
            else if (houses[0] == 0)
            {
                dp[0, 1, c - 1] = cost[0][c - 1];
            }
        }

        for (int h = 1; h < m; h++)
        {
            var maxTarget = Math.Min(target, h + 1);
            for (int neighbor = 1; neighbor <= maxTarget; neighbor++)
            {
                for (int c = 1; c <= n; c++)
                {
                    if (houses[h] != 0 && houses[h] != c)
                    {
                        continue;
                    }

                    int prevCost = MaxCost;
                    for (int prevColor = 1; prevColor <= n; prevColor++)
                    {
                        if (prevColor == c)
                        {
                            prevCost = Math.Min(prevCost, dp[h - 1, neighbor, c - 1]);
                        }
                        else
                        {
                            prevCost = Math.Min(prevCost, dp[h - 1, neighbor - 1, prevColor - 1]);
                        }
                    }

                    dp[h, t, c - 1] = prevCost +
                        (houses[h] == c ? 0 : cost[h][c - 1]);
                }
            }
        }

        var result = MaxCost;
        for (int c = 1; c <= n; c++)
        {
            result = Math.Min(result, dp[m - 1, target, c - 1]);
        }
        return result == MaxCost ? -1 : result;
    }
}
// @lc code=end

