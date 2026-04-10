/*
 * @lc app=leetcode id=2946 lang=csharp
 *
 * [2946] Matrix Similarity After Cyclic Shifts
 */

// @lc code=start
public class Solution {
    public bool AreSimilar(int[][] mat, int k) {
        k %= mat[0].Length;
        if (k == 0)
        {
            return true;
        }

        int n = mat[0].Length;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i & 1) == 0 &&
                    mat[i][(j - k + n) % n] != mat[i][j])
                {
                    return false;
                }
                else if ((i & 1) == 1 &&
                    mat[i][(j + k) % n] != mat[i][j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end

