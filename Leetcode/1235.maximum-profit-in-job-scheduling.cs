/*
 * @lc app=leetcode id=1235 lang=csharp
 *
 * [1235] Maximum Profit in Job Scheduling
 */

// @lc code=start
public class Solution {
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        var array = new (int, int, int)[startTime.Length];
        
        for (int i = 0; i < startTime.Length; i++)
            array[i] = (endTime[i], startTime[i], profit[i]);
        
        Array.Sort(array, (a, b) => a.Item1 - b.Item1);
        
        var dp = new int[startTime.Length];
        dp[0] = array[0].Item3;
        
        for (int i= 1; i < startTime.Length; i++)
        {
            dp[i] = dp[i - 1];
            
            int l = 0, r = i;
            while (l + 1 < r)
            {
                var m = (l + r) >> 1;
                if (array[m].Item1 <= array[i].Item2)
                    l = m;
                else
                    r = m;
            }
            if (array[l].Item1 <= array[i].Item2)
                dp[i] = Math.Max(dp[i], dp[l] + array[i].Item3);
            
            dp[i] = Math.Max(dp[i], array[i].Item3);
        }
        
        return dp[startTime.Length - 1];
    }
}
// @lc code=end

