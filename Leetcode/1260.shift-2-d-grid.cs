/*
 * @lc app=leetcode id=1260 lang=csharp
 *
 * [1260] Shift 2D Grid
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        k %= grid.Length * grid[0].Length;
        var result = new List<IList<int>>();
        for (int i = 0; i < grid.Length; i++)
        {
            result.Add(new List<int>(grid[i]));
        }
        if (k == 0)
        {
            return result;
        }
        
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                var index = i * grid[0].Length + j + k;
                int x = index / grid[0].Length % grid.Length,
                    y = index % grid[0].Length;
                
                result[x][y] = grid[i][j];
            }
        }
        
        return result;
    }
}
// @lc code=end

