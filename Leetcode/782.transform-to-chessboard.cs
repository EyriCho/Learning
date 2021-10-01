/*
 * @lc app=leetcode id=782 lang=csharp
 *
 * [782] Transform to Chessboard
 */

// @lc code=start
public class Solution {
    public int MovesToChessboard(int[][] board) {
        int count1 = 1, count2 = 0;
        for (int i = 1; i < board.Length; i++)
        {
            if (board[0][0] == board[i][0])
            {
                count1++;
                for (int j = 0; j < board.Length; j++)
                    if (board[0][j] != board[i][j])
                        return -1;
            }
            else
            {
                count2++;
                for (int j = 0; j < board.Length; j++)
                    if (board[0][j] == board[i][j])
                        return -1;
            }
        }
        
        if (Math.Abs(count1 - count2) > 1)
            return -1;
        
        count1 = 1;
        count2 = 0;
        for (int j = 1; j < board.Length; j++)
        {
            if (board[0][0] == board[0][j])
            {
                count1++;
                for (int i = 0; i < board.Length; i++)
                    if (board[i][0] != board[i][j])
                        return -1;
            }
            else
            {
                count2++;
                for (int i = 0; i < board.Length; i++)
                    if (board[i][0] == board[i][j])
                        return -1;
            }
        }
        
        if (Math.Abs(count1 - count2) > 1)
            return -1;
        
        int rowDiff = 0, columnDiff = 0;
        for (int i = 0; i < board.Length; i++)
        {
            rowDiff += (board[0][i] == i % 2) ? 0 : 1;
            columnDiff += (board[i][0] == i % 2) ? 0 : 1;
        }        
        
        if (board.Length % 2 == 1)
        {
            if (rowDiff % 2 == 1)
                rowDiff = board.Length - rowDiff;
            if (columnDiff % 2 == 1)
                columnDiff = board.Length - columnDiff;
        }
        else
        {
            rowDiff = Math.Min(rowDiff, board.Length - rowDiff);
            columnDiff = Math.Min(columnDiff, board.Length - columnDiff);
        }
        
        return (rowDiff + columnDiff) / 2;
    }
}
// @lc code=end

