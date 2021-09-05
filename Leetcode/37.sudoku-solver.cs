/*
 * @lc app=leetcode id=37 lang=csharp
 *
 * [37] Sudoku Solver
 */

// @lc code=start
public class Solution {
    public void SolveSudoku(char[][] board) {
        bool IsValid(int x, int y, char c)
        {
            for (int i = 0; i < 9; i++)
                if (board[i][y] == c)
                    return false;

            for (int j = 0; j < 9; j++)
                if (board[x][j] == c)
                    return false;
            
            int row = x - x % 3,
                column = y - y % 3;
            
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[row + i][column + j] == c)
                        return false;

            return true;
        }
        
        bool Travel(int x, int y)
        {
            if (x == 9)
                return true;
            if (y == 9)
                return Travel(x + 1, 0);
            
            if (board[x][y] != '.')
                return Travel(x, y + 1);
            
            for (char c = '1'; c <= '9'; c++)
            {
                if (!IsValid(x, y, c))
                    continue;
                board[x][y] = c;
                if (Travel(x, y + 1))
                    return true;
                board[x][y] = '.';
            }
            
            return false;
        }
        
        Travel(0, 0);
    }
}
// @lc code=end

