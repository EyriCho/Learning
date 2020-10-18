/*
 * @lc app=leetcode id=1288 lang=csharp
 *
 * [1288] Remove Covered Intervals
 */

// @lc code=start
public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] - b[0] == 0 ? a[1] - b[1] : a[0] - b[0]);
        return Helper(intervals[0], 1, intervals, intervals.Length);
    }

    private int Helper(int[] prev, int p, int[][] intervals, int count)
    {
        if (p == intervals.Length)
            return count;
        
        if (intervals[p][0] == prev[0])
            count = Helper(intervals[p], p + 1, intervals, count - 1);
        else if (intervals[p][1] <= prev[1])
            count = Helper(prev, p + 1, intervals, count - 1);
        else
            count = Helper(intervals[p], p + 1, intervals, count);
        
        return count;
    }
}
// @lc code=end

