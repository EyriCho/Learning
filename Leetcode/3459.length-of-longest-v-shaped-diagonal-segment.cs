/*
 * @lc app=leetcode id=3459 lang=csharp
 *
 * [3459] Length of Longest V-Shaped Diagonal Segment
 */

// @lc code=start
public class Solution {
    public int LenOfVDiagonal(int[][] grid) {
        int[] directions = new int[] {
            1, 1, -1, -1, 1,
        };
        
        int[,,,] dp = new int[grid.Length, grid[0].Length, 4, 2];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                for (int d = 0; d < 4; d++)
                {
                    dp[i, j, d, 0] = -1;
                    dp[i, j, d, 1] = -1;
                }
            }
        }



        bool IsInside(int x, int y) =>
            x >= 0 && x < grid.Length &&
            y >= 0 && y < grid[0].Length;

        int Dfs(int x, int y, int d, int next, int turn)
        {
            if (dp[x, y, d, turn] > -1)
            {
                return dp[x, y, d, turn];
            }

            int rst = 1,
                nx = x + directions[d],
                ny = y + directions[d + 1];
            if (IsInside(nx, ny) &&
                grid[nx][ny] == next)
            {
                rst = Math.Max(rst, Dfs(nx, ny, d, next ^ 2, turn) + 1);
            }

            if (turn > 0)
            {
                int newDirection = (d + 1) & 3;
                nx = x + directions[newDirection];
                ny = y + directions[newDirection];

                if (IsInside(nx, ny) &&
                    grid[nx][ny] == next)
                {
                    rst = Math.Max(rst, Dfs(nx, ny, newDirection, next ^ 2, 0) + 1);
                }
            }

            dp[x, y, d, turn] = rst;
            return rst;
        }
        
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }

                for (int d = 0; d < 4; d++)
                {
                    result = Math.Max(result, Dfs(i, j, d, 2, 1));
                }
            }
        }

        return result;
    }
}
// @lc code=end

