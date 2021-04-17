/*
 * @lc app=leetcode id=1074 lang=csharp
 *
 * [1074] Number of Submatrices That Sum to Target
 */

// @lc code=start
public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        int sum = 0, result = 0;;
        var rowSum = new int[matrix.Length];
        var dict = new Dictionary<int, int>();
        
        for (int l = 0; l < matrix[0].Length; l++)
        {
            for (int i = 0; i < matrix.Length; i++)
                rowSum[i] = 0;
            
            for (int r = l; r < matrix[0].Length; r++)
            {
                dict.Clear();
                dict[0] = 1;
                sum = 0;
                
                for (int row = 0; row < matrix.Length; row++)
                {
                    rowSum[row] += matrix[row][r];
                    sum += rowSum[row];
                    if (dict.ContainsKey(sum - target))
                        result += dict[sum - target];
                    if (dict.ContainsKey(sum))
                        dict[sum]++;
                    else
                        dict[sum] = 1;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

