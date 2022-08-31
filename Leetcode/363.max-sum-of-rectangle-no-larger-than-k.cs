/*
 * @lc app=leetcode id=363 lang=csharp
 *
 * [363] Max Sum of Rectangle No Larger Than K
 */

// @lc code=start
public class Solution {
    public int MaxSumSubmatrix(int[][] matrix, int k) {
        var sums = new int[matrix.Length + 1, matrix[0].Length + 1];
        var result = int.MinValue;
        
        for (int i = 1; i <= matrix.Length; i++)
        {
            for (int j = 1; j <= matrix[0].Length; j++)
            {
                sums[i, j] = sums[i, j - 1] + sums[i - 1, j] - sums[i - 1, j - 1] + matrix[i - 1][j - 1];
                
                for (int r = 0; r < i; r++)
                {
                    for (int c = 0; c < j; c++)
                    {
                        var t = sums[i, j] - sums[r, j] - sums[i, c] + sums[r, c];
                        
                        if (t == k)
                        {
                            return k;
                        }
                        else if (t < k)
                        {
                            result = Math.Max(result, t);
                        }
                    }
                }
            }
        }
        
        return result;
     }
}
// @lc code=end

