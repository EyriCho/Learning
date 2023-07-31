/*
 * @lc app=leetcode id=1751 lang=csharp
 *
 * [1751] Maximum Number of Events That Can Be Attended II
 */

// @lc code=start
public class Solution {
    public int MaxValue(int[][] events, int k) {
        Array.Sort(events, (a, b) => a[1] > b[1] ? 1 : a[1] == b[1] ? 0 : -1);

        var dp = new int[events.Length, k + 1];
        dp[0, 1] = events[0][2];

        for (int i = 1; i < events.Length; i++)
        {

            int l = 0, r = i - 1, m = 0,
                found = events.Length;

            while (l <= r)
            {
                m = (l + r) >> 1;
                if (events[m][1] >= events[i][0])
                {
                    r = m - 1;
                }
                else
                {
                    if (m == events.Length - 1 ||
                        events[m + 1][1] >= events[i][0])
                    {
                        found = m;
                        break;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
            }

            for (int t = 1; t <= k; t++)
            {
                dp[i, t] = dp[i - 1, t];
            }

            if (found == events.Length)
            {
                dp[i, 1] = Math.Max(dp[i, 1], events[i][2]);
            }
            else
            {
                for (int t = 0; t < k; t++)
                {
                    dp[i, t + 1] = Math.Max(dp[i, t + 1], dp[found, t] + events[i][2]);
                }
            }
        }

        var result = 0;
        for (int t = 1; t <= k; t++)
        {
            result = Math.Max(result, dp[events.Length - 1, t]);
        }

        return result;
    }
}
// @lc code=end

