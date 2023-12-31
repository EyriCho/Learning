/*
 * @lc app=leetcode id=1582 lang=csharp
 *
 * [1582] Special Positions in a Binary Matrix
 */

// @lc code=start
public class Solution {
    public int NumSpecial(int[][] mat) {
        int[] rows = new int[mat.Length],
            columns = new int[mat[0].Length];
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                rows[i] += mat[i][j];
                columns[j] += mat[i][j];
            }
        }

        int result = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 1 && rows[i] == 1 && columns[j] == 1)
                {
                    result++;
                    break;
                }
            
            }
        }
        return result;
    }
}
// @lc code=end

