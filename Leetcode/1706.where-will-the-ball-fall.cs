/*
 * @lc app=leetcode id=1706 lang=csharp
 *
 * [1706] Where Will the Ball Fall
 */

// @lc code=start
public class Solution {
    public int[] FindBall(int[][] grid) {
        var result = new int[grid[0].Length];
        
        for (int j = 0; j < grid[0].Length; j++)
        {
            int i = 0, col = j;
            while (i < grid.Length)
            {
                var neighbor = col + grid[i][col];
                if (neighbor < 0 || neighbor >= grid[0].Length ||
                    grid[i][col] != grid[i][neighbor])
                {
                    break;
                }
                
                i++;
                col = neighbor;
            }
            
            result[j] = i == grid.Length ? col : -1;
        }
        
        return result;
    }
}
// @lc code=end

