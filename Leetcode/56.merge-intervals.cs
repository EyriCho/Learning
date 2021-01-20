/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution {
    public int[][] Merge(int[][] intervals) {
        IList<int[]> result = new List<int[]>();
        Array.Sort(intervals, (l, r) => l[0] - r[0] == 0 ? l[1] - r[1] : l[0] - r[0]);
        
        int[] cur = intervals[0];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (cur[1] >= intervals[i][0])
            {
                if (intervals[i][1] > cur[1])
                    cur[1] = intervals[i][1];
            }
            else
            {
                result.Add(cur);
                cur = intervals[i];
            }
        }
        result.Add(cur);
        
        return result.ToArray();
    }
}
// @lc code=end

