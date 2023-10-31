/*
 * @lc app=leetcode id=2742 lang=csharp
 *
 * [2742] Painting the Walls
 */

// @lc code=start
public class Solution {
    public int PaintWalls(int[] cost, int[] time) {
        var dp = new int[cost.Length + 1];

        for (int i = 0; i < cost.Length; i++)
        {
            if (time[i] + 1 >= cost.Length)
            {
                if (dp[cost.Length] == 0 ||
                    cost[i] < dp[cost.Length])
                {
                    dp[cost.Length] = cost[i];
                }
            }
            else
            {
                for (int j = cost.Length; j > time[i] + 1; j--)
                {
                    var prev = j - time[i] - 1;
                    if (dp[prev] > 0 &&
                        (dp[j] == 0 || dp[j] > dp[prev] + cost[i]))
                    {
                        dp[j] = dp[prev] + cost[i]; 
                    }
                }

                for (int j = time[i] + 1; j > 0; j--)
                {
                    if (dp[j] == 0 || dp[j] > cost[i])
                    {
                        dp[j] = cost[i];
                    }
                }
            }
        }

        return dp[cost.Length];
    }
}
// @lc code=end

