/*
 * @lc app=leetcode id=1605 lang=csharp
 *
 * [1605] Find Valid Matrix Given Row and Column Sums
 */

// @lc code=start
public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        int[][] result = new int[rowSum.Length][];

        int i = 0,
            j = 0,
            min = 0;
        for (; i < rowSum.Length; i++)
        {
            result[i] = new int[colSum.Length];
        }

        i = 0;
        while (i < rowSum.Length &&
            j < colSum.Length)
        {
            min = Math.Min(rowSum[i], colSum[j]);
            result[i][j] = min;
            rowSum[i] -= min;
            colSum[j] -= min;
            if (rowSum[i] == 0)
            {
                i++;
            }
            else if (colSum[j] == 0)
            {
                j++;
            }
        }

        return result;
    }
}
// @lc code=end

