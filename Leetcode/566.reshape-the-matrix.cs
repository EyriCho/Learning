/*
 * @lc app=leetcode id=566 lang=csharp
 *
 * [566] Reshape the Matrix
 */

// @lc code=start
public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int count = r * c;
        if (count != mat.Length * mat[0].Length)
            return mat;
        
        var result = new int[r][];
        for (int i = 0; i < count; i++)
        {
            int t = i / mat[0].Length,
                l = i % mat[0].Length;
            
            int u = i / c,
                j = i % c;
            
            if (j == 0)
                result[u] = new int[c];
            result[u][j] = mat[t][l];
        }
        
        return result;
    }
}
// @lc code=end

