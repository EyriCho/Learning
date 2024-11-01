/*
 * @lc app=leetcode id=2684 lang=csharp
 *
 * [2684] Maximum Number of Moves in a Grid 
 */

// @lc code=start
public class Solution {
    public int MaxMoves(int[][] grid) {
        int[,] dp = new int[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                dp[i, j] = -1;
            }
        }

        int Travel(int row, int column)
        {
            if (dp[row, column] > -1)
            {
                return dp[row, column];
            }

            if (column == grid[0].Length - 1)
            {
                return 0;
            }

            int max = -1;
            for (int r = row - 1; r <= row + 1; r++)
            {
                if (r < 0 || r >= grid.Length ||
                    grid[r][column + 1] <= grid[row][column])
                {
                    continue;
                }

                max = Math.Max(max, Travel(r, column + 1));
            }

            dp[row, column] = max + 1;
            return dp[row, column];
        }
        
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            result = Math.Max(result, Travel(i, 0));
        }

        return result;
    }
}
// @lc code=end

