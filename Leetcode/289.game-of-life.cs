/*
 * @lc app=leetcode id=289 lang=csharp
 *
 * [289] Game of Life
 */

// @lc code=start
public class Solution {
    public void GameOfLife(int[][] board) {
        for (int x = 0; x < board.Length; x++)
        {
            for (int y = 0; y < board[x].Length; y++)
            {
                int life = board[x][y];
                board[x][y] = 0;
                int top = Math.Max(0, x - 1),
                    left = Math.Max(0, y - 1),
                    right = Math.Min(board[x].Length - 1, y + 1),
                    bottom = Math.Min(board.Length - 1, x + 1);
                
                int c = 0;
                for (int i = top; i <= bottom; i++)
                    for (int j = left; j <= right; j++)
                        c += board[i][j] == 1 || board[i][j] == -1 ? 1 : 0;
                
                if (c == 3 && life == 0)
                {
                    board[x][y] = 2;
                    continue;
                }
                
                if ((c < 2 || c > 3) && life == 1)
                {
                    board[x][y] = -1;
                    continue;
                }
                
                board[x][y] = life;
            }
        }
        
        for (int x = 0; x < board.Length; x++)
            for (int y = 0; y < board[x].Length; y++)
                board[x][y] = board[x][y] > 0 ? 1 : 0;
    }
}
// @lc code=end

