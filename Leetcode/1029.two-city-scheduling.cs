/*
 * @lc app=leetcode id=1029 lang=csharp
 *
 * [1029] Two City Scheduling
 */

// @lc code=start
public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(
            costs,
            Comparer<int[]>.Create((x, y) => (x[0] - x[1]) - (y[0] - y[1])));

        int total = 0, n = costs.Length / 2;
        for (int i = 0; i < n; i++)
        {
            total += costs[i][0] + costs[i + n][1];
        }

        return total;
    }
}
// @lc code=end

