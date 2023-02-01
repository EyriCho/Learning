/*
 * @lc app=leetcode id=787 lang=csharp
 *
 * [787] Cheapest Flights Within K Stops
 */

// @lc code=start
public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var dp = new int[n];
        Array.Fill(dp, 1_000_000_000);
        dp[src] = 0;
        var temp = new int[n];
        Array.Copy(dp, temp, n);

        for (int i = 0; i <= k; i++)
        {
            foreach (var flight in flights)
            {
                dp[flight[1]] = Math.Min(dp[flight[1]], temp[flight[0]] + flight[2]);
            }

            Array.Copy(dp, temp, n);
        }

        return dp[dst] == 1_000_000_000 ? -1 : dp[dst];
    }
}
// @lc code=end

