/*
 * @lc app=leetcode id=3195 lang=csharp
 *
 * [3195] Find the Minimum Area to Cover All Ones I
 */

// @lc code=start
public class Solution {
    public int MinimumArea(int[][] grid) {
        int left = grid[0].Length,
            right = 0,
            top = grid.Length,
            bottom = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }

                left = Math.Min(left, j);
                right = Math.Max(right, j);
                top = Math.Min(top, i);
                bottom = Math.Max(bottom, i);
            }
        }

        if (left == grid[0].Length &&
            right == 0 &&
            top == grid.Length &&
            bottom == 0)
        {
            return 0;
        }

        return (bottom - top + 1) * (right - left + 1);
    }
}
// @lc code=end

