/*
 * @lc app=leetcode id=2906 lang=csharp
 *
 * [2906] Construct Product Matrix
 */

// @lc code=start
public class Solution {
    public int[][] ConstructProductMatrix(int[][] grid) {
        const int mod = 12345;
        int[][] result = new int[grid.Length][];
        long product = 1L;

        for (int i = 0; i < grid.Length; i++)
        {
            result[i] = new int[grid[0].Length];
            for (int j = 0; j < grid[0].Length; j++)
            {
                result[i][j] = (int)product;
                product = product * grid[i][j] % mod;
            }
        }

        product = 1L;
        for (int i = grid.Length - 1; i >= 0; i--)
        {
            for (int j = grid[0].Length - 1; j >= 0; j--)
            {
                result[i][j] = (int)(product * result[i][j] % mod);
                product = product * grid[i][j] % mod;
            }
        }

        return result;
    }
}
// @lc code=end

