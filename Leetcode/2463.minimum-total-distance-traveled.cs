/*
 * @lc app=leetcode id=2463 lang=csharp
 *
 * [2463] Minimum Total Distance Traveled
 */

// @lc code=start
public class Solution {
    public long MinimumTotalDistance(IList<int> robot, int[][] factory) {
        List<int> robots = robot.ToList();
        robots.Sort();
        Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));

        long[,] dp = new long[factory.Length + 1, robots.Count + 1];
        for (int r = 1; r <= robots.Count; r++)
        {
            dp[0, r] = int.MaxValue * 100L;
        }

        long cost = 0;
        int len = 0;
        for (int f = 1; f <= factory.Length; f++)
        {
            for (int r = 1; r <= robots.Count; r++)
            {
                cost = 0L;
                dp[f, r] = dp[f - 1, r];
                len = Math.Min(r, factory[f - 1][1]);
                for (int k = 1; k <= len; k++)
                {
                    cost += Math.Abs(robots[r - k] - factory[f - 1][0]);
                    dp[f, r] = Math.Min(dp[f, r], dp[f - 1, r - k] + cost);
                }
            }
        }

        return dp[factory.Length, robots.Count];
    }
}
// @lc code=end

