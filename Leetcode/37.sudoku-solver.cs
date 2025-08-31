/*
 * @lc app=leetcode id=37 lang=csharp
 *
 * [37] Sudoku Solver
 */

// @lc code=start
public class Solution {
    public void SolveSudoku(char[][] board) {
        int[] rows = new int[9],
            cols = new int[9],
            boxes = new int[9];
        
        int box = 0,
            num = 0;
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                num = 1 << (board[i][j] - '0');
                box = i / 3 * 3 + j / 3;
                rows[i] |= num;
                cols[j] |= num;
                boxes[box] |= num;
            }
        }
        
        bool solved = false;
        void Next(int x, int y)
        {
            if (x == 8 && y == 8)
            {
                solved = true;
            }
            else if (y == 8)
            {
                Dfs(x + 1, 0);
            }
            else
            {
                Dfs(x, y + 1);
            }
        }

        void Dfs(int x, int y)
        {
            if (board[x][y] != '.')
            {
                Next(x, y);
                return;
            }


            int b = x / 3 * 3 + y / 3,
                n = 0;
            for (int c = 1; c < 10; c++)
            {
                n = 1 << c;
                if (((rows[x] | cols[y] | boxes[b]) & n) > 0)
                {
                    continue;
                }
                
                board[x][y] = (char)(c + '0');
                rows[x] |= n;
                cols[y] |= n;
                boxes[b] |= n;
                Next(x, y);
                if (solved)
                {
                    return;
                }

                board[x][y] = '.';
                rows[x] ^= n;
                cols[y] ^= n;
                boxes[b] ^= n;
            }
        }

        Dfs(0, 0);
    }
}
// @lc code=end

