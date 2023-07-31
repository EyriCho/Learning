/*
 * @lc app=leetcode id=688 lang=csharp
 *
 * [688] Knight Probability in Chessboard
 */

// @lc code=start
public class Solution {
    public double KnightProbability(int n, int k, int row, int column) {
        if (k < 0)
        {
            return 1D;
        }

        var directions = new int[,] {
            { -1, -2 },
            { -2, -1 },
            { -2, 1 },
            { -1, 2 },
            { 1, 2 },
            { 2, 1 },
            { 2, -1 },
            { 1, -2 },
        };

        var dp = new double[n, n, k + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j, 0] = 1L;
                for (int s = 1; s <= k; s++)
                {
                    dp[i, j, s] = -1L;
                }
            }
        }

        double Jump(int step, int x, int y)
        {
            if (x < 0 || x >= n ||
                y < 0 || y >= n)
            {
                return 0;
            }
            if (dp[x, y, step] >= 0)
            {
                return dp[x, y, step];
            }

            dp[x, y, step] = 0;
            for (int i = 0; i < 8; i++)
            {
                dp[x, y, step] += Jump(step - 1, x + directions[i, 0], y + directions[i, 1]);
            }

            return dp[x, y, step];
        }

        return Jump(k, row, column) / Math.Pow(8, k);
    }
}
// @lc code=end

