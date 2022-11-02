/*
 * @lc app=leetcode id=807 lang=csharp
 *
 * [807] Max Increase to Keep City Skyline
 */

// @lc code=start
public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int[] verHeight = new int[grid.Length],
            horHeight = new int[grid.Length];
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                horHeight[i] = Math.Max(grid[i][j], horHeight[i]);
                verHeight[j] = Math.Max(grid[i][j], verHeight[j]);
            }
        }
            
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                result += Math.Min(horHeight[i], verHeight[j]) - grid[i][j];
            }
        }
        
        return result;
    }
}
// @lc code=end

