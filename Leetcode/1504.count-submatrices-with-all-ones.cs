/*
 * @lc app=leetcode id=1504 lang=csharp
 *
 * [1504] Count Submatrices With All Ones
 */

// @lc code=start
public class Solution {
    public int NumSubmat(int[][] mat) {
        int[,] heights = new int[mat.Length, mat[0].Length];
        int result = 0,
            height = 0;
        for (int j = 0; j < mat[0].Length; j++)
        {
            if (mat[0][j] == 0)
            {
                height = 0;
            }
            else
            {
                height++;
            }
            heights[0, j] = mat[0][j];
            result += height;
        }
        for (int i = 1; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    continue;
                }

                height = heights[i, j] = heights[i - 1, j] + 1;
                result += height;
                for (int k = j - 1; k >= 0; k--)
                {
                    height = Math.Min(height, heights[i, k]);

                    if (height == 0)
                    {
                        break;
                    }
                    result += height;
                }
            }
        }

        return result;
    }
}
// @lc code=end

