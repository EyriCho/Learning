/*
 * @lc app=leetcode id=452 lang=csharp
 *
 * [452] Minimum Number of Arrows to Burst Balloons
 */

// @lc code=start
public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if (points.Length == 0)
            return 0;
        var result = 1;
        
        Array.Sort(points, (a, b) => 
            a[1] > b[1] ? 1 : (a[1] == b[1] ? 0 : -1));

        int last = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > last)
            {
                result++;
                last = points[i][1];
            }
        }
        
        return result;
    }
}
// @lc code=end

