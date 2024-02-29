/*
 * @lc app=leetcode id=787 lang=csharp
 *
 * [787] Cheapest Flights Within K Stops
 */

// @lc code=start
public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[] dp = new int[n],
            prev = new int[n];

        Array.Fill(dp, 1_000_000_000);
        dp[src] = 0;

        Array.Copy(dp, prev, n);
        for (int i = 0; i <= k; i++)
        {
            foreach (var flight in flights)
            {
                dp[flight[1]] = Math.Min(dp[flight[1]], prev[flight[0]] + flight[2]);
            }

            Array.Copy(dp, prev, n);
        }

        return dp[dst] == 1_000_000_000 ? -1 : dp[dst];
    }
}
// @lc code=end

