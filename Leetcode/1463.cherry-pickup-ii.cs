/*
 * @lc app=leetcode id=1463 lang=csharp
 *
 * [1463] Cherry Pickup II
 */

// @lc code=start
public class Solution {
    public int CherryPickup(int[][] grid) {
        int count = grid[0].Length;
        int[,,] dp = new int[grid.Length, count, count];
        dp[0, 0, count - 1] = grid[0][0] + grid[0][count - 1];

        int Get(int r, int robot1, int robot2)
        {
            return robot1 < 0 || robot1 >= count ||
                robot2 < 0 || robot2 >= count ?
                0 : dp[r, robot1, robot2];
        }

        for (int row = 1; row < grid.Length; row++)
        {
            for (int a = 0; a < Math.Min(row + 1, count); a++)
            {
                for (int b = count - 1; b >= Math.Max(count - 1 - row, 0); b--)
                {
                    int current = a == b ? grid[row][a] : (grid[row][a] + grid[row][b]);
                    int last = dp[row - 1, a, b];
                    last = Math.Max(last, Get(row - 1, a - 1, b - 1));
                    last = Math.Max(last, Get(row - 1, a - 1, b));
                    last = Math.Max(last, Get(row - 1, a - 1, b + 1));
                    last = Math.Max(last, Get(row - 1, a, b - 1));
                    last = Math.Max(last, Get(row - 1, a, b + 1));
                    last = Math.Max(last, Get(row - 1, a + 1, b - 1));
                    last = Math.Max(last, Get(row - 1, a + 1, b));
                    last = Math.Max(last, Get(row - 1, a + 1, b + 1));
                    dp[row, a, b] = last + current;
                }
            }
        }

        int result = 0;
        for (int a = 0; a < count; a++)
        {
            for (int b = 0; b < count; b++)
            {
                result = Math.Max(result, dp[grid.Length - 1, a, b]);
            }
        }

        return result;
    }
}
// @lc code=end

