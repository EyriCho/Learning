/*
 * @lc app=leetcode id=2267 lang=csharp
 *
 * [2267]  Check if There Is a Valid Parentheses String Path
 */

// @lc code=start
public class Solution {
    public bool HasValidPath(char[][] grid) {
        if (grid[0][0] == ')' ||
            grid[^1][^1] == '(')
        {
            return false;
        }

        bool[,,] dp = new bool[grid.Length, grid[0].Length, 101];
        dp[0, 0, 1] = true;
        int idx = 1;
        for (int j = 1; j < grid[0].Length; j++)
        {
            idx += grid[0][j] == '(' ? 1 : -1;
            if (idx < 0)
            {
                break;
            }
            dp[0, j, idx] = true;
        }

        idx = 1;
        for (int i = 1; i < grid.Length; i++)
        {
            idx += grid[i][0] == '(' ? 1 : -1;
            if (idx < 0)
            {
                break;
            }
            dp[i, 0, idx] = true;
        }

        int dir = 0;
        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                dir = grid[i][j] == '(' ? 1 : -1;
                for (int p = 0; p <= 100; p++)
                {
                    if ((p == 0 && dir == -1) ||
                        (p == 100 && dir == 1))
                    {
                        continue;
                    }

                    if (dp[i - 1, j, p] || dp[i, j - 1, p])
                    {
                        dp[i, j, p + dir] = true;
                    }
                }
            }
        }

        return dp[grid.Length - 1, grid[0].Length - 1, 0];
    }
}
// @lc code=end

