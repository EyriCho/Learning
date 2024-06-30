/*
 * @lc app=leetcode id=2285 lang=csharp
 *
 * [2285] Maximum Total Importance of Roads
 */

// @lc code=start
public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
        int[] degrees = new int[n];

        foreach (int[] road in roads)
        {
            degrees[road[0]]++;
            degrees[road[1]]++;
        }

        Array.Sort(degrees);

        long result = 0;
        for (long i = n; i > 0; i--)
        {
            result += i * degrees[i - 1];
        }

        return result;
    }
}
// @lc code=end

