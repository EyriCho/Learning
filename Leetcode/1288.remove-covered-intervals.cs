/*
 * @lc app=leetcode id=1288 lang=csharp
 *
 * [1288] Remove Covered Intervals
 */

// @lc code=start
public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) :
            a[0].CompareTo(b[0]));
        
        int i = 0, j = 0,
            result = intervals.Length;
        
        while (i < intervals.Length)
        {
            j = i + 1;

            while (j < intervals.Length &&
                intervals[i][1] >= intervals[j][1])
            {
                result--;
                j++;
            }

            i = j;
        }

        return result;
    }
}
// @lc code=end

