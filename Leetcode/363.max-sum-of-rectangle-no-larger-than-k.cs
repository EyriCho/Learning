/*
 * @lc app=leetcode id=363 lang=csharp
 *
 * [363] Max Sum of Rectangle No Larger Than K
 */

// @lc code=start
public class Solution {
    public int MaxSumSubmatrix(int[][] matrix, int k) {
        var sums = new int[matrix.Length + 1, matrix[0].Length + 1];
        int result = int.MinValue;
        
        for (int i = 1; i <= matrix.Length; i++)
            for (int j = 1; j <= matrix[0].Length; j++)
            {
                sums[i, j] = matrix[i - 1][j - 1] + sums[i - 1, j] + sums[i, j - 1] - sums[i - 1, j - 1];
                
                for (int t = 0; t < i; t++)
                    for (int l = 0; l < j; l++)
                    {                        
                        var sum = sums[i, j] - sums[i, l] - sums[t, j] + sums[t, l];

                        if (sum == k)
                            return k;
                        else if (sum < k)
                            result = Math.Max(result, sum);
                    }
            }
                        
        
        return result;
    }
}
// @lc code=end

