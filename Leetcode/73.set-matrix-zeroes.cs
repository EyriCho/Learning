/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 */

// @lc code=start
public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool firstColumn = false;

        
        for (int i = 0; i < matrix.Length; i++)
        {
            firstColumn |= matrix[i][0] == 0;
            
            for (int j = 1; j < matrix[0].Length; j++)
                if (matrix[i][j] == 0)
                {
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
        }
        
        for (int i = 1; i < matrix.Length; i++)
            for (int j = 1; j < matrix[0].Length; j++)
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
        
        if (matrix[0][0] == 0)
            for (int j = 1; j < matrix[0].Length; j++)
                matrix[0][j] = 0;
        
        if (firstColumn)
            for (int i = 0; i < matrix.Length; i++)
                matrix[i][0] = 0;
    }
}
// @lc code=end

