/*
 * @lc app=leetcode id=2022 lang=csharp
 *
 * [2022] Convert 1D Array Into 2D Array
 */

// @lc code=start
public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if (m * n != original.Length)
        {
            return new int[0][];
        }

        int[][] result = new int[m][];
        for (int i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                result[i][j] = original[i * n + j];
            }
        }

        return result;
    }
}
// @lc code=end

