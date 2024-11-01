/*
 * @lc app=leetcode id=1277 lang=csharp
 *
 * [1277] Count Square Submatrices with All Ones
 */

// @lc code=start
public class Solution {
    public int CountSquares(int[][] matrix) {
        int result = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] > 0)
                {
                    if (i > 0 && j > 0)
                    {
                        matrix[i][j] = 1 + Math.Min(
                            matrix[i - 1][j],
                            Math.Min(matrix[i][j - 1], matrix[i - 1][j - 1]));
                    }
                }

                result += matrix[i][j];
            }
        }

        return result;
    }
}
// @lc code=end

