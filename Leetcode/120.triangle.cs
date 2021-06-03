/*
 * @lc app=leetcode id=120 lang=csharp
 *
 * [120] Triangle
 */

// @lc code=start
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        for (int i = triangle.Count - 1; i > 0; i--)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                triangle[i - 1][j] += Math.Min(triangle[i][j], triangle[i][j + 1]);
            }
        }
        
        return triangle[0][0];
    }
}
// @lc code=end

