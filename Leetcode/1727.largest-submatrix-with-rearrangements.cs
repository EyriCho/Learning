/*
 * @lc app=leetcode id=1727 lang=csharp
 *
 * [1727] Largest Submatrix With Rearrangements
 */

// @lc code=start
public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int[] columns = new int[matrix[0].Length];
        int result = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < columns.Length; j++)
            {
                if (matrix[i][j] == 1)
                {
                    columns[j]++;
                }
                else
                {
                    columns[j] = 0;
                }
            }

            int[] tmp = new int[columns.Length];
            Array.Copy(columns, tmp, columns.Length);
            Array.Sort(tmp, (a, b) => b - a);

            for (int j = 0; j < columns.Length; j++)
            {
                result = Math.Max(result, tmp[j] * (j + 1));
            }
        }

        return result;
    }
}
// @lc code=end

