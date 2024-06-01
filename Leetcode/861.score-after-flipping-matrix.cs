/*
 * @lc app=leetcode id=861 lang=csharp
 *
 * [861] Score After Flipping Matrix
 */

// @lc code=start
public class Solution {
    public int MatrixScore(int[][] grid) {
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[i][0] == 0)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    grid[i][j] ^= 1;
                }
            }
        }

        int result = 0,
            mask = 1 << (grid[0].Length - 1),
            count = 0;
        for (int j = 0; j < grid[0].Length; j++)
        {
            count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                count += grid[i][j];
            }
            result += mask * (count > grid.Length / 2 ? count : (grid.Length - count));
            mask >>= 1;
        }

        return result;
    }
}
// @lc code=end

