/*
 * @lc app=leetcode id=221 lang=csharp
 *
 * [221] Maximal Square
 */

// @lc code=start
public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int[,] dp = new int[matrix.Length + 1, matrix[0].Length + 1];
        
        var max = 0;
        for (int i = 1; i <= matrix.Length; i++)
            for (int j = 1; j <= matrix[0].Length; j++)
            {
                if (matrix[i - 1][j - 1] == '1')
                {
                    var edge = Math.Min(dp[i - 1, j], dp[i, j - 1]);
                    dp[i, j] = Math.Min(edge, dp[i - 1, j - 1]) + 1;
                    
                    max = Math.Max(max, dp[i, j]);
                }
            }
        
        return max * max;
    }
}
// @lc code=end

