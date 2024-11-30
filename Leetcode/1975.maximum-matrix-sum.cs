/*
 * @lc app=leetcode id=1975 lang=csharp
 *
 * [1975] Maximum Matrix Sum
 */

// @lc code=start
public class Solution {
    public long MaxMatrixSum(int[][] matrix) {
        long sum = 0L;
        int min = 100_001,
            negative = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] < 0)
                {
                    matrix[i][j] = -matrix[i][j];
                    negative++;
                }

                min = Math.Min(min, matrix[i][j]);
                sum += matrix[i][j];
            }
        }
        
        if ((negative & 1) > 0)
        {
            sum -= 2 * min;
        }

        return sum;
    }
}
// @lc code=end

