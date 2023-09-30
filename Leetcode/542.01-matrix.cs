/*
 * @lc app=leetcode id=542 lang=csharp
 *
 * [542] 01 Matrix
 */

// @lc code=start
public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        var result = new int[mat.Length][];
        var fillVal = int.MaxValue - 10_000;
        for (int i = 0; i < mat.Length; i++)
        {
            result[i] = new int[mat[0].Length];
            Array.Fill(result[i], fillVal);
        }
        
        int lastRow = mat.Length - 1,
            lastColumn = mat[0].Length - 1;
        
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    result[i][j] = 0;
                }
                else
                {
                    if (i > 0)
                    {
                        result[i][j] = Math.Min(result[i][j], result[i - 1][j] + 1);
                    }
                    
                    if (j > 0)
                    {
                        result[i][j] = Math.Min(result[i][j], result[i][j - 1] + 1);
                    }
                }
            }
        }
        
        for (int i = mat.Length - 1; i >= 0; i--)
        {
            for (int j = mat[0].Length - 1; j >= 0; j--)
            {
                if (mat[i][j] == 0)
                {
                    result[i][j] = 0;
                }
                else
                {
                    if (i < lastRow)
                    {
                        result[i][j] = Math.Min(result[i][j], result[i + 1][j] + 1);
                    }
                    
                    if (j < lastColumn)
                    {
                        result[i][j] = Math.Min(result[i][j], result[i][j + 1] + 1);
                    }
                }
            }
        }

        return result;
    }
}
// @lc code=end

