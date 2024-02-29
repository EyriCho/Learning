/*
 * @lc app=leetcode id=931 lang=csharp
 *
 * [931] Minimum Falling Path Sum
 */

// @lc code=start
public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
       for (int i = matrix.Length - 2; i >= 0; i--)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                var nextRowMin = matrix[i + 1][j];

                if (j > 0)
                {
                    nextRowMin = Math.Min(nextRowMin, matrix[i + 1][j - 1]);
                }

                if (j < matrix[0].Length - 1)
                {
                    nextRowMin = Math.Min(nextRowMin, matrix[i + 1][j + 1]);
                }

                matrix[i][j] += nextRowMin;
            }
        }

        int min = int.MaxValue;
        for (int j = 0; j < matrix[0].Length; j++)
        {
            min = Math.Min(min, matrix[0][j]);
        }
        return min;
    }
}
// @lc code=end

