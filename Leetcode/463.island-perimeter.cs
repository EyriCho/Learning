/*
 * @lc app=leetcode id=463 lang=csharp
 *
 * [463] Island Perimeter
 */

// @lc code=start
public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var perimeter = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    perimeter += 4;
                    if (i > 0 && grid[i - 1][j] == 1) perimeter -= 2;
                    if (j > 0 && grid[i][j - 1] == 1) perimeter -= 2;
                }
            }
        }
        return perimeter;        
    }
}
// @lc code=end

