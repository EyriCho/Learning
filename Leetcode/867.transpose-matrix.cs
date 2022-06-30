/*
 * @lc app=leetcode id=867 lang=csharp
 *
 * [867] Transpose Matrix
 */

// @lc code=start
public class Solution {
    public int[][] Transpose(int[][] matrix) {
        var result = new int[matrix[0].Length][];
        
        for (int j = 0; j < matrix[0].Length; j++)
        {
            result[j] = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                result[j][i] = matrix[i][j];
            }
        }
         
        return result;
    }
}
// @lc code=end

