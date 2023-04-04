/*
 * @lc app=leetcode id=983 lang=csharp
 *
 * [983] Minimum Cost For Tickets
 */

// @lc code=start
public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        var totalDays = days[days.Length - 1];
        var dp = new int[totalDays + 1];
        int j = 0;
        for (int i = 1; i <= totalDays; i++)
        {
            if (i < days[j])
            {
                dp[i] = dp[i - 1];
            }
            else
            {
                dp[i] = dp[i - 1] + costs[0];

                var seven = i - 7;
                seven = Math.Max(0, seven);
                dp[i] = Math.Min(dp[i], dp[seven] + costs[1]);

                var thirty = i - 30;
                thirty = Math.Max(0, thirty);
                dp[i] = Math.Min(dp[i], dp[thirty] + costs[2]);

                j++;
            }
        }

        return dp[totalDays];
    }
}
// @lc code=end

