/*
 * @lc app=leetcode id=983 lang=csharp
 *
 * [983] Minimum Cost For Tickets
 */

// @lc code=start
public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        var totalDay = days[days.Length - 1];
        var dp = new int[totalDay + 1];
        int j = 0;
        for (int i = 1; i <= totalDay; i++)
        {
            if (i < days[j])
            {
                dp[i] = dp[i - 1];
            }
            else
            {
                dp[i] = dp[i - 1] + costs[0];
                var seven = i - 7;
                if (seven < 0) seven = 0;
                var c = dp[seven] + costs[1];
                if (c < dp[i]) dp[i] = c;
                
                var thirty = i - 30;
                if (thirty < 0) thirty = 0;
                c = dp[thirty] + costs[2];
                if (c < dp[i]) dp[i] = c;
                j++;
            }
        }
        
        return dp[totalDay];
    }
}
// @lc code=end

