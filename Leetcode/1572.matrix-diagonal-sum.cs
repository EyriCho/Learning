/*
 * @lc app=leetcode id=1572 lang=csharp
 *
 * [1572] Matrix Diagonal Sum
 */

// @lc code=start
public class Solution {
    public int DiagonalSum(int[][] mat) {
        var result = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            result += mat[i][i] + mat[i][mat.Length - 1 - i];
        }

        if (mat.Length % 2 == 1)
        {
            var mid = mat.Length >> 1;
            result -= mat[mid][mid];
        }
        return result;
    }
}
// @lc code=end

