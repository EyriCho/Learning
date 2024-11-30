/*
 * @lc app=leetcode id=2257 lang=csharp
 *
 * [2257] Count Unguarded Cells in the Grid
 */

// @lc code=start
public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int[,] grid = new int[m, n];

        foreach (int[] guard in guards)
        {
            grid[guard[0], guard[1]] = 2;
        }

        foreach (int[] wall in walls)
        {
            grid[wall[0], wall[1]] = 2;
        }

        int[][] directions = new int[][] {
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
        };

        int x = 0,
            y = 0;
        foreach (int[] guard in guards)
        {
            foreach (int[] d in directions)
            {
                x = guard[0] + d[0];
                y = guard[1] + d[1];

                while (x >= 0 && x < m &&
                    y >= 0 && y < n &&
                    grid[x, y] < 2)
                {
                    grid[x, y] = 1;
                    x += d[0];
                    y += d[1];
                }
            }
        }

        int result = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i, j] == 0)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

