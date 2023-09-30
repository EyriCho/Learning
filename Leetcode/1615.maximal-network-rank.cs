/*
 * @lc app=leetcode id=1615 lang=csharp
 *
 * [1615] Maximal Network Rank
 */

// @lc code=start
public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        var r = new int[n];
        var connect = new int[n, n];
        foreach (var road in roads)
        {
            r[road[0]]++;
            r[road[1]]++;
            connect[road[0], road[1]]++;
            connect[road[1], road[0]]++;
        }

        var result = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                result = Math.Max(result, r[i] + r[j] - connect[i, j]);
            }
        }

        return result;
    }
}
// @lc code=end

