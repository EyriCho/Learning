/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int[] rows = new int[9],
            cols = new int[9],
            boxes = new int[9];

        int num = 0,
            box = 0;
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                num = 1 << (board[i][j] - '0');

                if ((rows[i] & num) > 1)
                {
                    return false;
                }
                rows[i] |= num;

                if ((cols[j] & num) > 1)
                {
                    return false;
                }
                cols[j] |= num;

                box = i / 3 * 3 + j / 3;
                if ((boxes[box] & num) > 1)
                {
                    return false;
                }
                boxes[box] |= num;
            }
        }

        return true;
    }
}
// @lc code=end

