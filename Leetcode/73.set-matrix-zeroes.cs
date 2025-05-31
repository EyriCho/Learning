/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 */

// @lc code=start
public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool zeroInFirstCol = false;

        for (int row = 0; row < matrix.Length; row++)
        {
            if (matrix[row][0] == 0)
            {
                zeroInFirstCol = true;
            }

            for (int col = 1; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] == 0)
                {
                    matrix[row][0] = 0;
                    matrix[0][col] = 0;
                }
            }
        }

        for (int row = matrix.Length - 1; row >= 0; row--)
        {
            for (int col = matrix[0].Length - 1; col >= 1; col--)
            {
                if (matrix[row][0] == 0 || matrix[0][col] == 0)
                {
                    matrix[row][col] = 0;
                }
            }

            if (zeroInFirstCol)
            {
                matrix[row][0] = 0;
            }
        }
    }
}
// @lc code=end

