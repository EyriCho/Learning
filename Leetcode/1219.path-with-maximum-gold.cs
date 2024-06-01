/*
 * @lc app=leetcode id=1219 lang=csharp
 *
 * [1219] Path with Maximum Gold
 */

// @lc code=start
public class Solution {
    public int GetMaximumGold(int[][] grid) {
        int Count(int x, int y)
        {
            if (x < 0 || x >= grid.Length ||
                y < 0 || y >= grid[0].Length ||
                grid[x][y] <= 0)
            {
                return 0;
            }

            int current = grid[x][y];
            grid[x][y] = 0;
            int max = 0;

            max = Math.Max(Count(x + 1, y), max);
            max = Math.Max(Count(x - 1, y), max);
            max = Math.Max(Count(x, y + 1), max);
            max = Math.Max(Count(x, y - 1), max);
            
            grid[x][y] = current;
            return max += current;
        }

        int result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] > 0)
                {
                    result = Math.Max(result, Count(i, j));
                }
            }
        }

        return result;
    }
}
// @lc code=end

