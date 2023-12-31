/*
 * @lc app=leetcode id=1637 lang=csharp
 *
 * [1637] Widest Vertical Area Between Two Points Containing No Points
 */

// @lc code=start
public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        Array.Sort(points, (a, b) => a[0] - b[0]);

        int i = 0,
            result = 0;
        while (i < points.Length)
        {
            int l = points[i++][0];
            while (i < points.Length && points[i][0] == l)
            {
                i++;
            }

            if (i < points.Length)
            {
                result = Math.Max(result, points[i][0] - l);
            }
        }

        return result;
    }
}
// @lc code=end

