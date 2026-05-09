/*
 * @lc app=leetcode id=1391 lang=csharp
 *
 * [1391] Check if There is a Valid Path in a Grid
 */

// @lc code=start
public class Solution {
    public bool HasValidPath(int[][] grid) {
        if (grid[0][0] == 5 ||
            grid[^1][^1] == 4)
        {
            return false;
        }

        if (grid.Length == 1 &&
            grid[0].Length == 1)
        {
            return true;
        }

        int[,] ds = new int[,] {
                { -1, 0 },
                { 0, 1 },
                { 1, 0 },
                { 0, -1 },
            },
            transactions = new int[,] {
                {  -1, 1, -1, 3, },
                { 0, -1, 2, -1, },
                { 3, 2, -1, -1, },
                { 1, -1, -1, 2, },
                { -1, 0, 3, -1, },
                { -1, -1, 1, 0, },
            },
            start = new int[,] {
                { 1, 3, },
                { 0, 2, },
                { 2, 3, },
                { 1, 2, },
                { 0, 3, },
                { 0, 1, },
            };

        bool Check(int d) {
            if (d == -1)
            {
                return false;
            }
            int r = ds[d, 0], c = ds[d, 1];
            while (r >= 0 && r < grid.Length &&
                c >= 0 && c < grid[0].Length)
            {
                d = transactions[grid[r][c] - 1, d];
                if (d == -1 || (r == 0 && c == 0))
                {
                    return false;
                }
                if (r == grid.Length - 1 &&
                    c == grid[0].Length - 1)
                {
                    return true;
                }

                r += ds[d, 0];
                c += ds[d, 1];
            }

            return false;
        }

        return Check(start[grid[0][0] - 1, 0]) || Check(start[grid[0][0] - 1, 1]);
    }
}
// @lc code=end

