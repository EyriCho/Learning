/*
 * @lc app=leetcode id=1266 lang=csharp
 *
 * [1266] Minimum Time Visiting All Points
 */

// @lc code=start
public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int result = 0;

        for (int i = 1; i < points.Length; i++)
        {
            result += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]),
                Math.Abs(points[i][1] - points[i - 1][1]));
        }

        return result;
    }
}
// @lc code=end

