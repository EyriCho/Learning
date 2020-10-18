/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 */

// @lc code=start
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();
        int index = 0;
        int s = newInterval[0], e = newInterval[1];
        while (index < intervals.Length &&
               intervals[index][1] < s)
            result.Add(intervals[index++]);
        
        while (index < intervals.Length &&
              intervals[index][0] <= e)
        {
            if (intervals[index][0] < s)
                s = intervals[index][0];
            if (intervals[index][1] > e)
                e = intervals[index][1];
            index++;
        }
        result.Add(new int[] {s, e});
        while (index < intervals.Length &&
              intervals[index][0] > e)
            result.Add(intervals[index++]);
        return result.ToArray();
    }
}
// @lc code=end

