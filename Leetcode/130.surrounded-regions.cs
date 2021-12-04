/*
 * @lc app=leetcode id=130 lang=csharp
 *
 * [130] Surrounded Regions
 */

// @lc code=start
public class Solution {
    public void Solve(char[][] board) {
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 }
        };
        var notFlip = new bool[board.Length, board[0].Length];
        
        void FindBoarderRegion(int x, int y)
        {
            if (x < 0 || x >= board.Length ||
                y < 0 || y >= board[0].Length)
                return;
            
            if (board[x][y] == 'X')
                return;
            else if (notFlip[x, y])
                return;
            
            notFlip[x, y] = true;
            
            for (int i = 0; i < 4; i++)
                FindBoarderRegion(
                    x + directions[i, 0],
                    y + directions[i, 1]);
        }
        
        int lastRow = board.Length - 1,
            lastColumn = board[0].Length - 1;
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i][0] == 'O')
                FindBoarderRegion(i, 0);
            if (board[i][lastColumn] == 'O');
                FindBoarderRegion(i, lastColumn);
        }
        
        for (int j = 1; j < lastColumn; j++)
        {
            if (board[0][j] == 'O')
                FindBoarderRegion(0, j);
            if (board[lastRow][j] == 'O')
                FindBoarderRegion(lastRow, j);
        }
        
        for (int i = 1; i < lastRow; i++)
            for (int j = 1; j < lastColumn; j++)
                if (!notFlip[i, j])
                    board[i][j] = 'X';
    }
}
// @lc code=end

