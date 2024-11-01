/*
 * @lc app=leetcode id=2406 lang=csharp
 *
 * [2406] Divide Intervals Into Minimum Number of Groups
 */

// @lc code=start
public class Solution {
    public int MinGroups(int[][] intervals) {
        int max = 0;
        foreach (int[] interval in intervals)
        {
            max = Math.Max(max, interval[1]);
        }

        int[] line = new int[max + 2];
        foreach (int[] interval in intervals)
        {
            line[interval[0]]++;
            line[interval[1] + 1]--;
        }

        int current = 0,
            result = 0;
        for (int i = 0; i <= max; i++)
        {
            current += line[i];
            result = Math.Max(result, current);
        }
        return result;
    }
}
// @lc code=end

