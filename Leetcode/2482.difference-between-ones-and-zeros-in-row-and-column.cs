/*
 * @lc app=leetcode id=2482 lang=csharp
 *
 * [2482] Difference Between Ones And Zeros in Row and Column
 */

// @lc code=start
public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int[] rows = new int[grid.Length],
            columns = new int[grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {                
                rows[i] += grid[i][j];
                columns[j] += grid[i][j];
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            int r = rows[i] * 2 - grid.Length;
            for (int j = 0; j < grid[0].Length; j++)
            {
                grid[i][j] = r + columns[j] * 2 - grid[0].Length;
            }
        }

        return grid;
    }
}
// @lc code=end

