/*
 * @lc app=leetcode id=812 lang=csharp
 *
 * [812] Largest Triangle Area
 */

// @lc code=start
public class Solution {
    public double LargestTriangleArea(int[][] points) {
        double result = 0D,
            area = 0D;
        for (int i = points.Length - 1; i > 1; i--)
        {
            for (int j = i - 1; j > 0; j--)
            {
                for (int k = j - 1; k > -1; k--)
                {
                    area = 0.5D * Math.Abs(
                        points[i][0] * (points[j][1] - points[k][1]) +
                        points[j][0] * (points[k][1] - points[i][1]) +
                        points[k][0] * (points[i][1] - points[j][1])
                    );
                    result = Math.Max(result, area);
                }
            }
        }

        return result;
    }
}
// @lc code=end

