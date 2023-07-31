/*
 * @lc app=leetcode id=435 lang=csharp
 *
 * [435] Non-overlapping Intervals
 */

// @lc code=start
public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] == b[0] ? 
            a[1] - b[1] :
            a[0] - b[0]);
        
        int last = 0,
            result = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[last][1])
            {
                result++;
                if (intervals[i][1] < intervals[last][1])
                {
                    last = i;
                }
            }
            else
            {
                last = i;
            }
        }

        return result;
    }
}
// @lc code=end

