/*
 * @lc app=leetcode id=1601 lang=csharp
 *
 * [1601] Maximum Number of Achievable Transfer Requests
 */

// @lc code=start
public class Solution {
    public int MaximumRequests(int n, int[][] requests) {
        int result = 0;
        var buildings = new int[n];
        
        void Backtrace(int idx, int count)
        {
            if (idx == requests.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    if (buildings[i] != 0)
                    {
                        return;
                    }
                }

                result = Math.Max(result, count);
                return;
            }

            buildings[requests[idx][0]]--;
            buildings[requests[idx][1]]++;
            Backtrace(idx + 1, count + 1);

            buildings[requests[idx][0]]++;
            buildings[requests[idx][1]]--;
            Backtrace(idx + 1, count);
        }

        Backtrace(0, 0);
        return result;
    }
}
// @lc code=end

