/*
 * @lc app=leetcode id=1376 lang=csharp
 *
 * [1376] Time Needed to Inform All Employees
 */

// @lc code=start
public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        var dp = new int[n];
        int mgrId = 0,
            subId = 0;

        for (int i = 0; i < n; i++)
        {
            subId = i;
            while ((mgrId = manager[subId]) != -1)
            {
                var time = dp[subId] + informTime[mgrId];
                if (dp[mgrId] > time)
                {
                    break;
                }

                dp[mgrId] = time;
                subId = mgrId;
            }
        }

        return dp[headID];
    }
}
// @lc code=end

