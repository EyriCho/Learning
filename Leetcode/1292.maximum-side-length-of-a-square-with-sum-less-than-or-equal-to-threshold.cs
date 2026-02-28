/*
 * @lc app=leetcode id=1292 lang=csharp
 *
 * [1292] Maximum Side Length of a Square with Sum Less than or Equal to Threshold
 */

// @lc code=start
public class Solution {
    public int MaxSideLength(int[][] mat, int threshold) {
        int[,] prefix = new int[mat.Length + 1, mat[0].Length + 1];

        for (int i = 1; i <= mat.Length; i++)
        {
            for (int j = 1; j <= mat[0].Length; j++)
            {
                prefix[i, j] = mat[i - 1][j - 1] +
                    prefix[i - 1, j] + prefix[i, j - 1] - prefix[i - 1, j - 1];
            }
        }

        int maxSide = int.Min(mat.Length, mat[0].Length),
            result = 0;
        
        for (int i = 1; i <= mat.Length; i++)
        {
            for (int j = 1; j <= mat[0].Length; j++)
            {
                for (int side = result + 1; side <= maxSide; side++)
                {
                    if (i + side - 1 <= mat.Length &&
                        j + side - 1 <= mat[0].Length &&
                        (prefix[i + side - 1, j + side - 1] + prefix[i - 1, j - 1] -
                        prefix[i - 1, j + side - 1] - prefix[i + side - 1, j - 1]) <= threshold)
                    {
                        result++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        return result;
    }
}
// @lc code=end

