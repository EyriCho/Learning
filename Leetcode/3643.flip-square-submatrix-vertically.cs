/*
 * @lc app=leetcode id=3643 lang=csharp
 *
 * [3643] Flip Square Submatrix Vertically
 */

// @lc code=start
public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        for (int t = x, b = x + k - 1; t < b; t++, b--)
        {
            for (int j = 0, dy = 0; dy < k; dy++)
            {
                j = y + dy;
                grid[t][j] ^= grid[b][j];
                grid[b][j] ^= grid[t][j];
                grid[t][j] ^= grid[b][j];
            }
        }

        return grid;
    }
}
// @lc code=end

