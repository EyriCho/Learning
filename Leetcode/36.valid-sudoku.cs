/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++)
        {
            var valid = new bool[9];
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    var num = board[i][j] - '1';
                    if (valid[num])
                    {
                        return false;
                    }
                    valid[num] = true;
                }
            }
        }
        
        for (int j = 0; j < 9; j++)
        {
            var valid = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                if (board[i][j] != '.')
                {
                    var num = board[i][j] - '1';
                    if (valid[num])
                    {
                        return false;
                    }
                    valid[num] = true;
                }
            }
        }
        
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                var valid = new bool[9];
                for (int k = 0; k < 9; k++)
                {
                    int x = i + k / 3,
                        y = j + k % 3;
                    if (board[x][y] != '.')
                    {
                        var num = board[x][y] - '1';
                        if (valid[num])
                        {
                            return false;
                        }
                        valid[num] = true;
                    }
                }
            }
        }
        
        return true;
    }
}
// @lc code=end

