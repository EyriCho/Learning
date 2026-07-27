/*
 * @lc app=leetcode id=1260 lang=csharp
 *
 * [1260] Shift 2D Grid
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int total = grid.Length * grid[0].Length,
            idx = 0;

        List<IList<int>> result = new (grid.Length);
        for (int i = 0; i < grid.Length; i++)
        {
            result.Add(new List<int>(grid[i]));
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                idx = (i * grid[i].Length + j + k) % total;
                result[idx / grid[i].Length][idx % grid[i].Length] = grid[i][j];
            }
        }

        return result;
    }
}
// @lc code=end

