/*
 * @lc app=leetcode id=2661 lang=csharp
 *
 * [2661] First Completely Painted Row or Column
 */

// @lc code=start
public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        Dictionary<int, int> dict = new ();
        for (int i = 0; i < arr.Length; i++)
        {
            dict[arr[i]] = i;
        }

        int[] rows = new int[mat.Length],
            columns = new int[mat[0].Length];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                rows[i] = Math.Max(rows[i], dict[mat[i][j]]);
                columns[j] = Math.Max(columns[j], dict[mat[i][j]]);
            }
        }

        int result = int.MaxValue;
        for (int i = 0; i < rows.Length; i++)
        {
            result = Math.Min(result, rows[i]);
        }
        for (int j = 0; j < columns.Length; j++)
        {
            result = Math.Min(result, columns[j]);
        }

        return result;
    }
}
// @lc code=end

