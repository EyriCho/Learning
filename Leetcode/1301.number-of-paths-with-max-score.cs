/*
 * @lc app=leetcode id=1301 lang=csharp
 *
 * [1301] Number of Paths with Max Score
 */

// @lc code=start
public class Solution {
    public int[] PathsWithMaxScore(IList<string> board) {
        int[,,] dp = new int[board.Count, board.Count, 2];
        for (int i = 0; i < board.Count; i++)
        {
            for (int j = 0; j < board.Count; j++)
            {
                dp[i, j, 0] = -1;
            }
        }
        dp[board.Count - 1, board.Count - 1, 0] = 0;
        dp[board.Count - 1, board.Count - 1, 1] = 1;

        void Update(int x, int y, int px, int py)
        {
            if (px >= board.Count || py >= board.Count ||
                dp[px, py, 0] == -1)
            {
                return;
            }

            if (dp[px, py, 0] > dp[x, y, 0])
            {
                dp[x, y, 0] = dp[px, py, 0];
                dp[x, y, 1] = dp[px, py, 1];
            }
            else if (dp[px, py, 0] == dp[x, y, 0])
            {
                dp[x, y, 1] = (dp[x, y, 1] + dp[px, py, 1]) % 1_000_000_007;
            }
        }

        for (int i = board.Count - 1; i >= 0; i--)
        {
            for (int j = board.Count - 1; j >= 0; j--)
            {
                if ((i == board.Count - 1 && j == board.Count - 1) ||
                    board[i][j] == 'X')
                {
                    continue;
                }

                Update(i, j, i + 1, j);
                Update(i, j, i, j + 1);
                Update(i, j, i + 1, j + 1);

                if (dp[i, j, 0] == -1)
                {
                    continue;
                }
                dp[i, j, 0] += board[i][j] == 'E' ? 0 : (board[i][j] - '0');
            }
        }

        if (dp[0, 0, 0] == -1)
        {
            return new int[] { 0, 0 };
        }
        return new int[] { dp[0, 0, 0], dp[0, 0, 1] % 1_000_000_007 };
    }
}
// @lc code=end

