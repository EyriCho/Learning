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
            var flag = new bool[9];
            for (int j = 0; j < 9; j++)
                if (board[i][j] != '.')
                {
                    var index = board[i][j] - '1';
                    if (flag[index])
                        return false;
                    flag[index] = true;
                }
        }
        
        for (int j = 0; j < 9; j++)
        {
            var flag = new bool[9];
            for (int i = 0; i < 9; i++)
                if (board[i][j] != '.')
                {
                    var index = board[i][j] - '1';
                    if (flag[index])
                        return false;
                    flag[index] = true;
                }
        }
        
        for (int i = 0; i < 9; i+= 3)
            for (int j = 0; j < 9; j += 3)
            {
                var flag = new bool[9];
                for (int z = 0; z < 9; z++)
                {
                    int x = i + z / 3,
                        y = j + z % 3;
                    
                    if (board[x][y] != '.')
                    {
                        var index = board[x][y] - '1';
                        if (flag[index])
                            return false;
                        flag[index] = true;
                    }
                }    
            }
        
        return true;
    }
}
// @lc code=end

