/*
 * @lc app=leetcode id=1380 lang=csharp
 *
 * [1380] Lucky Numbers in a Matrix
 */

// @lc code=start
public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int[] columns = new int[matrix[0].Length],
            rows = new int[matrix.Length];
        
        Array.Fill(rows, int.MaxValue);
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                rows[i] = Math.Min(rows[i], matrix[i][j]);
                columns[j] = Math.Max(columns[j], matrix[i][j]);
            }
        }

        List<int> result = new ();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (rows[i] == columns[j])
                {
                    result.Add(rows[i]);
                    break;
                }
            }
        }

        return result;
    }
}
// @lc code=end

