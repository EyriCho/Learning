/*
 * @lc app=leetcode id=983 lang=csharp
 *
 * [983] Minimum Cost For Tickets
 */

// @lc code=start
public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int total = days[days.Length - 1];
        int[] dp = new int[total + 1];
        
        int d = 0,
            p = 0;
        for (int i = 1; i <= total; i++)
        {
            if (i < days[d])
            {
                dp[i] = dp[i - 1];
            }
            else
            {
                dp[i] = dp[i - 1] + costs[0];

                p = i - 7;
                p = Math.Max(p, 0);
                dp[i] = Math.Min(dp[i], dp[p] + costs[1]);

                p = i - 30;
                p = Math.Max(p, 0);
                dp[i] = Math.Min(dp[i], dp[p] + costs[2]);

                d++;
            }
        }

        return dp[total];
    }
}
// @lc code=end

