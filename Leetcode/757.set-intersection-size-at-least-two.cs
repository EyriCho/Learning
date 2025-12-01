/*
 * @lc app=leetcode id=757 lang=csharp
 *
 * [757] Set Intersection Size At Least Two
 */

// @lc code=start
public class Solution {
    public int IntersectionSizeTwo(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].Equals(b[1]) ?
            a[0].CompareTo(b[0]) :
            a[1].CompareTo(b[1]));
        
        int result = 2,
            first = intervals[0][1] - 1,
            second = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] > second)
            {
                result += 2;
                first = intervals[i][1] - 1;
                second = intervals[i][1];
            }
            else if (intervals[i][0] == second || intervals[i][0] > first)
            {
                result += 1;
                first = second;
                second = intervals[i][1];
            }
        }

        return result;
    }
}
// @lc code=end

